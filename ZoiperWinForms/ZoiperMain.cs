using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZDK_NET;
using static ZoiperWinForms.ZoiperManager;

namespace ZoiperWinForms
{
    public partial class ZoiperMain : Form
    {
        static ZoiperManager voip = new ZoiperManager();
        ZoiperManager.ZoiperEvent eventLog = null;
        CameraForm cForm = null;
        Form chatWindow = new Form();
        TextBox inputMessage = new TextBox();
        Button send = new Button();

        //Offline activation form
        Form instruction = new Form();
        Label txtInstructions = new Label();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        Button browseFolder = new Button();
        Button createCertificate = new Button();

        private string strHold   = "Hold Call";
        private string strUnhold = "Unhold Call";
        private string strUnmute = "Unmute Call";
        private string strMute   = "Mute Call";


        private string callrecordfilename = "";
        private string pathForCertificate = "";

        public ZoiperMain()
        {
            InitializeComponent();

            cbTransportType.SelectedIndex = 0;

            eventLog = new ZoiperManager.ZoiperEvent(LogZoiperEvent);

            voip.OnZoiperEvent += eventLog;
            voip.OnActivationError += activationError;
            voip.OnActivationSuccess += activationSuccess;
            voip.OnVideoOffered += videoOffered;
            voip.OnFrameReceived += frameReceived;

            cbTransportType.SelectedIndex = 1;

            btnHoldCall.Text = strHold;
        }

        private void frameReceived(byte[] frame, int width, int height)
        {
            if (cForm != null)
            {
                if (cForm.FormReady)
                {
                    Byte[] bmpBytes = Helper.ConvertYUV2BMP(frame, width, height);
                    var ms = new MemoryStream(bmpBytes);
                    Bitmap bmp = new Bitmap(ms);
                    cForm.frameReceived(bmp);
                }
            }
        }

        private void videoOffered(Call call)
        {
            LogZoiperEvent("Video requested by: " + call.CalleeName);
            call.AcceptVideo(true);
            //ShowCameraForm(call);
        }

        private void activationSuccess(string eventText)
        {
            if (grpBActication.InvokeRequired || btnAddUser.InvokeRequired)
                BeginInvoke(voip.OnActivationSuccess, eventText);
            else
            {
                grpBActication.Enabled = false;
                grpAddUser.Enabled = true;
            }
        }

        private void activationError(string eventText)
        {
            if (grpBActication.InvokeRequired || btnAddUser.InvokeRequired)
                BeginInvoke(voip.OnActivationError, eventText);
            else
            {
                //grpBActication.Enabled = true;
                grpAddUser.Enabled = false;
            }
        }

        private void LogZoiperEvent(String eventText)
        {
            if (rtbRunLog.InvokeRequired)
                BeginInvoke(eventLog, eventText);
            else
            {
                rtbRunLog.Text += eventText + "\n";
                AccountInfoRefresh(lbUsers.SelectedItem as ZoiperManager.VoIPUser);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (voip.AddUser(cbTransportType.SelectedIndex,
                tbUserName.Text , 
                tbPassword.Text , 
                tbServer.Text , 
                chSRTP.Checked , 
                chZRTP.Checked , 
                chFMTP.Checked , 
                chPrivacy.Checked , 
                chStun.Checked , 
                chPreconditions.Checked , 
                chRTCPFeedback.Checked,
                cbProtocolType.Text
                ))
            {
                lbUsers.Items.Clear();
                foreach (var user in voip.ActiveUsers.Values)
                    lbUsers.Items.Add(user);
            }
            else
            {
                MessageBox.Show("Adding user failed", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                if (!voipUser.RegisterUser())
                    MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                if (!voipUser.UnregisterUser())
                    MessageBox.Show("Unregistration failed", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCreateCall_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                if (!voipUser.MakeCall(tbCallee.Text))
                    MessageBox.Show("Call creation failed", "Error", MessageBoxButtons.OK);
            }
        }

        private void AccountInfoRefresh(ZoiperManager.VoIPUser voipUser)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            lbActiveCalls.Items.Clear();
            grpBAccountState.Enabled = (voipUser != null);
            if (grpBAccountState.Enabled)
            {
                tbIsRegistered.Text = voipUser.IsRegistered.ToString();
                foreach (var call in voipUser.ActiveCalls.Values)
                {
                    lbActiveCalls.Items.Add(call);
                }
            }
            else
            {
                tbIsRegistered.Text = "";
            }
            if (lbActiveCalls.Items.Count > 0)
            {
                grpCallControl.Enabled = true;
                if (activeCall != null)
                    lbActiveCalls.SelectedItem = activeCall;
            }
            else
            {
                grpCallControl.Enabled = false;
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountInfoRefresh(lbUsers.SelectedItem as ZoiperManager.VoIPUser);
        }

        private void btnCertActivate_Click(object sender, EventArgs e)
        {
            grpBActication.Enabled = false;
            LoggingLevel logLevel = (LoggingLevel)Enum.Parse(typeof(LoggingLevel),cbDebugLevel.Text);
            voip.Initialize(pathForCertificate , tbCertUserName.Text, tbCertPassword.Text, logLevel);
        }

        private void ZoiperMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            voip.StopContext();
        }

        private void btnHoldCall_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.Held = !activeCall.Held;
                btnHoldCall.Text = (activeCall.Held) ? strUnhold : strHold;
            }
            else
                UnavailableAction();
        }

        private void UnavailableAction()
        {
            SystemSounds.Beep.Play();
        }

        private void lbActiveCalls_SelectedValueChanged(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                grpCallControl.Enabled = true;
                btnHoldCall.Text = (activeCall.Held) ? strUnhold : strHold;
            }
            else
            {
                grpCallControl.Enabled = false;
                btnHoldCall.Text = strHold;
            }
        }

        private ZDK_NET.Conference m_conference = null;
        private void btnAddToConference_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                if (m_conference == null)
                {
                    var calls = new List<ZDK_NET.Call>();
                    foreach (ZDK_NET.Call call in lbActiveCalls.Items)
                    {
                        calls.Add(call);
                    }
                    m_conference = voip.CreateConference(calls);
                }
                else
                    m_conference.AddCall(activeCall);
            }
            else
                UnavailableAction();

        }

        private void btnHangUp_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.HangUp();

                ZoiperManager.VoIPUser voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                if (voipUser != null)
                {
                    voipUser.ActiveCalls.Remove(activeCall.CallHandle);
                    AccountInfoRefresh(voipUser);
                }
            }
            else
                UnavailableAction();
        }

        private void rtbRunLog_TextChanged(object sender, EventArgs e)
        {
            rtbRunLog.SelectionStart = rtbRunLog.Text.Length;
            rtbRunLog.ScrollToCaret();
        }

        private void ShowCameraForm(Call call)
        {
            if ((cForm == null) || (cForm.IsDisposed))
            {
                cForm = new CameraForm();
                cForm.call = call;
                cForm.Show();
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.OfferVideo();
                ShowCameraForm(activeCall);
            }
            else
                UnavailableAction();
        }

        private void ZoiperMain_Load(object sender, EventArgs e)
        {
            tbCertUserName.Text = ConfigurationManager.AppSettings.Get("zdknetuser");
            tbCertPassword.Text = ConfigurationManager.AppSettings.Get("zdknetpasword");
            tbCallee.Text = ConfigurationManager.AppSettings.Get("callee");
            tbUserName.Text = ConfigurationManager.AppSettings.Get("sipuser");

            callrecordfilename = ConfigurationManager.AppSettings.Get("callrecordfilename");
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string MessageText = Microsoft.VisualBasic.Interaction.InputBox("Message", "Text Message", "");
            if (!string.IsNullOrEmpty(MessageText))
            {
                var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                voipUser.SendMessage(tbCallee.Text, MessageText);
            }
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.RecordFileName = callrecordfilename;
                activeCall.StartRecording();
            }
            else
                UnavailableAction();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.StopRecording();
            }
            else
                UnavailableAction();
        }

        private void ZoiperMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(rtbRunLog.Text))
                    Clipboard.SetText(rtbRunLog.Text);
            }
            catch
            {

            }
        }

        private void btnProbeSip_Click(object sender, EventArgs e)
        {
            voip.ProbeSIPTransport(cbTransportType.SelectedIndex, tbUserName.Text, tbPassword.Text, tbServer.Text);
        }

        private void btnMuteCall_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            if (activeCall != null)
            {
                activeCall.Muted = !activeCall.Muted;
                btnMuteCall.Text = (activeCall.Muted) ? strUnmute : strMute;
            }
            else
                UnavailableAction();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (tbCallee.Text != "")
            {
                inputMessage.Name = "Send Message";
                inputMessage.MinimumSize = new Size(250, 150);
                inputMessage.Location = new System.Drawing.Point(20, 18);

                send.Name = "Send Button";
                send.Text = "Send";
                send.Location = new System.Drawing.Point(18, 180);

                chatWindow.Controls.Add(inputMessage);
                chatWindow.Controls.Add(send);

                var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
                if (voipUser.IsRegistered)
                {
                    chatWindow.Show();
                }
                else
                {
                    MessageBox.Show("Please Register before sending messages", "Not Registred",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                send.Click += new System.EventHandler(this.btnSendingMessage);
            }
            else
            {
                MessageBox.Show("Fill in the Peer you want to send the message to", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSendingMessage(object sender, EventArgs e)
        {
            var voipUser = lbUsers.SelectedItem as ZoiperManager.VoIPUser;
            var message = voipUser.Acc.CreateMessage(MessageType.Simple);
            message.SetMessageEventListener(new MessageEventsHandler());
            message.Peer = tbCallee.Text;
            message.Content = inputMessage.Text;

            if (message.SendMessage().Code != ResultCode.Ok)
            {
                MessageBox.Show("Message was not sent!", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOfflineActFolder_Click(object sender, EventArgs e)
        {
            
            txtInstructions.MinimumSize = new Size(250, 150);
            txtInstructions.Text = " 1. Select a path for the certificate to be holded \n\n" +
                " 2. Press create certificate \n\n" +
                " 3. Take the certificat and send it to register5@shop.zoiper \n\n" +
                " 4. You will receive an xml file copy it to the folder you just took the certificate from \n\n" +
                " 5. Press Activate";

            browseFolder.Location = new System.Drawing.Point(18, 180);
            browseFolder.Size = new Size(50, 70);
            browseFolder.Text = "Choice Folder";

            createCertificate.Location = new System.Drawing.Point(100, 180);
            createCertificate.Size = new Size(50, 70);
            createCertificate.Text = "Create File";

            instruction.Controls.Add(createCertificate);
            instruction.Controls.Add(txtInstructions);
            instruction.Controls.Add(browseFolder);
            instruction.Show();

            browseFolder.Click += new System.EventHandler(this.btnBrowseFolder);
            createCertificate.Click += new System.EventHandler(this.btnCreateCertificate);
        }

        private void btnBrowseFolder(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathForCertificate = fbd.SelectedPath;
            }
        }

        private void btnCreateCertificate(object sender, EventArgs e)
        {
            LoggingLevel logLevel = (LoggingLevel)Enum.Parse(typeof(LoggingLevel), cbDebugLevel.Text);
            voip.Initialize(pathForCertificate + "\\" + tbCertUserName.Text + ".certificate", tbCertUserName.Text, tbCertPassword.Text, logLevel);
        }

        private void btnBlindTransfer_Click(object sender, EventArgs e)
        {
            var activeCall = lbActiveCalls.SelectedItem as ZDK_NET.Call;
            var transferee = blindTransfer.Text;
            if (activeCall != null)
            {
                activeCall.BlindTransfer(transferee);
            }
            else
            {
                UnavailableAction();
            }
        }

        private void btnAttendedTransfer_Click(object sender, EventArgs e)
        {
            Result resTransfer;
            var testActive = lbActiveCalls.Items[0] as ZDK_NET.Call;
            var testSecond = lbActiveCalls.Items[1] as ZDK_NET.Call;
            if (testActive != null)
            {
                testActive.Held = !testActive.Held;
                testSecond.Held = !testSecond.Held;
                resTransfer = testActive.AttendedTransfer(testSecond);
            }
            else
            {
                UnavailableAction();
            }
        }
    }
}
