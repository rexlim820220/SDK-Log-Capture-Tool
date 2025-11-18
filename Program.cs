using System;
using System.Windows.Forms;
using SDK_Log_Capture_Tool.ATEQ;
using SDK_Log_Capture_Tool.Utils;

namespace SDK_Log_Capture_Tool
{
    static class Program
    {
        ///<summary>
        ///應用程式的主要進入點。
        ///</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IAteqModbusTransport transport;
            string targetPortName = SerialPortDetector.FindProlificUsbPort();

            if (string.IsNullOrEmpty(targetPortName))
            {
#if DEBUG
                transport = new MockModbusTransport();
#else
                MessageBox.Show("Not found Prolific PL2303GT USB Serial Port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
#endif
            }
            else
            {
                transport = new ModbusTransport(targetPortName);
            }
            Application.Run(new SDK_Log_Capturer(transport));
        }
    }
}
