namespace SDK_Log_Capture_Tool.SFIS
{
    public class TCPSocketSetting
    {
        public const int DEFAULT_TIMEOUT = -1;

        public int ConnectTimeout { get; set; }
        public int SendTimeout { get; set; }
        public int ReceiveTimeout { get; set; }

        public TCPSocketSetting()
        {
            ConnectTimeout = DEFAULT_TIMEOUT;
            SendTimeout = DEFAULT_TIMEOUT;
            ReceiveTimeout = DEFAULT_TIMEOUT;
        }
    }
}
