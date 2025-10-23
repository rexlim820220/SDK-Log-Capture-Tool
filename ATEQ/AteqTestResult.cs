using System.Collections.Generic;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class AteqTestResult
    {
        public int ResultCode { get; set; } // 0~3
        public Dictionary<string, double> Parameters { get; set; } = new Dictionary<string, double>();
        public bool HasAlarm { get; set; }
        public string Status { get; set; } // "PASS", "FAIL", "RUNNING", "IDLE"
    }
}
