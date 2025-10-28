using System;
using EasyModbus;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class ModbusTransport : IAteqModbusTransport
    {
        private readonly ModbusClient _client;

        public ModbusTransport(string portName)
        {
            if (string.IsNullOrWhiteSpace(portName))
                throw new ArgumentException("Port name cannot be null or empty.", nameof(portName));

            _client = new ModbusClient(portName);
        }

        public void Connect()
        {
            if (!_client.Connected)
                _client.Connect();
        }

        public void Disconnect()
        {
            if (_client.Connected)
                _client.Disconnect();
        }

        public int[] ReadHoldingRegisters(int startAddress, int count)
        {
            if (!_client.Connected)
                throw new InvalidOperationException("Modbus client is not connected.");

            return _client.ReadHoldingRegisters(startAddress, count);
        }
    }
}