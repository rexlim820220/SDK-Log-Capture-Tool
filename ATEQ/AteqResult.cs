using System.Collections.Generic;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class AteqResult
    {
        public string ProgramID { get; set; }
        public double Pressure { get; set; }
        public double LeakRate { get; set; }
        public int ResultCode { get; set; }
        public bool HasAlarm { get; set; }
        public string Status { get; set; }
        public Dictionary<string, double> Parameters { get; set; }

        public AteqResult()
        {
            Parameters = new Dictionary<string, double>();
        }

        public void UpdateParameters()
        {
            Parameters["Pressure"] = Pressure;
            Parameters["LeakRate"] = LeakRate;
        }
    }
}
