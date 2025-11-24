using System;
using System.Net.Sockets;
using NModbus.Device;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SDK_Log_Capture_Tool.ATEQ
{
    class AteqStatusMonitor
    {
        private readonly IAteqModbusTransport _transport;

        private const int TestItemAddress = 8705;    //0x2201
        private const int ResultCodeAddress = 8708;  //0x2204
        private const int PressureLowAddress = 8710; //0x2206
        private const int LeakRateLowAddress = 8714; //0x220A

        public AteqStatusMonitor(IAteqModbusTransport transport)
        {
            if (transport == null)
            {
                throw new ArgumentNullException(nameof(transport));
            }
            _transport = transport;
        }

        public bool TryGetResult(out AteqResult result)
        {
            result = null;

            try
            {
                // 讀取結果代碼 (0x2204)
                int[] raw = _transport.ReadHoldingRegisters(ResultCodeAddress, 1);
                int status = raw[0];

                if ((status & (1 << 5)) == 0)
                    throw new AteqException("測試尚未開始(Cycle End Bit = 0)!");

                bool pass = (status & (1 << 0)) != 0;
                bool failFlow = (status & 0b0110) != 0;
                bool alarm = (status & (1 << 3)) != 0;
                bool pressureErr = (status & (1 << 4)) != 0;
                // 獲取測試名稱 (0x2201)
                int[] testItenName = _transport.ReadHoldingRegisters(TestItemAddress, 2);
                // 讀取壓力 (0x2206~0x2207)
                int[] pressureRaw = _transport.ReadHoldingRegisters(PressureLowAddress, 2);
                // 讀取洩漏率 (0x220A~0x220B)
                int[] leakRaw = _transport.ReadHoldingRegisters(LeakRateLowAddress, 2);

                result = new AteqResult
                {
                    ProgramID = $"Pr 00{ToProgramNumber(testItenName[0])}",
                    Pressure = ConvertToFixedPoint(pressureRaw[0], pressureRaw[1]),
                    LeakRate = ConvertToFixedPoint(leakRaw[0], leakRaw[1]),
                    HasAlarm = alarm,
                    Status = pass ? "PASS" : "FAIL"
                };

                Console.WriteLine($"Test Item is Pr00{ToProgramNumber(testItenName[0])}");
                return true;
            }
            catch (Exception ex)
            {
                if (ex is AteqException)
                    throw;
                else
                    throw new AteqException("無法從 ATEQ F620 取得資料", ex);
            }
        }

        public static int ToProgramNumber(int lowWord)
        {
            int raw = lowWord;
            return (raw / 256) + 1;
        }

        private double ConvertToFixedPoint(int lowWord, int highWord)
        {
            byte[] bytes = new byte[8];
            BitConverter.GetBytes(lowWord).CopyTo(bytes, 0);
            BitConverter.GetBytes(highWord).CopyTo(bytes, 4);
            long raw = BitConverter.ToInt64(bytes, 0);
            return raw / 1000.0;
        }
    }
}
