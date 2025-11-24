using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SDK_Log_Capture_Tool.SFIS
{
    class SyncTCPSocket : IDisposable
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private readonly int _connectTimeoutMs;
        private readonly int _sendTimeoutMs;
        private readonly int _receiveTimeoutMs;
        public bool IsConnected => _client?.Connected ?? false;
        private const int DEFAULT_SOCKET_BUFFERSIZE = 1000;

        public Socket Client { get; private set; }
        public int ReceiveByte { get; private set; }

        private readonly TCPSocketSetting socketSetting;
        public SyncTCPSocket(TCPSocketSetting socketSetting)
        {
            Client = new Socket(SocketType.Stream, ProtocolType.Tcp)
            {
                SendTimeout = socketSetting.SendTimeout,
                ReceiveTimeout = socketSetting.ReceiveTimeout
            };
            this.socketSetting = socketSetting;
        }
        public SyncTCPSocket(int connectTimeout, int sendTimeout, int receiveTimeout)
        {
            socketSetting = new TCPSocketSetting()
            {
                ConnectTimeout = connectTimeout,
                SendTimeout = sendTimeout,
                ReceiveTimeout = receiveTimeout
            };
            Client = new Socket(SocketType.Stream, ProtocolType.Tcp)
            {
                SendTimeout = sendTimeout,
                ReceiveTimeout = receiveTimeout
            };
        }
        public void Connect(IPEndPoint endPoint)
        {
            try
            {
                Disconnect(false);
                Client = new Socket(SocketType.Stream, ProtocolType.Tcp)
                {
                    SendTimeout = socketSetting.SendTimeout,
                    ReceiveTimeout = socketSetting.ReceiveTimeout
                };
                Task task = Task.Factory.FromAsync(
                    Client.BeginConnect,  // Begin 方法
                    Client.EndConnect,    // End 方法
                    endPoint,             // 傳遞給 BeginConnect 的參數
                    null);                // 狀態物件 (State object)，這裡不需要

                // 現在你可以使用 ContinueWith 了
                task.ContinueWith((t) =>
                {
                    if (t.IsFaulted)
                    {
                        Console.WriteLine($"連線失敗: {t.Exception.InnerException.Message}");
                    }
                    else
                    {
                        Console.WriteLine("連線成功。");
                    }
                });
                task.Wait(socketSetting.ConnectTimeout);
                if (task.Exception != null) throw task.Exception;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Connect(string ip, int port)
        {
            _client = new TcpClient();
            var connectTask = _client.ConnectAsync(ip, port);
            if (!connectTask.Wait(_connectTimeoutMs))
                throw new TimeoutException("TCP Connect timeout");
            _stream = _client.GetStream();
            _stream.ReadTimeout = _receiveTimeoutMs;
            _stream.WriteTimeout = _sendTimeoutMs;
        }

        public void Disconnect(bool isReuse = true)
        {
            try
            {
                Client.Shutdown(SocketShutdown.Both);
                Client.Disconnect(isReuse);
            }
            catch (Exception) { }
        }
        public async Task SendAsync(byte[] buffer, int offset, int count)
        {
            if (_stream == null) throw new InvalidOperationException("Not connected");
            await _stream.WriteAsync(buffer, offset, count);
        }

        public async Task<int> ReceiveAsync(byte[] buffer, int offset, int count)
        {
            if (_stream == null) throw new InvalidOperationException("Not connected");
            return await _stream.ReadAsync(buffer, offset, count);
        }

        public void Dispose()
        {
            _stream?.Close();
            _client?.Close();
        }
    }
}
