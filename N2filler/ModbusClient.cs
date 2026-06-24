using System;
using EasyModbus;

namespace SDK_Log_Capture_Tool.ModbusTcp
{
    public class ModbusClient : IDisposable
    {
        private readonly ModbusClient _client;

        public string IpAddress { get; }
        public int Port { get; }
        public byte UnitIdentifier { get; set; } = 1;
        public int ConnectTimeout { get; set; } = 5000;
        public int ReadTimeout { get; set; } = 3000;
        public int WriteTimeout { get; set; } = 3000;

        public ModbusClient(string ipAddress, int port = 502)
        {
            IpAddress = ipAddress;
            Port = port;

            _client = new ModbusClient(ipAddress, port)
            {
                UnitIdentifier = UnitIdentifier,
                ConnectTimeout = ConnectTimeout,
                ReadTimeout = ReadTimeout,
                WriteTimeout = WriteTimeout
            };
        }

        public void Connect()
        {
            try
            {
                _client.Connect();
            }
            catch (Exception ex)
            {
                throw new ModbusException($"Unable to connect to {IpAddress}:{Port}", ex);
            }
        }

        public int[] ReadInputRegisters(int startAddress, int count)
        {
            try
            {
                Connect();
                return _client.ReadInputRegisters(startAddress, count);
            }
            catch (Exception ex)
            {
                throw new ModbusException($"Failed to read Holding Register (Address: {startAddress}, Count: {count})", ex);
            }
        }

        public void Disconnect()
        {
            _client.Disconnect();
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}