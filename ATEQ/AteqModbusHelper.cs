using System;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public static class AteqModbusHelper
    {
        public static int ParseSignedLong(byte[] bytes)
        {
            if (bytes.Length != 4) throw new ArgumentException("Must be 4 bytes");
            return BitConverter.ToInt32(bytes, 0);
        }

        public static double ParseFixedPoint(byte[] bytes)
        {
            return ParseSignedLong(bytes) / 1000.0;
        }
    }
}
