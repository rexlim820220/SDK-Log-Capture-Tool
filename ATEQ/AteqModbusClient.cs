using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class AteqModbusClient
    {
        private readonly ModbusClient _client;

        // 常數定義（以十六進位表示）
        private const int StepCodeAddress = 0x0030;       // 判斷 EOC bit
        private const int RealTimeResultAddress = 0x0030; // 即時結果區（壓力、洩漏）
        private const int ResultAreaAddress = 0x9C61;     // 40097
        private const int ResultCodeAddress = 0x9C6D;     // 40109
        private const int AlarmBitmaskAddress = 0x9CB8;   // 40200

        public AteqModbusClient(string portName)
        {
            _client = new ModbusClient(portName);
            _client.Connect();
        }

        public bool IsTestRunning()
        {
            int[] stepCode = _client.ReadHoldingRegisters(StepCodeAddress, 12);
            return (stepCode[4] & (1 << 5)) == 0; // bit 5 = 0 → 測試中
        }

        public bool IsTestFinished()
        {
            int[] stepCode = _client.ReadHoldingRegisters(StepCodeAddress, 12);
            return (stepCode[4] & (1 << 5)) != 0; // bit 5 = 1 → 測試完成
        }

        public bool TryGetLatestResult(out AteqResult result)
        {
            result = null;

            if (!IsTestFinished())
                return false;

            int[] resultCodeRaw = _client.ReadHoldingRegisters(ResultCodeAddress, 1);
            int resultCode = resultCodeRaw[0];

            if (resultCode == 0 || resultCode == 1)
                return false;

            int[] resultArea = _client.ReadHoldingRegisters(ResultAreaAddress, 16);
            int[] alarmRaw = _client.ReadHoldingRegisters(AlarmBitmaskAddress, 1);
            bool hasAlarm = alarmRaw[0] != 0;

            result = new AteqResult
            {
                Pressure = ConvertToFixedPoint(resultArea[0], resultArea[1]),
                LeakRate = ConvertToFixedPoint(resultArea[2], resultArea[3]),
                TestTime = ConvertToFixedPoint(resultArea[4], resultArea[5]),
                ResultCode = resultCode,
                HasAlarm = hasAlarm,
                Status = GetStatusText(resultCode, hasAlarm)
            };

            return true;
        }

        private double ConvertToFixedPoint(int lowWord, int highWord)
        {
            byte[] bytes = new byte[4];
            bytes[0] = (byte)(lowWord & 0xFF);
            bytes[1] = (byte)(lowWord >> 8);
            bytes[2] = (byte)(highWord & 0xFF);
            bytes[3] = (byte)(highWord >> 8);
            int raw = BitConverter.ToInt32(bytes, 0);
            return raw / 1000.0;
        }

        private string GetStatusText(int code, bool alarm)
        {
            if (code == 2 && !alarm)
                return "PASS";
            if ((code == 2 || code == 3) && alarm)
                return "FAIL";
            if (code == 1)
                return "RUNNING";
            return "IDLE";
        }
    }

    public class AteqResult
    {
        public double Pressure { get; set; }
        public double LeakRate { get; set; }
        public double TestTime { get; set; }
        public int ResultCode { get; set; }
        public bool HasAlarm { get; set; }
        public string Status { get; set; }
    }
}

