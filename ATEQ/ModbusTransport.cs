using System;
using NModbus;
using NModbus.Serial;
using System.IO.Ports;
using System.Threading;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class ModbusTransport : IAteqModbusTransport
    {
        private readonly IModbusSerialMaster _transport;
        private readonly SerialPort _port;
        private const byte SlaveId = 1;

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
            _transport = factory.CreateRtuMaster(adapter);
            _transport.Transport.Retries = 3;
            _transport.Transport.WaitToRetryMilliseconds = 100;
            _transport.Transport.ReadTimeout = 3000;
            _transport.Transport.WriteTimeout = 3000;
        }

        public void Connect()
        {
            if (!_port.IsOpen)
            {
                try { _port.Open(); }
                catch (Exception ex)
                {
                    throw new Exception($"Cannot open COM Port { _port.PortName }: {ex.Message}");
                }
            }
        }

        public void Disconnect()
        {
            _port?.Close();
        }

        public int[] ReadHoldingRegisters(int startAddress, int count)
        {
            Connect();
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            Thread.Sleep(60);

            try
            {
                ushort[] data = _transport.ReadHoldingRegisters(SlaveId, (ushort)startAddress, (ushort)count);

                Thread.Sleep(60);

                int[] result = new int[data.Length];

                bool isStatusWord = (startAddress == 8708 && count == 1);

                for (int i = 0; i < data.Length; i++)
                {
                    if (isStatusWord)
                    {
                        ushort swapped = (ushort)((data[i] << 8) | (data[i] >> 8));
                        result[i] = swapped;
                    }
                    else
                    {
                        result[i] = data[i];
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Modbus read failed (Address={startAddress}, Count={count}): {ex.Message}", ex);
            }
        }
    }
}
