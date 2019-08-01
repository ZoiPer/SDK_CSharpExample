using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZDK_NET;

namespace ZoiperWinForms
{
    public partial class CameraForm : Form
    {
        //TCamDeviceManager manager = new TCamDeviceManager();
        TCamDevice[] allDevices = null;
        TCamDevice selected = null;

        public ZDK_NET.Call call = null;

        private Timer timer = null;

        public bool FormReady = false;
        public bool FrameReceived = false;

        public CameraForm()
        {
            InitializeComponent();

            allDevices = TCamDeviceManager.GetAllDevices();

            FillDeviceCombo(allDevices);

            // Send 24 frames per second
            timer = new Timer();
            timer.Interval = (1000 / 30);
            timer.Tick += new System.EventHandler(this.OnTimedEvent);
            timer.Start();
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            Bitmap orig = new Bitmap(imageIn);
            Bitmap clone = new Bitmap(352, 288,
                System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            using (Graphics gr = Graphics.FromImage(clone))
            {
                gr.DrawImage(orig, new Rectangle(0, 0, clone.Width, clone.Height));
            }

            //Create a BitmapData and Lock all pixels to be written 
            BitmapData bmpData = clone.LockBits(
                                 new Rectangle(0, 0, clone.Width, clone.Height),
                                 ImageLockMode.ReadOnly, clone.PixelFormat);
            int pixelsLen = bmpData.Height * bmpData.Width * 4;
            byte[] data = new byte[pixelsLen];

            //Copy the data from the byte array into BitmapData.Scan0
            Marshal.Copy(bmpData.Scan0, data, 0, data.Length);
            //Unlock the pixels
            clone.UnlockBits(bmpData);

            data = Helper.ConvertBMP2UV420(data, clone.Width, clone.Height);
            return data;

            /*
            using (var ms = new MemoryStream())
            {
                clone.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }//*/
        }

        private unsafe void OnTimedEvent(object sender, System.EventArgs e)
        {
            if (!FrameReceived)
                return;
            if (call != null)
            {
                selected.Capture();
            }
        }

        private void FillDeviceCombo(TCamDevice[] allDevices)
        {
            if (allDevices == null)
                return;
            cmbDevice.DataSource = allDevices;
            cmbDevice.DisplayMember = "Name";
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cmbDevice.SelectedItem as TCamDevice;
            if (selected != null)
            {
                selected.ShowWindow(pboxLocal);

                selected.ImageCaptured += new TCamDevice.WebCamEventHandler(this.ImgCaptured);
            }
        }

        private unsafe void ImgCaptured(object source, Image image)
        {
            if (image == null)
                return;
            byte[] img = ImageToByteArray(image);
            fixed (byte* ptr = img)
            {
                call.SendVideoFrame(ptr, img.Length, 0);
            }
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selected != null)
                selected.Stop();
            if (timer != null)
                timer.Stop();
            if (call != null)
                call.VideoToggleCamera();
            call = null;
        }

        /// <summary>
        /// function CopyDataToBitmap
        /// Purpose: Given the pixel data return a bitmap of size [352,288],PixelFormat=24RGB 
        /// </summary>
        /// <param name="data">Byte array with pixel data</param>
        public Bitmap CopyDataToBitmap(byte[] data)
        {
            //Here create the Bitmap to the know height, width and format
            Bitmap bmp = null;

            if (call == null)
            {
                bmp = new Bitmap(352, 288, PixelFormat.Format24bppRgb);
            }
            else
            {
                bmp = new Bitmap(call.VideoCallInfo.Width,
                call.VideoCallInfo.Height, PixelFormat.Format24bppRgb);
            }

            //Create a BitmapData and Lock all pixels to be written 
            BitmapData bmpData = bmp.LockBits(
                                 new Rectangle(0, 0, bmp.Width, bmp.Height),
                                 ImageLockMode.WriteOnly, bmp.PixelFormat);

            //Copy the data from the byte array into BitmapData.Scan0
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);

            //Unlock the pixels
            bmp.UnlockBits(bmpData);

            //Return the bitmap 
            return bmp;
        }

        public void frameReceived(Bitmap frame)
        {
            if (pboxRemote.InvokeRequired)
            {
                pboxRemote.BeginInvoke(new MethodInvoker(
                delegate ()
                {
                    frameReceived(frame);
                }));
            }
            else
            {
                //if (pboxRemote.Image != null)
                //    pboxRemote.Dispose();
                pboxRemote.Image = frame;
                FrameReceived = true;
            }
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            FormReady = true;
        }
    }
}
