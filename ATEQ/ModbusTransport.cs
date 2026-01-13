using System;
using EasyModbus;
using System.IO.Ports;

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

            // 設定通訊參數
            _client.Baudrate = 9600; // 設定鮑率為 9600
            _client.Parity = Parity.Even; // 設定奇偶校驗位為 Even
            _client.StopBits = StopBits.One; // 設定停止位為 1

            // 由於 EasyModbus 預設資料位元就是 8，所以不需要特別設定
            // 如果需要設定，可以透過 SerialPort 物件來操作，但 EasyModbus 已經封裝好了
            // 8 個資料位元通常是 Modbus RTU 的標準設定
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
