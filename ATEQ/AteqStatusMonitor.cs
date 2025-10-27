using System;
using EasyModbus;
using System.Collections.Generic;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class AteqStatusMonitor
    {
        private readonly ModbusClient _client;

        public AteqStatusMonitor(string portName)
        {
            _client = new ModbusClient(portName);
            _client.Connect();
        }

        public bool TryGetResult(out AteqTestResult result)
        {
            result = null;

            // Step 1: 讀取 Cycle Status
            int[] status = _client.ReadHoldingRegisters(40001, 1);
            int cycleStatus = status[0];

            if (cycleStatus != 0) // 0 = Idle
                return false;

            // Step 2: 讀取 Result Code
            int[] resultCodeRaw = _client.ReadHoldingRegisters(40109, 1);
            int resultCode = resultCodeRaw[0];

            if (resultCode == 0 || resultCode == 1) // 尚未開始或測試中
                return false;

            // Step 3: 讀取 Result Area
            int[] resultArea = _client.ReadHoldingRegisters(40097, 16);

            var parameters = new Dictionary<string, double>
            {
                { "Pressure", ConvertToFixedPoint((ushort)resultArea[0], (ushort)resultArea[1]) },
                { "LeakRate", ConvertToFixedPoint((ushort)resultArea[2], (ushort)resultArea[3]) },
                { "TestTime", ConvertToFixedPoint((ushort)resultArea[4], (ushort)resultArea[5]) }
                // 可依據手冊擴充更多欄位
            };

            // Step 4: 讀取 Alarm Bitmask
            int[] alarmRaw = _client.ReadHoldingRegisters(40200, 1);
            bool hasAlarm = alarmRaw[0] != 0;

            // Step 5: 封裝結果
            result = new AteqTestResult
            {
                ResultCode = resultCode,
                Parameters = parameters,
                HasAlarm = hasAlarm,
                Status = GetStatusText(resultCode, hasAlarm)
            };
            return true;
        }

        private double ConvertToFixedPoint(ushort lowWord, ushort highWord)
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
}
