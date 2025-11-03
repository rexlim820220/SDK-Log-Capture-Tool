using System;
using System.IO;
using System.Text.RegularExpressions;
using SDK_Log_Capture_Tool.Utilities;  // 假设Logger和MtdIni在这里
using SDK_Log_Capture_Tool.SFIS;  // 自引用
// 添加服务引用命名空间
using SDK_Log_Capture_Tool.SFISService;  // 假设服务引用命名空间

namespace SDK_Log_Capture_Tool.SFIS
{
    public class SfisProcess
    {
        private static SfisProcess instance;
        private readonly SFISTSPWebServiceSoapClient client;
        private readonly SfisParamData paramData;
        private readonly MtdIni sfisIni;

        private SfisProcess()
        {
            string curDirPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string iniPath = Path.Combine(curDirPath, "SfisConfig.ini");
            sfisIni = new MtdIni(iniPath);
            client = new SFISTSPWebServiceSoapClient();
            paramData = new SfisParamData
            {
                // 从INI加载，与参考代码类似
                ProgramId = sfisIni.GetValue("SFIS", "PROGRAM_ID", string.Empty),
                // ... 其他字段
            };
        }

        public static SfisProcess GetInstance()
        {
            if (instance == null) instance = new SfisProcess();
            return instance;
        }

        // 核心方法：登录（私有，参考代码简化）
        private bool Login()
        {
            // 参考代码的Login逻辑，添加超时处理
            try
            {
                string msg = client.WTSP_LOGINOUT(/* 参数 */);
                // ... 处理IN USED或NOT BEEN USED
                return msg.StartsWith("1");  // 简化判断
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Log(ex.Message);
                throw new SfisException(SfisErrorCode.LoginFail, ex.Message);
            }
        }

        // 核心方法：上传结果（整合ATEQ数据）
        public bool UploadResult(string isn, string data)  // data可以是ATEQ结果字符串
        {
            if (!Login()) return false;
            try
            {
                string input = $"ISN:{isn},DATA:{data},ERROR:{paramData.ErrorCode},TSP:{paramData.Tsp},STATUS:1";
                string msg = client.WTSP_RESULT(/* 参数，参考代码 */);
                Logger.GetInstance().Log("WTSP_RESULT", input, msg);
                return msg.StartsWith("1");
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Log(ex.Message);
                return false;
            }
        }

        // 其他方法：如CheckRoute、GetIsn等，按需添加，参考代码逻辑
        // 示例：GetIsn
        public string GetIsn(string carrierCode, bool needChkRoute)
        {
            // 参考代码，提取Regex部分
            // ...
        }

        // 测试方法：参考TestLogin，用于调试
        public string TestLogin()
        {
            // ...
        }
    }
}
