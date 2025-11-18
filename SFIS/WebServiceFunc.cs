using System;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using SDK_Log_Capture_Tool.pty.sfis.n1;

namespace SDK_Log_Capture_Tool.SFIS
{
    public class WebServiceFunc: ISfisService, IDisposable
    {
        // ----------------- TCP ------------------------
        private readonly SyncTCPSocket _tcpClient;
        private const string ServerIP = "192.168.100.20";
        private const int ServerPort = 5000;
        // ------------- Web Service --------------------
        private readonly SFISTSPWebService _soapClient;
        private readonly ISfisUploadParameters _parameters;

        public WebServiceFunc(ISfisUploadParameters parameters = null)
        {
            _parameters = parameters ?? new DefaultSfisUploadParameters();
            _tcpClient = new SyncTCPSocket(1000, 1000, 1000);
            try {
                _tcpClient.Connect(ServerIP, ServerPort);
            }
            catch (Exception){
                Console.WriteLine($"未成功透過TCP連線到SFIS，請檢察網路連線...");
            }
            // Web Service
            _soapClient = new SFISTSPWebService();
            _soapClient.Url = ConfigurationManager.AppSettings["SFISWebServiceUrl"] ?? "http://pty-sfwspd-n1.sfis.pegatroncorp.com/sfiswebservice/sfistspwebservice.asmx";
            _soapClient.UseDefaultCredentials = true;
            _soapClient.Timeout = 30000;
        }

        #region ----- 上傳主方法 -----
        /// <summary>
        /// 上傳 ISN + 資料，先走 Web Service，失敗則走 TCP
        /// </summary>
        public async Task<SfisResult> UploadResultAsync(string isn, string data)
        {
            try
            {
                string response = await Task.Run(() => _soapClient.WTSP_RESULT(
                    programId: _parameters.ProgramId,
                    programPassword: _parameters.ProgramPassword,
                    ISN: isn,
                    error: _parameters.Error,
                    device: _parameters.Device,
                    TSP: _parameters.TSP,
                    data: data,
                    status: _parameters.Status,
                    CPKFlag: _parameters.CPKFlag
                )).ConfigureAwait(false);

                bool isSuccess = !string.IsNullOrEmpty(response) && response.StartsWith("1");
                return isSuccess
                    ? SfisResult.Success(response)
                    : SfisResult.Failure(response, "Response does not contain '1' and 'SUCCESSFUL'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WebService] Upload failed: {ex.Message}");
                bool tcpSuccess = await UploadViaTcpAsync(isn, data).ConfigureAwait(false);
                return tcpSuccess
                    ? SfisResult.Success("TCP fallback successful.")
                    : SfisResult.Failure("", $"Web and TCP upload failed: {ex.Message}");
            }
        }

        public SfisResult UploadResult(string isn, string data)
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

            string payload = $"{isn}|{data}";
            byte[] bytes = Encoding.UTF8.GetBytes(payload);
            byte[] len = BitConverter.GetBytes((UInt32)bytes.Length);

            try
            {
                await _tcpClient.SendAsync(len, 0, 4);
                await _tcpClient.SendAsync(bytes, 0, bytes.Length);

                byte[] ack = new byte[1]; // 接收回應 (簡單只收一個 byte 代表 OK=1 / NG=0)
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