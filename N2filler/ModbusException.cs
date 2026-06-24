using System;

namespace SDK_Log_Capture_Tool.ModbusTcp
{
    public class ModbusException : Exception
    {
        public ModbusException(string message) : base(message) { }
        public ModbusException(string message, Exception inner) : base(message, inner) { }
    }
}
