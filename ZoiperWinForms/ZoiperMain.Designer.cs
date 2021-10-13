namespace ZoiperWinForms
{
    partial class ZoiperMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.btnCreateCall = new System.Windows.Forms.Button();
            this.lblCallee = new System.Windows.Forms.Label();
            this.tbCallee = new System.Windows.Forms.TextBox();
            this.rtbRunLog = new System.Windows.Forms.RichTextBox();
            this.cbTransportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBAccountState = new System.Windows.Forms.GroupBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.grpCallControl = new System.Windows.Forms.GroupBox();
            this.btnConference = new System.Windows.Forms.Button();
            this.btnCloseConference = new System.Windows.Forms.Button();
            this.btnAttendedTransfer = new System.Windows.Forms.Button();
            this.blindTransfer = new System.Windows.Forms.TextBox();
            this.btnBlindTransfer = new System.Windows.Forms.Button();
            this.btnMuteCall = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnHangUp = new System.Windows.Forms.Button();
            this.btnAddToConference = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbActiveCalls = new System.Windows.Forms.ListBox();
            this.tbIsRegistered = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCertUserName = new System.Windows.Forms.TextBox();
            this.tbCertPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBActication = new System.Windows.Forms.GroupBox();
            this.cbDebugLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOfflineActFolder = new System.Windows.Forms.Button();
            this.btnCertActivate = new System.Windows.Forms.Button();
            this.chSRTP = new System.Windows.Forms.CheckBox();
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.cbProtocolType = new System.Windows.Forms.ComboBox();
            this.chRTCPFeedback = new System.Windows.Forms.CheckBox();
            this.chPreconditions = new System.Windows.Forms.CheckBox();
            this.chStun = new System.Windows.Forms.CheckBox();
            this.chPrivacy = new System.Windows.Forms.CheckBox();
            this.chFMTP = new System.Windows.Forms.CheckBox();
            this.chZRTP = new System.Windows.Forms.CheckBox();
            this.btnProbeSip = new System.Windows.Forms.Button();
            this.grpBAccountState.SuspendLayout();
            this.grpCallControl.SuspendLayout();
            this.grpBActication.SuspendLayout();
            this.grpAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(75, 207);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(75, 13);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(176, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(75, 39);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(176, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(75, 65);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(176, 20);
            this.tbServer.TabIndex = 3;
            this.tbServer.Text = "sip4.zoiper.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server:";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(260, 32);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(242, 95);
            this.lbUsers.TabIndex = 7;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "VoIP Users List:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(146, 19);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUnregister
            // 
            this.btnUnregister.Location = new System.Drawing.Point(227, 19);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(75, 23);
            this.btnUnregister.TabIndex = 10;
            this.btnUnregister.Text = "Unregister";
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // btnCreateCall
            // 
            this.btnCreateCall.Location = new System.Drawing.Point(227, 48);
            this.btnCreateCall.Name = "btnCreateCall";
            this.btnCreateCall.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCall.TabIndex = 11;
            this.btnCreateCall.Text = "Create Call";
            this.btnCreateCall.UseVisualStyleBackColor = true;
            this.btnCreateCall.Click += new System.EventHandler(this.btnCreateCall_Click);
            // 
            // lblCallee
            // 
            this.lblCallee.AutoSize = true;
            this.lblCallee.Location = new System.Drawing.Point(6, 53);
            this.lblCallee.Name = "lblCallee";
            this.lblCallee.Size = new System.Drawing.Size(39, 13);
            this.lblCallee.TabIndex = 12;
            this.lblCallee.Text = "Callee:";
            // 
            // tbCallee
            // 
            this.tbCallee.Location = new System.Drawing.Point(84, 50);
            this.tbCallee.Name = "tbCallee";
            this.tbCallee.Size = new System.Drawing.Size(137, 20);
            this.tbCallee.TabIndex = 13;
            // 
            // rtbRunLog
            // 
            this.rtbRunLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRunLog.Enabled = false;
            this.rtbRunLog.Location = new System.Drawing.Point(12, 417);
            this.rtbRunLog.Name = "rtbRunLog";
            this.rtbRunLog.Size = new System.Drawing.Size(866, 182);
            this.rtbRunLog.TabIndex = 14;
            this.rtbRunLog.Text = "";
            this.rtbRunLog.TextChanged += new System.EventHandler(this.rtbRunLog_TextChanged);
            // 
            // cbTransportType
            // 
            this.cbTransportType.FormattingEnabled = true;
            this.cbTransportType.Items.AddRange(new object[] {
            "NA",
            "UDP",
            "TCP",
            "TLS"});
            this.cbTransportType.Location = new System.Drawing.Point(75, 91);
            this.cbTransportType.Name = "cbTransportType";
            this.cbTransportType.Size = new System.Drawing.Size(176, 21);
            this.cbTransportType.TabIndex = 15;
            this.cbTransportType.Text = "UDP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Transoprt:";
            // 
            // grpBAccountState
            // 
            this.grpBAccountState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBAccountState.Controls.Add(this.btnSendMessage);
            this.grpBAccountState.Controls.Add(this.grpCallControl);
            this.grpBAccountState.Controls.Add(this.label7);
            this.grpBAccountState.Controls.Add(this.lbActiveCalls);
            this.grpBAccountState.Controls.Add(this.tbIsRegistered);
            this.grpBAccountState.Controls.Add(this.label5);
            this.grpBAccountState.Controls.Add(this.tbCallee);
            this.grpBAccountState.Controls.Add(this.btnCreateCall);
            this.grpBAccountState.Controls.Add(this.btnUnregister);
            this.grpBAccountState.Controls.Add(this.lblCallee);
            this.grpBAccountState.Controls.Add(this.btnRegister);
            this.grpBAccountState.Enabled = false;
            this.grpBAccountState.Location = new System.Drawing.Point(535, 12);
            this.grpBAccountState.Name = "grpBAccountState";
            this.grpBAccountState.Size = new System.Drawing.Size(343, 395);
            this.grpBAccountState.TabIndex = 17;
            this.grpBAccountState.TabStop = false;
            this.grpBAccountState.Text = "VoIP User";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(227, 74);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(88, 23);
            this.btnSendMessage.TabIndex = 28;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // grpCallControl
            // 
            this.grpCallControl.Controls.Add(this.btnCloseConference);
            this.grpCallControl.Controls.Add(this.btnConference);
            this.grpCallControl.Controls.Add(this.btnAttendedTransfer);
            this.grpCallControl.Controls.Add(this.blindTransfer);
            this.grpCallControl.Controls.Add(this.btnBlindTransfer);
            this.grpCallControl.Controls.Add(this.btnMuteCall);
            this.grpCallControl.Controls.Add(this.btnStartRecording);
            this.grpCallControl.Controls.Add(this.btnStopRecording);
            this.grpCallControl.Controls.Add(this.btnMessage);
            this.grpCallControl.Controls.Add(this.btnVideo);
            this.grpCallControl.Controls.Add(this.btnHoldCall);
            this.grpCallControl.Controls.Add(this.btnHangUp);
            this.grpCallControl.Controls.Add(this.btnAddToConference);
            this.grpCallControl.Enabled = false;
            this.grpCallControl.Location = new System.Drawing.Point(9, 165);
            this.grpCallControl.Name = "grpCallControl";
            this.grpCallControl.Size = new System.Drawing.Size(326, 168);
            this.grpCallControl.TabIndex = 24;
            this.grpCallControl.TabStop = false;
            this.grpCallControl.Text = "Call Control";
            // 
            // btnCloseConference
            // 
            this.btnCloseConference.Location = new System.Drawing.Point(249, 48);
            this.btnCloseConference.Name = "btnCloseConference";
            this.btnCloseConference.Size = new System.Drawing.Size(71, 23);
            this.btnCloseConference.TabIndex = 33;
            this.btnCloseConference.Text = "Close Conf";
            this.btnCloseConference.UseVisualStyleBackColor = true;
            this.btnCloseConference.Click += new System.EventHandler(this.btnCloseConference_Click);
            // 
            // btnConference
            // 
            this.btnConference.Location = new System.Drawing.Point(249, 19);
            this.btnConference.Name = "btnConference";
            this.btnConference.Size = new System.Drawing.Size(71, 23);
            this.btnConference.TabIndex = 32;
            this.btnConference.Text = "Create Conf";
            this.btnConference.UseVisualStyleBackColor = true;
            this.btnConference.Click += new System.EventHandler(this.btnConference_Click);
            // 
            // btnAttendedTransfer
            // 
            this.btnAttendedTransfer.Location = new System.Drawing.Point(122, 133);
            this.btnAttendedTransfer.Name = "btnAttendedTransfer";
            this.btnAttendedTransfer.Size = new System.Drawing.Size(121, 23);
            this.btnAttendedTransfer.TabIndex = 31;
            this.btnAttendedTransfer.Text = "Attended Transfer";
            this.btnAttendedTransfer.UseVisualStyleBackColor = true;
            this.btnAttendedTransfer.Click += new System.EventHandler(this.btnAttendedTransfer_Click);
            // 
            // blindTransfer
            // 
            this.blindTransfer.Location = new System.Drawing.Point(6, 108);
            this.blindTransfer.Name = "blindTransfer";
            this.blindTransfer.Size = new System.Drawing.Size(100, 20);
            this.blindTransfer.TabIndex = 30;
            // 
            // btnBlindTransfer
            // 
            this.btnBlindTransfer.Location = new System.Drawing.Point(122, 104);
            this.btnBlindTransfer.Name = "btnBlindTransfer";
            this.btnBlindTransfer.Size = new System.Drawing.Size(121, 23);
            this.btnBlindTransfer.TabIndex = 29;
            this.btnBlindTransfer.Text = "Blind Transfer";
            this.btnBlindTransfer.UseVisualStyleBackColor = true;
            this.btnBlindTransfer.Click += new System.EventHandler(this.btnBlindTransfer_Click);
            // 
            // btnMuteCall
            // 
            this.btnMuteCall.Location = new System.Drawing.Point(168, 48);
            this.btnMuteCall.Name = "btnMuteCall";
            this.btnMuteCall.Size = new System.Drawing.Size(75, 23);
            this.btnMuteCall.TabIndex = 27;
            this.btnMuteCall.Text = "Mute Call";
            this.btnMuteCall.UseVisualStyleBackColor = true;
            this.btnMuteCall.Click += new System.EventHandler(this.btnMuteCall_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(6, 48);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(75, 23);
            this.btnStartRecording.TabIndex = 25;
            this.btnStartRecording.Text = "Record";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(87, 48);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(75, 23);
            this.btnStopRecording.TabIndex = 26;
            this.btnStopRecording.Text = "Stop Record";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(6, 78);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 24;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(168, 19);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 23);
            this.btnVideo.TabIndex = 23;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnHoldCall
            // 
            this.btnHoldCall.Location = new System.Drawing.Point(6, 19);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Size = new System.Drawing.Size(75, 23);
            this.btnHoldCall.TabIndex = 20;
            this.btnHoldCall.Text = "Hold Call";
            this.btnHoldCall.UseVisualStyleBackColor = true;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
            // 
            // btnHangUp
            // 
            this.btnHangUp.Location = new System.Drawing.Point(87, 19);
            this.btnHangUp.Name = "btnHangUp";
            this.btnHangUp.Size = new System.Drawing.Size(75, 23);
            this.btnHangUp.TabIndex = 22;
            this.btnHangUp.Text = "Hang Up";
            this.btnHangUp.UseVisualStyleBackColor = true;
            this.btnHangUp.Click += new System.EventHandler(this.btnHangUp_Click);
            // 
            // btnAddToConference
            // 
            this.btnAddToConference.Location = new System.Drawing.Point(249, 78);
            this.btnAddToConference.Name = "btnAddToConference";
            this.btnAddToConference.Size = new System.Drawing.Size(75, 23);
            this.btnAddToConference.TabIndex = 21;
            this.btnAddToConference.Text = "Add To Conf";
            this.btnAddToConference.UseVisualStyleBackColor = true;
            this.btnAddToConference.Click += new System.EventHandler(this.btnAddToConference_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Active Calls:";
            // 
            // lbActiveCalls
            // 
            this.lbActiveCalls.FormattingEnabled = true;
            this.lbActiveCalls.Location = new System.Drawing.Point(84, 103);
            this.lbActiveCalls.Name = "lbActiveCalls";
            this.lbActiveCalls.Size = new System.Drawing.Size(218, 56);
            this.lbActiveCalls.TabIndex = 18;
            this.lbActiveCalls.SelectedValueChanged += new System.EventHandler(this.lbActiveCalls_SelectedValueChanged);
            // 
            // tbIsRegistered
            // 
            this.tbIsRegistered.Location = new System.Drawing.Point(84, 21);
            this.tbIsRegistered.Name = "tbIsRegistered";
            this.tbIsRegistered.ReadOnly = true;
            this.tbIsRegistered.Size = new System.Drawing.Size(56, 20);
            this.tbIsRegistered.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Is Registered:";
            // 
            // tbCertUserName
            // 
            this.tbCertUserName.Location = new System.Drawing.Point(75, 19);
            this.tbCertUserName.Name = "tbCertUserName";
            this.tbCertUserName.Size = new System.Drawing.Size(104, 20);
            this.tbCertUserName.TabIndex = 18;
            // 
            // tbCertPassword
            // 
            this.tbCertPassword.Location = new System.Drawing.Point(75, 45);
            this.tbCertPassword.Name = "tbCertPassword";
            this.tbCertPassword.Size = new System.Drawing.Size(104, 20);
            this.tbCertPassword.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "User Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password:";
            // 
            // grpBActication
            // 
            this.grpBActication.Controls.Add(this.cbDebugLevel);
            this.grpBActication.Controls.Add(this.label10);
            this.grpBActication.Controls.Add(this.btnOfflineActFolder);
            this.grpBActication.Controls.Add(this.btnCertActivate);
            this.grpBActication.Controls.Add(this.label8);
            this.grpBActication.Controls.Add(this.label9);
            this.grpBActication.Controls.Add(this.tbCertUserName);
            this.grpBActication.Controls.Add(this.tbCertPassword);
            this.grpBActication.Location = new System.Drawing.Point(12, 12);
            this.grpBActication.Name = "grpBActication";
            this.grpBActication.Size = new System.Drawing.Size(190, 159);
            this.grpBActication.TabIndex = 22;
            this.grpBActication.TabStop = false;
            this.grpBActication.Text = "SDK Activation";
            // 
            // cbDebugLevel
            // 
            this.cbDebugLevel.FormattingEnabled = true;
            this.cbDebugLevel.Items.AddRange(new object[] {
            "None",
            "Critical",
            "Error",
            "Warning",
            "Info",
            "Debug",
            "Stack"});
            this.cbDebugLevel.Location = new System.Drawing.Point(81, 71);
            this.cbDebugLevel.Name = "cbDebugLevel";
            this.cbDebugLevel.Size = new System.Drawing.Size(98, 21);
            this.cbDebugLevel.TabIndex = 30;
            this.cbDebugLevel.Text = "Debug";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Debug Level";
            // 
            // btnOfflineActFolder
            // 
            this.btnOfflineActFolder.Location = new System.Drawing.Point(35, 103);
            this.btnOfflineActFolder.Name = "btnOfflineActFolder";
            this.btnOfflineActFolder.Size = new System.Drawing.Size(143, 23);
            this.btnOfflineActFolder.TabIndex = 28;
            this.btnOfflineActFolder.Text = "Offline Activation";
            this.btnOfflineActFolder.UseVisualStyleBackColor = true;
            this.btnOfflineActFolder.Click += new System.EventHandler(this.btnOfflineActFolder_Click);
            // 
            // btnCertActivate
            // 
            this.btnCertActivate.Location = new System.Drawing.Point(35, 130);
            this.btnCertActivate.Name = "btnCertActivate";
            this.btnCertActivate.Size = new System.Drawing.Size(143, 23);
            this.btnCertActivate.TabIndex = 23;
            this.btnCertActivate.Text = "Activate";
            this.btnCertActivate.UseVisualStyleBackColor = true;
            this.btnCertActivate.Click += new System.EventHandler(this.btnCertActivate_Click);
            // 
            // chSRTP
            // 
            this.chSRTP.AutoSize = true;
            this.chSRTP.Location = new System.Drawing.Point(74, 151);
            this.chSRTP.Name = "chSRTP";
            this.chSRTP.Size = new System.Drawing.Size(55, 17);
            this.chSRTP.TabIndex = 25;
            this.chSRTP.Text = "SRTP";
            this.chSRTP.UseVisualStyleBackColor = true;
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.cbProtocolType);
            this.grpAddUser.Controls.Add(this.chRTCPFeedback);
            this.grpAddUser.Controls.Add(this.chPreconditions);
            this.grpAddUser.Controls.Add(this.chStun);
            this.grpAddUser.Controls.Add(this.chPrivacy);
            this.grpAddUser.Controls.Add(this.chFMTP);
            this.grpAddUser.Controls.Add(this.chZRTP);
            this.grpAddUser.Controls.Add(this.btnProbeSip);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Controls.Add(this.chSRTP);
            this.grpAddUser.Controls.Add(this.btnAddUser);
            this.grpAddUser.Controls.Add(this.tbUserName);
            this.grpAddUser.Controls.Add(this.tbPassword);
            this.grpAddUser.Controls.Add(this.label6);
            this.grpAddUser.Controls.Add(this.tbServer);
            this.grpAddUser.Controls.Add(this.cbTransportType);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.lbUsers);
            this.grpAddUser.Location = new System.Drawing.Point(12, 177);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(517, 234);
            this.grpAddUser.TabIndex = 26;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // cbProtocolType
            // 
            this.cbProtocolType.FormattingEnabled = true;
            this.cbProtocolType.Items.AddRange(new object[] {
            "SIP",
            "IAX"});
            this.cbProtocolType.Location = new System.Drawing.Point(75, 119);
            this.cbProtocolType.Name = "cbProtocolType";
            this.cbProtocolType.Size = new System.Drawing.Size(176, 21);
            this.cbProtocolType.TabIndex = 33;
            this.cbProtocolType.Text = "SIP";
            // 
            // chRTCPFeedback
            // 
            this.chRTCPFeedback.AutoSize = true;
            this.chRTCPFeedback.Location = new System.Drawing.Point(165, 184);
            this.chRTCPFeedback.Name = "chRTCPFeedback";
            this.chRTCPFeedback.Size = new System.Drawing.Size(103, 17);
            this.chRTCPFeedback.TabIndex = 32;
            this.chRTCPFeedback.Text = "RTCPFeedback";
            this.chRTCPFeedback.UseVisualStyleBackColor = true;
            // 
            // chPreconditions
            // 
            this.chPreconditions.AutoSize = true;
            this.chPreconditions.Location = new System.Drawing.Point(75, 184);
            this.chPreconditions.Name = "chPreconditions";
            this.chPreconditions.Size = new System.Drawing.Size(90, 17);
            this.chPreconditions.TabIndex = 31;
            this.chPreconditions.Text = "Preconditions";
            this.chPreconditions.UseVisualStyleBackColor = true;
            // 
            // chStun
            // 
            this.chStun.AutoSize = true;
            this.chStun.Location = new System.Drawing.Point(6, 184);
            this.chStun.Name = "chStun";
            this.chStun.Size = new System.Drawing.Size(48, 17);
            this.chStun.TabIndex = 30;
            this.chStun.Text = "Stun";
            this.chStun.UseVisualStyleBackColor = true;
            // 
            // chPrivacy
            // 
            this.chPrivacy.AutoSize = true;
            this.chPrivacy.Location = new System.Drawing.Point(6, 151);
            this.chPrivacy.Name = "chPrivacy";
            this.chPrivacy.Size = new System.Drawing.Size(61, 17);
            this.chPrivacy.TabIndex = 29;
            this.chPrivacy.Text = "Privacy";
            this.chPrivacy.UseVisualStyleBackColor = true;
            // 
            // chFMTP
            // 
            this.chFMTP.AutoSize = true;
            this.chFMTP.Location = new System.Drawing.Point(196, 151);
            this.chFMTP.Name = "chFMTP";
            this.chFMTP.Size = new System.Drawing.Size(55, 17);
            this.chFMTP.TabIndex = 28;
            this.chFMTP.Text = "FMTP";
            this.chFMTP.UseVisualStyleBackColor = true;
            // 
            // chZRTP
            // 
            this.chZRTP.AutoSize = true;
            this.chZRTP.Location = new System.Drawing.Point(135, 151);
            this.chZRTP.Name = "chZRTP";
            this.chZRTP.Size = new System.Drawing.Size(55, 17);
            this.chZRTP.TabIndex = 27;
            this.chZRTP.Text = "ZRTP";
            this.chZRTP.UseVisualStyleBackColor = true;
            // 
            // btnProbeSip
            // 
            this.btnProbeSip.Location = new System.Drawing.Point(165, 207);
            this.btnProbeSip.Name = "btnProbeSip";
            this.btnProbeSip.Size = new System.Drawing.Size(75, 23);
            this.btnProbeSip.TabIndex = 26;
            this.btnProbeSip.Text = "Probe SIP";
            this.btnProbeSip.UseVisualStyleBackColor = true;
            this.btnProbeSip.Click += new System.EventHandler(this.btnProbeSip_Click);
            // 
            // ZoiperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 611);
            this.Controls.Add(this.grpAddUser);
            this.Controls.Add(this.grpBActication);
            this.Controls.Add(this.grpBAccountState);
            this.Controls.Add(this.rtbRunLog);
            this.Name = "ZoiperMain";
            this.Text = "Zoiper SDK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoiperMain_FormClosing);
            this.Load += new System.EventHandler(this.ZoiperMain_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ZoiperMain_MouseDoubleClick);
            this.grpBAccountState.ResumeLayout(false);
            this.grpBAccountState.PerformLayout();
            this.grpCallControl.ResumeLayout(false);
            this.grpCallControl.PerformLayout();
            this.grpBActication.ResumeLayout(false);
            this.grpBActication.PerformLayout();
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Button btnCreateCall;
        private System.Windows.Forms.Label lblCallee;
        private System.Windows.Forms.TextBox tbCallee;
        private System.Windows.Forms.RichTextBox rtbRunLog;
        private System.Windows.Forms.ComboBox cbTransportType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBAccountState;
        private System.Windows.Forms.TextBox tbIsRegistered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbActiveCalls;
        private System.Windows.Forms.TextBox tbCertUserName;
        private System.Windows.Forms.TextBox tbCertPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpBActication;
        private System.Windows.Forms.Button btnCertActivate;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnAddToConference;
        private System.Windows.Forms.Button btnHangUp;
        private System.Windows.Forms.GroupBox grpCallControl;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.CheckBox chSRTP;
        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnProbeSip;
        private System.Windows.Forms.Button btnMuteCall;
        private System.Windows.Forms.CheckBox chZRTP;
        private System.Windows.Forms.CheckBox chFMTP;
        private System.Windows.Forms.CheckBox chPrivacy;
        private System.Windows.Forms.CheckBox chRTCPFeedback;
        private System.Windows.Forms.CheckBox chPreconditions;
        private System.Windows.Forms.CheckBox chStun;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnOfflineActFolder;
        private System.Windows.Forms.Button btnBlindTransfer;
        private System.Windows.Forms.TextBox blindTransfer;
        private System.Windows.Forms.Button btnAttendedTransfer;
        private System.Windows.Forms.Button btnConference;
        private System.Windows.Forms.Button btnCloseConference;
        private System.Windows.Forms.ComboBox cbProtocolType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDebugLevel;
    }
}

