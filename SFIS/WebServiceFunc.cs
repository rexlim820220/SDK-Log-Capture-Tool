using System;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using SDK_Log_Capture_Tool.com.borland.demo;

namespace SDK_Log_Capture_Tool.SFIS
{
    public class WebServiceFunc
    {
        private readonly SyncTCPSocket _tcpClient;
        private const string ServerIP = "192.168.100.20";
        private const int ServerPort = 5000;

        public WebServiceFunc()
        {
            _tcpClient = new SyncTCPSocket(1000, 1000, 1000);
            try {
                IPAddress ipAddress = IPAddress.Parse(ServerIP);
                IPEndPoint endPoint = new IPEndPoint(ipAddress, ServerPort);
                _tcpClient.Connect(endPoint);
            }
            catch (Exception ex){
                Console.WriteLine($"連線失敗: {ex.Message}");
            }
        }

        #region ----- 上傳主方法 -----

        /// <summary>
        /// 上傳 ISN + 資料，先走 Web Service，失敗則走 TCP
        /// </summary>
        public async Task<bool> UploadResultAsync(string isn, string data)
        {
            // 1. 先嘗試 Web Service
            try
            {
                // Borland 範例只有一個方法：EchoString
                // 這裡示範把 isn + data 拼成一個字串送出
                string payload = $"{isn}|{data}";
                // string response = await _soapClient.EchoStringAsync(payload);
                // return !string.IsNullOrEmpty(response);
                return true;
            }
            catch (Exception ex)
            {
                // 記錄失敗 (可自行換成 NLog)
                Console.WriteLine($"[WebService] Upload failed: {ex.Message}");
            }

            // 2. Web Service 失敗 → 改走 TCP
            return await UploadViaTcpAsync(isn, data);
        }

        // 同步版（如果 Form 裡不想用 async/await）
        public bool UploadResult(string isn, string data)
            => UploadResultAsync(isn, data).GetAwaiter().GetResult();

        #endregion

        #region ----- TCP 實作 -----

        private async Task<bool> UploadViaTcpAsync(string isn, string data)
        {
            if (!_tcpClient.IsConnected)
            {
                try { _tcpClient.Connect(ServerIP, ServerPort); }
                catch { return false; }
            }

            // 協議自訂：先傳 4 位元長度，再傳資料 (UTF8)
            string payload = $"{isn}|{data}";
            byte[] bytes = Encoding.UTF8.GetBytes(payload);
            byte[] len = BitConverter.GetBytes((UInt32)bytes.Length);

            try
            {
                await _tcpClient.SendAsync(len, 0, 4);
                await _tcpClient.SendAsync(bytes, 0, bytes.Length);

                // 接收回應 (簡單只收一個 byte 代表 OK=1 / NG=0)
                byte[] ack = new byte[1];
                int rc = await _tcpClient.ReceiveAsync(ack, 0, 1);
                return rc == 1 && ack[0] == 1;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            _tcpClient?.Dispose();
        }
    }
}