namespace SDK_Log_Capture_Tool.ATEQ
{
    public interface IAteqModbusTransport
    {
        void Connect();
        void Disconnect();
        int[] ReadHoldingRegisters(int address, int count);
    }
}
