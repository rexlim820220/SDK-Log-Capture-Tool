using System;
using EasyModbus;
using System.Collections.Generic;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class AteqStatusMonitor
    {
        private readonly IAteqModbusTransport _transport;

        private const int StepCodeAddress = 0x0030;
        private const int ResultAreaAddress = 0x9C61;
        private const int ResultCodeAddress = 0x9C6D;
        private const int AlarmBitmaskAddress = 0x9CB8;

        public AteqStatusMonitor(IAteqModbusTransport transport)
        {
            _transport = transport;
            _transport.Connect();
        }

        public bool IsTestRunning()
        {
            int[] stepCode = _transport.ReadHoldingRegisters(StepCodeAddress, 12);
            return (stepCode[4] & (1 << 5)) == 0;
        }

        public bool IsTestFinished()
        {
            int[] stepCode = _transport.ReadHoldingRegisters(StepCodeAddress, 12);
            return (stepCode[4] & (1 << 5)) != 0;
        }

        public bool TryGetResult(out AteqResult result)
        {
            result = null;

            if (!IsTestFinished())
                return false;

            int[] resultCodeRaw = _transport.ReadHoldingRegisters(ResultCodeAddress, 1);
            int resultCode = resultCodeRaw[0];

            if (resultCode == 0 || resultCode == 1)
                return false;

            int[] resultArea = _transport.ReadHoldingRegisters(ResultAreaAddress, 16);
            int[] alarmRaw = _transport.ReadHoldingRegisters(AlarmBitmaskAddress, 1);
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
}
