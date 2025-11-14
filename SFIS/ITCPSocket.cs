using System;
using System.Net;

namespace SDK_Log_Capture_Tool.SFIS
{
    interface ITCPSocket
    {
        void Connect(IPEndPoint endPoint);
        void Disconnect(bool isResue = true);
        bool Connected();
        string SendAndReceive(string cmd, Func<bool> isPause = null);
        bool Send(string cmd, Func<bool> isPause = null);
        int Receive(ref byte[] receiveData, Func<bool> isPause = null);
    }
}
