using System;
using NModbus;
using NModbus.Serial;
using System.IO.Ports;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class ModbusTransport : IAteqModbusTransport
    {
        private readonly IModbusMaster _master;
        private readonly SerialPort _port;
        private const byte SlaveId = 1;  // address: 001

        public ModbusTransport(string portName)
        {
            if (string.IsNullOrWhiteSpace(portName))
                throw new ArgumentException("Port name cannot be null or empty.", nameof(portName));

            _port = new SerialPort(portName)
            {
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.Even,
                StopBits = StopBits.One,
                ReadTimeout = 2000,
                WriteTimeout = 1000,
                Handshake = Handshake.None
            };

            var adapter = new SerialPortAdapter(_port);
            var factory = new ModbusFactory();
            _master = factory.CreateRtuMaster(adapter);
        }

        public void Connect()
        {
            if (!_port.IsOpen)
                _port.Open();
        }

        public void Disconnect()
        {
            Disconnect();
        }

        public int[] ReadHoldingRegisters(int address, int count)
        {
            Connect();
            ushort startAddress = (ushort)address;
            ushort[] result = _master.ReadHoldingRegisters(SlaveId, startAddress, (ushort)count);
            int[] intResult = new int[result.Length];
            for (int i = 0; i < result.Length; i++)
                intResult[i] = result[i];
            return intResult;
        }
    }
}
