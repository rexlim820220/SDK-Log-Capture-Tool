using System.Linq;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class MockModbusTransport : IAteqModbusTransport
    {
        public void Connect() { }
        public void Disconnect() { }

        public int[] ReadHoldingRegisters(int startAddress, int count)
        {
            if (startAddress == 0x0030)
            {
                var stepCode = new int[12];
                stepCode[4] = (1 << 5); // 模擬 EOC bit = 1
                return stepCode;
            }

            if (startAddress == 0x9C6D) return new[] { 2 }; // ResultCode = PASS
            if (startAddress == 0x9CB8) return new[] { 0 }; // Alarm = 0
            if (startAddress == 0x9C61) return Enumerable.Repeat(1234, count).ToArray(); // 模擬結果區

            return Enumerable.Repeat(0, count).ToArray();
        }
    }
}
