using System.Collections.Generic;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class AteqResult
    {
        public int ResultCode { get; set; } //0~3
        public Dictionary<string, double> Parameters { get; set; } = new Dictionary<string, double>();
        public double Pressure { get; set; }
        public double LeakRate { get; set; }
        public double TestTime { get; set; }
        public bool HasAlarm { get; set; }
        public string Status { get; set; } //"PASS", "FAIL", "RUNNING", "IDLE"
    }
}
