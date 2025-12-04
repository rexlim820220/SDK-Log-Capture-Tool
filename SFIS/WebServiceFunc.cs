using System;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using SDK_Log_Capture_Tool.pty.sfis.n1;

namespace SDK_Log_Capture_Tool.SFIS
{
    public class WebServiceFunc: ISfisService
    {
        // ------------- Web Service --------------------
        private readonly SFISTSPWebService _soapClient;
        private readonly ISfisUploadParameters _parameters;
        private bool _isLoggedIn = false;
        public WebServiceFunc(ISfisUploadParameters parameters = null)
        {
            _parameters = parameters ?? new DefaultSfisUploadParameters();
            // Web Service
            _soapClient = new SFISTSPWebService();
            _soapClient.Url = ConfigurationManager.AppSettings["SFISWebServiceUrl"] ?? "http://pty-sfwspd-n1.sfis.pegatroncorp.com/sfiswebservice/sfistspwebservice.asmx";
            _soapClient.UseDefaultCredentials = true;
            _soapClient.Timeout = 30000;
        }

        #region ----- LOGIN 登入 -----
        public async Task<SfisResult> LoginAsync(int _status)
        {
            if (_isLoggedIn)
                return SfisResult.Success("Already logged in");

            try
            {
                string response = await Task.Run(() => _soapClient.WTSP_LOGINOUT(
                    programId: _parameters.ProgramId,
                    programPassword: _parameters.ProgramPassword,
                    op: "LA0800494",
                    password: "LA0800494",
                    device: _parameters.Device,
                    TSP: _parameters.TSP,
                    status: _status
                ));

                bool success = response.TrimStart().StartsWith("1");
                if (success) _isLoggedIn = true;

                return success
                    ? SfisResult.Success(response)
                    : SfisResult.Failure(response, "SFIS Login 失敗");
            }
            catch (Exception ex)
            {
                return SfisResult.Failure("", $"Login Exception: {ex.Message}");
            }
        }
        #endregion

        #region ----- CHKROUTE 檢查路由 -----
        public async Task<SfisResult> CheckRouteAsync(string isn)
        {
            if (!_isLoggedIn)
            {
                var loginResult = await LoginAsync(1);
                if (!loginResult.IsSuccess)
                    return SfisResult.Failure(loginResult.Response, "Error: Cannot call CHKROUTE when logged out");
            }

            try
            {
                string response = await Task.Run(() => _soapClient.WTSP_CHKROUTE(
                    programId: _parameters.ProgramId,
                    programPassword: _parameters.ProgramPassword,
                    ISN: isn,
                    device: _parameters.Device,
                    checkFlag: _parameters.CPKFlag, // IMEI;MAC1;MAC2
                    checkData: "12345;A00001;A00002",
                    type: 1
                )).ConfigureAwait(false);

                bool isSuccess = response.StartsWith("1");
                return isSuccess
                    ? SfisResult.Success(response)
                    : SfisResult.Failure(response, "Route validation error");
            }
            catch (Exception ex)
            {
                return SfisResult.Failure("", $"CHKROUTE Exception: {ex.Message}");
            }
        }

        public SfisResult CheckRoute(string isn)
            => CheckRouteAsync(isn).GetAwaiter().GetResult();
        #endregion


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
                return SfisResult.Failure("", $"Web and TCP upload failed: {ex.Message}");
            }
        }

        public SfisResult UploadResult(string isn, string data)
            => UploadResultAsync(isn, data).GetAwaiter().GetResult();

        #endregion
    }
}