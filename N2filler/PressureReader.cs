using System;

namespace SDK_Log_Capture_Tool.ModbusTcp
{
    public class PressureReader
    {
        private readonly EasyModbus.ModbusClient _client;

        public PressureReader(string ipAddress, int port = 8000, byte slaveId = 1)
        {
            _client = new EasyModbus.ModbusClient(ipAddress, port)
            {
                UnitIdentifier = slaveId
            };
        }

        // Pressure at Input Register 39 (2 registers → float)
        private const int Address = 39;
        private const int Count = 2;

        public PressureResult ReadPressure()
        {
            var result = new PressureResult();

            try
            {
                _client.Connect();

                // FC04 = ReadInputRegisters
                int[] regs = _client.ReadInputRegisters(Address, Count);

                // Convert to float (EasyModbus utility)
                float pressure = EasyModbus.ModbusClient.ConvertRegistersToFloat(regs, EasyModbus.ModbusClient.RegisterOrder.LowHigh);

                result.Pressure = pressure;
                result.IsValid = true;
            }
            catch (Exception ex)
            {
                result.IsValid = false;
                result.ErrorMessage = ex.Message;
            }
            finally
            {
                _client.Disconnect();
            }

            return result;
        }
    }
}
