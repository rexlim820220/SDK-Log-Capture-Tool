using System.Management;
using System.IO.Ports;

namespace SDK_Log_Capture_Tool.Utils
{
    public class SerialPortDetector
    {
        public static string FindProlificUsbPort()
        {
            string targetDeviceNameKeyword = "Prolific PL2303GT USB Serial COM Port";
            string portName = null;
            string query = "SELECT Caption FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%)%'";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection ports = searcher.Get();

                foreach (ManagementObject p in ports)
                {
                    string caption = p["Caption"].ToString();
                    if (caption.Contains(targetDeviceNameKeyword))
                    {
                        int start = caption.IndexOf('(');
                        int end = caption.IndexOf(')');
                        if (start > -1 && end > -1)
                        {
                            portName = caption.Substring(start + 1, end - start - 1);
                            break;
                        }
                    }
                }
            }
            return portName;
        }

        public static string[] GetAllComPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
