using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZoiperWinForms
{
    public class TCamDeviceManager
    {
        [DllImport("avicap32.dll")]
        protected static extern bool capGetDriverDescriptionA(short wDriverIndex,
            [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName,
            int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

        static ArrayList devices = new ArrayList();

        public static TCamDevice[] GetAllDevices()
        {
            devices = new ArrayList();

            String dName = "".PadRight(100);
            String dVersion = "".PadRight(100);

            for (short i = 0; i < 10; i++)
            {
                if (capGetDriverDescriptionA(i, ref dName, 100, ref dVersion, 100))
                {
                    TCamDevice d = new TCamDevice(i);
                    d.Name = dName.Trim();
                    d.Version = dVersion.Trim();

                    devices.Add(d);
                }
            }

            return (TCamDevice[])devices.ToArray(typeof(TCamDevice));
        }

        public static TCamDevice GetDevice(int deviceIndex)
        {
            return (TCamDevice)devices[deviceIndex];
        }
    }
}
