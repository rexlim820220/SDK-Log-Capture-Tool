namespace SDK_Log_Capture_Tool.ATEQ
{
    public interface IAteqModbusTransport
    {
        void Connect();
        int[] ReadHoldingRegisters(int address, int count);
    }
}
