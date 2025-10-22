using EasyModbus;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class AteqModbusReader : IAteqReader
    {
        private readonly ModbusClient _client;
        private const int PressureAddress = 1000; // 假設地址
        private const int LeakAddress = 1002;
        private const int ResultAddress = 1004;

        public AteqModbusReader(string portName)
        {
            _client = new ModbusClient(portName);
            _client.Connect();
        }

        public AteqData ReadData()
        {
            var pressureBytes = ReadBytes(PressureAddress);
            var leakBytes = ReadBytes(LeakAddress);
            var resultBytes = _client.ReadInputRegisters(ResultAddress, 1);
            return new AteqData
            {
                Pressure = AteqModbusHelper.ParseFixedPoint(pressureBytes),
                Leak = AteqModbusHelper.ParseFixedPoint(leakBytes),
                IsPass = resultBytes[0] == 1
            };
        }

        private byte[] ReadBytes(int address)
        {
            var regs = _client.ReadInputRegisters(address, 2);
            return new byte[]
            {
            (byte)(regs[0] & 0xFF),
            (byte)(regs[0] >> 8),
            (byte)(regs[1] & 0xFF),
            (byte)(regs[1] >> 8)
            };
        }
    }
}
