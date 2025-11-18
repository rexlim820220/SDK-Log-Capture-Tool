using System.Threading.Tasks;

namespace SDK_Log_Capture_Tool.SFIS
{
    public class SfisResult
    {
        public bool IsSuccess { get; }
        public string Response { get; }
        public string ErrorMessage { get; }

        public SfisResult(bool _isSuccess, string _response, string _errorMessage  = null)
        {
            IsSuccess = _isSuccess;
            Response = _response;
            ErrorMessage = _errorMessage;
        }

        public static SfisResult Success(string response) => new SfisResult(true, response);
        public static SfisResult Failure(string response, string errorMessage) => new SfisResult(false, response, errorMessage); 
    }

    public interface ISfisService
    {
        Task<SfisResult> UploadResultAsync(string isn, string data);
        SfisResult UploadResult(string isn, string data);
    }
}
