using System;

namespace SDK_Log_Capture_Tool.ATEQ
{
    public class AteqException: Exception
    {
        public AteqException(string message) : base(message) { }
        public AteqException(string message, Exception inner) : base(message, inner) { }
    }
}
