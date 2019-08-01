using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoiperWinForms
{
    public class TCamDevice
    {
        private const short WM_CAP = 0x400;
        private const int WM_CAP_DRIVER_CONNECT = 0x40a;
        private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        private const int WM_CAP_EDIT_COPY = 0x41e;
        private const int WM_CAP_SET_PREVIEW = 0x432;
        private const int WM_CAP_SET_OVERLAY = 0x433;
        private const int WM_CAP_SET_PREVIEWRATE = 0x434;
        private const int WM_CAP_SET_SCALE = 0x435;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;

        public const int WM_CAP_GET_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;

        [DllImport("avicap32.dll")]
        protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName,
            int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

        [DllImport("user32", EntryPoint = "SendMessageA")]
        protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

        [DllImport("user32")]
        protected static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("user32")]
        protected static extern bool DestroyWindow(int hwnd);

        int index;
        int deviceHandle;

        // event delegate
        public delegate void WebCamEventHandler(object source, Image e);
        // fired when a new image is captured
        public event WebCamEventHandler ImageCaptured;

        private IDataObject tempObj;
        private System.Drawing.Image tempImg;

        public TCamDevice(int index)
        {
            this.index = index;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _version;

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }
        /// <summary>
        /// To Initialize the device
        /// </summary>
        /// <param name="windowHeight">Height of the Window</param>
        /// <param name="windowWidth">Width of the Window</param>
        /// <param name="handle">The Control Handle to attach the device</param>
        public void Init(int windowHeight, int windowWidth, int handle)
        {
            string deviceIndex = Convert.ToString(this.index);
            deviceHandle = capCreateCaptureWindowA(ref deviceIndex, WS_VISIBLE | WS_CHILD, 0, 0, windowWidth, windowHeight, handle, 0);

            if (SendMessage(deviceHandle, WM_CAP_DRIVER_CONNECT, this.index, 0) > 0)
            {
                SendMessage(deviceHandle, WM_CAP_SET_SCALE, -1, 0);
                SendMessage(deviceHandle, WM_CAP_SET_PREVIEWRATE, 0x42, 0);
                SendMessage(deviceHandle, WM_CAP_SET_PREVIEW, -1, 0);

                SetWindowPos(deviceHandle, 1, 0, 0, windowWidth, windowHeight, 6);
            }
        }

        /// <summary>
        /// Shows the webcam preview in the control
        /// </summary>
        /// <param name="windowsControl">Control to attach the webcam preview</param>
        public void ShowWindow(global::System.Windows.Forms.Control windowsControl)
        {
            Init(windowsControl.Height, windowsControl.Width, windowsControl.Handle.ToInt32());
        }

        /// <summary>
        /// Stop the webcam and destroy the handle
        /// </summary>
        public void Stop()
        {
            SendMessage(deviceHandle, WM_CAP_DRIVER_DISCONNECT, this.index, 0);

            DestroyWindow(deviceHandle);
        }

        public void Capture()
        {

            // get the next frame;
            SendMessage(deviceHandle, WM_CAP_GET_FRAME, 0, 0);

            // copy the frame to the clipboard
            SendMessage(deviceHandle, WM_CAP_COPY, 0, 0);

            // paste the frame into the event args image
            if (ImageCaptured != null)
            {
                // get from the clipboard
                tempObj = Clipboard.GetDataObject();
                tempImg = (System.Drawing.Bitmap)tempObj.GetData(System.Windows.Forms.DataFormats.Bitmap);

                ImageCaptured(this, tempImg);
            }

        }
    }
}
