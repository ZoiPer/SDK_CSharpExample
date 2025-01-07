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
            btnAddUser = new System.Windows.Forms.Button();
            tbUserName = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            tbServer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lbUsers = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            btnUnregister = new System.Windows.Forms.Button();
            btnCreateCall = new System.Windows.Forms.Button();
            lblCallee = new System.Windows.Forms.Label();
            tbCallee = new System.Windows.Forms.TextBox();
            rtbRunLog = new System.Windows.Forms.RichTextBox();
            cbTransportType = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            grpBAccountState = new System.Windows.Forms.GroupBox();
            btnSendMessage = new System.Windows.Forms.Button();
            grpCallControl = new System.Windows.Forms.GroupBox();
            chHangupCallFromConference = new System.Windows.Forms.CheckBox();
            btnRemoveCallFromConference = new System.Windows.Forms.Button();
            btnCloseConference = new System.Windows.Forms.Button();
            btnConference = new System.Windows.Forms.Button();
            btnAttendedTransfer = new System.Windows.Forms.Button();
            blindTransfer = new System.Windows.Forms.TextBox();
            btnBlindTransfer = new System.Windows.Forms.Button();
            btnMuteCall = new System.Windows.Forms.Button();
            btnStartRecording = new System.Windows.Forms.Button();
            btnStopRecording = new System.Windows.Forms.Button();
            btnMessage = new System.Windows.Forms.Button();
            btnVideo = new System.Windows.Forms.Button();
            btnHoldCall = new System.Windows.Forms.Button();
            btnHangUp = new System.Windows.Forms.Button();
            btnAddToConference = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            lbActiveCalls = new System.Windows.Forms.ListBox();
            tbIsRegistered = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            tbCertUserName = new System.Windows.Forms.TextBox();
            tbCertPassword = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            grpBActication = new System.Windows.Forms.GroupBox();
            cbDebugLevel = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            btnOfflineActFolder = new System.Windows.Forms.Button();
            btnCertActivate = new System.Windows.Forms.Button();
            chSRTP = new System.Windows.Forms.CheckBox();
            grpAddUser = new System.Windows.Forms.GroupBox();
            cbProtocolType = new System.Windows.Forms.ComboBox();
            chRTCPFeedback = new System.Windows.Forms.CheckBox();
            chPreconditions = new System.Windows.Forms.CheckBox();
            chStun = new System.Windows.Forms.CheckBox();
            chPrivacy = new System.Windows.Forms.CheckBox();
            chFMTP = new System.Windows.Forms.CheckBox();
            chZRTP = new System.Windows.Forms.CheckBox();
            btnProbeSip = new System.Windows.Forms.Button();
            grpBAccountState.SuspendLayout();
            grpCallControl.SuspendLayout();
            grpBActication.SuspendLayout();
            grpAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new System.Drawing.Point(88, 239);
            btnAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(88, 27);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new System.Drawing.Point(88, 15);
            tbUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new System.Drawing.Size(205, 23);
            tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(88, 45);
            tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(205, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbServer
            // 
            tbServer.Location = new System.Drawing.Point(88, 75);
            tbServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbServer.Name = "tbServer";
            tbServer.Size = new System.Drawing.Size(205, 23);
            tbServer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 48);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 78);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Server:";
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 15;
            lbUsers.Location = new System.Drawing.Point(303, 37);
            lbUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new System.Drawing.Size(282, 109);
            lbUsers.TabIndex = 7;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(300, 18);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 8;
            label4.Text = "VoIP Users List:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(170, 22);
            btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(88, 27);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUnregister
            // 
            btnUnregister.Location = new System.Drawing.Point(265, 22);
            btnUnregister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUnregister.Name = "btnUnregister";
            btnUnregister.Size = new System.Drawing.Size(88, 27);
            btnUnregister.TabIndex = 10;
            btnUnregister.Text = "Unregister";
            btnUnregister.UseVisualStyleBackColor = true;
            btnUnregister.Click += btnUnregister_Click;
            // 
            // btnCreateCall
            // 
            btnCreateCall.Location = new System.Drawing.Point(265, 55);
            btnCreateCall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreateCall.Name = "btnCreateCall";
            btnCreateCall.Size = new System.Drawing.Size(88, 27);
            btnCreateCall.TabIndex = 11;
            btnCreateCall.Text = "Create Call";
            btnCreateCall.UseVisualStyleBackColor = true;
            btnCreateCall.Click += btnCreateCall_Click;
            // 
            // lblCallee
            // 
            lblCallee.AutoSize = true;
            lblCallee.Location = new System.Drawing.Point(7, 61);
            lblCallee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCallee.Name = "lblCallee";
            lblCallee.Size = new System.Drawing.Size(42, 15);
            lblCallee.TabIndex = 12;
            lblCallee.Text = "Callee:";
            // 
            // tbCallee
            // 
            tbCallee.Location = new System.Drawing.Point(98, 58);
            tbCallee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCallee.Name = "tbCallee";
            tbCallee.Size = new System.Drawing.Size(159, 23);
            tbCallee.TabIndex = 13;
            // 
            // rtbRunLog
            // 
            rtbRunLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtbRunLog.Enabled = false;
            rtbRunLog.Location = new System.Drawing.Point(14, 481);
            rtbRunLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtbRunLog.Name = "rtbRunLog";
            rtbRunLog.Size = new System.Drawing.Size(1010, 209);
            rtbRunLog.TabIndex = 14;
            rtbRunLog.Text = "";
            rtbRunLog.TextChanged += rtbRunLog_TextChanged;
            // 
            // cbTransportType
            // 
            cbTransportType.FormattingEnabled = true;
            cbTransportType.Items.AddRange(new object[] { "NA", "UDP", "TCP", "TLS" });
            cbTransportType.Location = new System.Drawing.Point(88, 105);
            cbTransportType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbTransportType.Name = "cbTransportType";
            cbTransportType.Size = new System.Drawing.Size(205, 23);
            cbTransportType.TabIndex = 15;
            cbTransportType.Text = "UDP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 108);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 15);
            label6.TabIndex = 16;
            label6.Text = "Transoprt:";
            // 
            // grpBAccountState
            // 
            grpBAccountState.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpBAccountState.Controls.Add(btnSendMessage);
            grpBAccountState.Controls.Add(grpCallControl);
            grpBAccountState.Controls.Add(label7);
            grpBAccountState.Controls.Add(lbActiveCalls);
            grpBAccountState.Controls.Add(tbIsRegistered);
            grpBAccountState.Controls.Add(label5);
            grpBAccountState.Controls.Add(tbCallee);
            grpBAccountState.Controls.Add(btnCreateCall);
            grpBAccountState.Controls.Add(btnUnregister);
            grpBAccountState.Controls.Add(lblCallee);
            grpBAccountState.Controls.Add(btnRegister);
            grpBAccountState.Enabled = false;
            grpBAccountState.Location = new System.Drawing.Point(624, 14);
            grpBAccountState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpBAccountState.Name = "grpBAccountState";
            grpBAccountState.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpBAccountState.Size = new System.Drawing.Size(400, 456);
            grpBAccountState.TabIndex = 17;
            grpBAccountState.TabStop = false;
            grpBAccountState.Text = "VoIP User";
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new System.Drawing.Point(265, 85);
            btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new System.Drawing.Size(103, 27);
            btnSendMessage.TabIndex = 28;
            btnSendMessage.Text = "Send Message";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // grpCallControl
            // 
            grpCallControl.Controls.Add(chHangupCallFromConference);
            grpCallControl.Controls.Add(btnRemoveCallFromConference);
            grpCallControl.Controls.Add(btnCloseConference);
            grpCallControl.Controls.Add(btnConference);
            grpCallControl.Controls.Add(btnAttendedTransfer);
            grpCallControl.Controls.Add(blindTransfer);
            grpCallControl.Controls.Add(btnBlindTransfer);
            grpCallControl.Controls.Add(btnMuteCall);
            grpCallControl.Controls.Add(btnStartRecording);
            grpCallControl.Controls.Add(btnStopRecording);
            grpCallControl.Controls.Add(btnMessage);
            grpCallControl.Controls.Add(btnVideo);
            grpCallControl.Controls.Add(btnHoldCall);
            grpCallControl.Controls.Add(btnHangUp);
            grpCallControl.Controls.Add(btnAddToConference);
            grpCallControl.Enabled = false;
            grpCallControl.Location = new System.Drawing.Point(10, 190);
            grpCallControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCallControl.Name = "grpCallControl";
            grpCallControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCallControl.Size = new System.Drawing.Size(380, 246);
            grpCallControl.TabIndex = 24;
            grpCallControl.TabStop = false;
            grpCallControl.Text = "Call Control";
            // 
            // chHangupCallFromConference
            // 
            chHangupCallFromConference.AutoSize = true;
            chHangupCallFromConference.Location = new System.Drawing.Point(139, 127);
            chHangupCallFromConference.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chHangupCallFromConference.Name = "chHangupCallFromConference";
            chHangupCallFromConference.Size = new System.Drawing.Size(96, 19);
            chHangupCallFromConference.TabIndex = 35;
            chHangupCallFromConference.Text = "Hang Up Call";
            chHangupCallFromConference.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCallFromConference
            // 
            btnRemoveCallFromConference.Location = new System.Drawing.Point(241, 123);
            btnRemoveCallFromConference.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveCallFromConference.Name = "btnRemoveCallFromConference";
            btnRemoveCallFromConference.Size = new System.Drawing.Size(137, 27);
            btnRemoveCallFromConference.TabIndex = 34;
            btnRemoveCallFromConference.Text = "Remove from Conf";
            btnRemoveCallFromConference.UseVisualStyleBackColor = true;
            btnRemoveCallFromConference.Click += btnRemoveCallFromConference_Click;
            // 
            // btnCloseConference
            // 
            btnCloseConference.Location = new System.Drawing.Point(290, 55);
            btnCloseConference.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCloseConference.Name = "btnCloseConference";
            btnCloseConference.Size = new System.Drawing.Size(83, 27);
            btnCloseConference.TabIndex = 33;
            btnCloseConference.Text = "Close Conf";
            btnCloseConference.UseVisualStyleBackColor = true;
            btnCloseConference.Click += btnCloseConference_Click;
            // 
            // btnConference
            // 
            btnConference.Location = new System.Drawing.Point(290, 22);
            btnConference.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConference.Name = "btnConference";
            btnConference.Size = new System.Drawing.Size(83, 27);
            btnConference.TabIndex = 32;
            btnConference.Text = "Create Conf";
            btnConference.UseVisualStyleBackColor = true;
            btnConference.Click += btnConference_Click;
            // 
            // btnAttendedTransfer
            // 
            btnAttendedTransfer.Location = new System.Drawing.Point(142, 204);
            btnAttendedTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAttendedTransfer.Name = "btnAttendedTransfer";
            btnAttendedTransfer.Size = new System.Drawing.Size(141, 27);
            btnAttendedTransfer.TabIndex = 31;
            btnAttendedTransfer.Text = "Attended Transfer";
            btnAttendedTransfer.UseVisualStyleBackColor = true;
            btnAttendedTransfer.Click += btnAttendedTransfer_Click;
            // 
            // blindTransfer
            // 
            blindTransfer.Location = new System.Drawing.Point(8, 166);
            blindTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            blindTransfer.Name = "blindTransfer";
            blindTransfer.Size = new System.Drawing.Size(116, 23);
            blindTransfer.TabIndex = 30;
            // 
            // btnBlindTransfer
            // 
            btnBlindTransfer.Location = new System.Drawing.Point(142, 166);
            btnBlindTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBlindTransfer.Name = "btnBlindTransfer";
            btnBlindTransfer.Size = new System.Drawing.Size(141, 27);
            btnBlindTransfer.TabIndex = 29;
            btnBlindTransfer.Text = "Blind Transfer";
            btnBlindTransfer.UseVisualStyleBackColor = true;
            btnBlindTransfer.Click += btnBlindTransfer_Click;
            // 
            // btnMuteCall
            // 
            btnMuteCall.Location = new System.Drawing.Point(196, 55);
            btnMuteCall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMuteCall.Name = "btnMuteCall";
            btnMuteCall.Size = new System.Drawing.Size(88, 27);
            btnMuteCall.TabIndex = 27;
            btnMuteCall.Text = "Mute Call";
            btnMuteCall.UseVisualStyleBackColor = true;
            btnMuteCall.Click += btnMuteCall_Click;
            // 
            // btnStartRecording
            // 
            btnStartRecording.Location = new System.Drawing.Point(7, 55);
            btnStartRecording.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStartRecording.Name = "btnStartRecording";
            btnStartRecording.Size = new System.Drawing.Size(88, 27);
            btnStartRecording.TabIndex = 25;
            btnStartRecording.Text = "Record";
            btnStartRecording.UseVisualStyleBackColor = true;
            btnStartRecording.Click += btnStartRecording_Click;
            // 
            // btnStopRecording
            // 
            btnStopRecording.Location = new System.Drawing.Point(102, 55);
            btnStopRecording.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStopRecording.Name = "btnStopRecording";
            btnStopRecording.Size = new System.Drawing.Size(88, 27);
            btnStopRecording.TabIndex = 26;
            btnStopRecording.Text = "Stop Record";
            btnStopRecording.UseVisualStyleBackColor = true;
            btnStopRecording.Click += btnStopRecording_Click;
            // 
            // btnMessage
            // 
            btnMessage.Location = new System.Drawing.Point(7, 90);
            btnMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new System.Drawing.Size(88, 27);
            btnMessage.TabIndex = 24;
            btnMessage.Text = "Message";
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnVideo
            // 
            btnVideo.Location = new System.Drawing.Point(196, 22);
            btnVideo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new System.Drawing.Size(88, 27);
            btnVideo.TabIndex = 23;
            btnVideo.Text = "Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnHoldCall
            // 
            btnHoldCall.Location = new System.Drawing.Point(7, 22);
            btnHoldCall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHoldCall.Name = "btnHoldCall";
            btnHoldCall.Size = new System.Drawing.Size(88, 27);
            btnHoldCall.TabIndex = 20;
            btnHoldCall.Text = "Hold Call";
            btnHoldCall.UseVisualStyleBackColor = true;
            btnHoldCall.Click += btnHoldCall_Click;
            // 
            // btnHangUp
            // 
            btnHangUp.Location = new System.Drawing.Point(102, 22);
            btnHangUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHangUp.Name = "btnHangUp";
            btnHangUp.Size = new System.Drawing.Size(88, 27);
            btnHangUp.TabIndex = 22;
            btnHangUp.Text = "Hang Up";
            btnHangUp.UseVisualStyleBackColor = true;
            btnHangUp.Click += btnHangUp_Click;
            // 
            // btnAddToConference
            // 
            btnAddToConference.Location = new System.Drawing.Point(290, 90);
            btnAddToConference.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddToConference.Name = "btnAddToConference";
            btnAddToConference.Size = new System.Drawing.Size(88, 27);
            btnAddToConference.TabIndex = 21;
            btnAddToConference.Text = "Add To Conf";
            btnAddToConference.UseVisualStyleBackColor = true;
            btnAddToConference.Click += btnAddToConference_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 93);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 15);
            label7.TabIndex = 19;
            label7.Text = "Active Calls:";
            // 
            // lbActiveCalls
            // 
            lbActiveCalls.FormattingEnabled = true;
            lbActiveCalls.ItemHeight = 15;
            lbActiveCalls.Location = new System.Drawing.Point(98, 119);
            lbActiveCalls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbActiveCalls.Name = "lbActiveCalls";
            lbActiveCalls.Size = new System.Drawing.Size(254, 64);
            lbActiveCalls.TabIndex = 18;
            lbActiveCalls.SelectedValueChanged += lbActiveCalls_SelectedValueChanged;
            // 
            // tbIsRegistered
            // 
            tbIsRegistered.Location = new System.Drawing.Point(98, 24);
            tbIsRegistered.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbIsRegistered.Name = "tbIsRegistered";
            tbIsRegistered.ReadOnly = true;
            tbIsRegistered.Size = new System.Drawing.Size(65, 23);
            tbIsRegistered.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 28);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 15);
            label5.TabIndex = 14;
            label5.Text = "Is Registered:";
            // 
            // tbCertUserName
            // 
            tbCertUserName.Location = new System.Drawing.Point(88, 22);
            tbCertUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCertUserName.Name = "tbCertUserName";
            tbCertUserName.Size = new System.Drawing.Size(121, 23);
            tbCertUserName.TabIndex = 18;
            // 
            // tbCertPassword
            // 
            tbCertPassword.Location = new System.Drawing.Point(88, 52);
            tbCertPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCertPassword.Name = "tbCertPassword";
            tbCertPassword.Size = new System.Drawing.Size(121, 23);
            tbCertPassword.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 25);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(68, 15);
            label8.TabIndex = 20;
            label8.Text = "User Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 55);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(60, 15);
            label9.TabIndex = 21;
            label9.Text = "Password:";
            // 
            // grpBActication
            // 
            grpBActication.Controls.Add(cbDebugLevel);
            grpBActication.Controls.Add(label10);
            grpBActication.Controls.Add(btnOfflineActFolder);
            grpBActication.Controls.Add(btnCertActivate);
            grpBActication.Controls.Add(label8);
            grpBActication.Controls.Add(label9);
            grpBActication.Controls.Add(tbCertUserName);
            grpBActication.Controls.Add(tbCertPassword);
            grpBActication.Location = new System.Drawing.Point(14, 14);
            grpBActication.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpBActication.Name = "grpBActication";
            grpBActication.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpBActication.Size = new System.Drawing.Size(222, 183);
            grpBActication.TabIndex = 22;
            grpBActication.TabStop = false;
            grpBActication.Text = "SDK Activation";
            // 
            // cbDebugLevel
            // 
            cbDebugLevel.FormattingEnabled = true;
            cbDebugLevel.Items.AddRange(new object[] { "None", "Critical", "Error", "Warning", "Info", "Debug", "Stack" });
            cbDebugLevel.Location = new System.Drawing.Point(94, 82);
            cbDebugLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDebugLevel.Name = "cbDebugLevel";
            cbDebugLevel.Size = new System.Drawing.Size(114, 23);
            cbDebugLevel.TabIndex = 30;
            cbDebugLevel.Text = "Debug";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 85);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(72, 15);
            label10.TabIndex = 29;
            label10.Text = "Debug Level";
            // 
            // btnOfflineActFolder
            // 
            btnOfflineActFolder.Location = new System.Drawing.Point(41, 119);
            btnOfflineActFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOfflineActFolder.Name = "btnOfflineActFolder";
            btnOfflineActFolder.Size = new System.Drawing.Size(167, 27);
            btnOfflineActFolder.TabIndex = 28;
            btnOfflineActFolder.Text = "Offline Activation";
            btnOfflineActFolder.UseVisualStyleBackColor = true;
            btnOfflineActFolder.Click += btnOfflineActFolder_Click;
            // 
            // btnCertActivate
            // 
            btnCertActivate.Location = new System.Drawing.Point(41, 150);
            btnCertActivate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCertActivate.Name = "btnCertActivate";
            btnCertActivate.Size = new System.Drawing.Size(167, 27);
            btnCertActivate.TabIndex = 23;
            btnCertActivate.Text = "Activate";
            btnCertActivate.UseVisualStyleBackColor = true;
            btnCertActivate.Click += btnCertActivate_Click;
            // 
            // chSRTP
            // 
            chSRTP.AutoSize = true;
            chSRTP.Location = new System.Drawing.Point(86, 174);
            chSRTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chSRTP.Name = "chSRTP";
            chSRTP.Size = new System.Drawing.Size(51, 19);
            chSRTP.TabIndex = 25;
            chSRTP.Text = "SRTP";
            chSRTP.UseVisualStyleBackColor = true;
            // 
            // grpAddUser
            // 
            grpAddUser.Controls.Add(cbProtocolType);
            grpAddUser.Controls.Add(chRTCPFeedback);
            grpAddUser.Controls.Add(chPreconditions);
            grpAddUser.Controls.Add(chStun);
            grpAddUser.Controls.Add(chPrivacy);
            grpAddUser.Controls.Add(chFMTP);
            grpAddUser.Controls.Add(chZRTP);
            grpAddUser.Controls.Add(btnProbeSip);
            grpAddUser.Controls.Add(label1);
            grpAddUser.Controls.Add(chSRTP);
            grpAddUser.Controls.Add(btnAddUser);
            grpAddUser.Controls.Add(tbUserName);
            grpAddUser.Controls.Add(tbPassword);
            grpAddUser.Controls.Add(label6);
            grpAddUser.Controls.Add(tbServer);
            grpAddUser.Controls.Add(cbTransportType);
            grpAddUser.Controls.Add(label2);
            grpAddUser.Controls.Add(label3);
            grpAddUser.Controls.Add(label4);
            grpAddUser.Controls.Add(lbUsers);
            grpAddUser.Location = new System.Drawing.Point(14, 204);
            grpAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpAddUser.Name = "grpAddUser";
            grpAddUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpAddUser.Size = new System.Drawing.Size(603, 270);
            grpAddUser.TabIndex = 26;
            grpAddUser.TabStop = false;
            grpAddUser.Text = "Add User";
            // 
            // cbProtocolType
            // 
            cbProtocolType.FormattingEnabled = true;
            cbProtocolType.Items.AddRange(new object[] { "SIP", "IAX" });
            cbProtocolType.Location = new System.Drawing.Point(88, 137);
            cbProtocolType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbProtocolType.Name = "cbProtocolType";
            cbProtocolType.Size = new System.Drawing.Size(205, 23);
            cbProtocolType.TabIndex = 33;
            cbProtocolType.Text = "SIP";
            // 
            // chRTCPFeedback
            // 
            chRTCPFeedback.AutoSize = true;
            chRTCPFeedback.Location = new System.Drawing.Point(192, 212);
            chRTCPFeedback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chRTCPFeedback.Name = "chRTCPFeedback";
            chRTCPFeedback.Size = new System.Drawing.Size(102, 19);
            chRTCPFeedback.TabIndex = 32;
            chRTCPFeedback.Text = "RTCPFeedback";
            chRTCPFeedback.UseVisualStyleBackColor = true;
            // 
            // chPreconditions
            // 
            chPreconditions.AutoSize = true;
            chPreconditions.Location = new System.Drawing.Point(88, 212);
            chPreconditions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chPreconditions.Name = "chPreconditions";
            chPreconditions.Size = new System.Drawing.Size(99, 19);
            chPreconditions.TabIndex = 31;
            chPreconditions.Text = "Preconditions";
            chPreconditions.UseVisualStyleBackColor = true;
            // 
            // chStun
            // 
            chStun.AutoSize = true;
            chStun.Location = new System.Drawing.Point(7, 212);
            chStun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chStun.Name = "chStun";
            chStun.Size = new System.Drawing.Size(50, 19);
            chStun.TabIndex = 30;
            chStun.Text = "Stun";
            chStun.UseVisualStyleBackColor = true;
            // 
            // chPrivacy
            // 
            chPrivacy.AutoSize = true;
            chPrivacy.Location = new System.Drawing.Point(7, 174);
            chPrivacy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chPrivacy.Name = "chPrivacy";
            chPrivacy.Size = new System.Drawing.Size(64, 19);
            chPrivacy.TabIndex = 29;
            chPrivacy.Text = "Privacy";
            chPrivacy.UseVisualStyleBackColor = true;
            // 
            // chFMTP
            // 
            chFMTP.AutoSize = true;
            chFMTP.Location = new System.Drawing.Point(229, 174);
            chFMTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chFMTP.Name = "chFMTP";
            chFMTP.Size = new System.Drawing.Size(56, 19);
            chFMTP.TabIndex = 28;
            chFMTP.Text = "FMTP";
            chFMTP.UseVisualStyleBackColor = true;
            // 
            // chZRTP
            // 
            chZRTP.AutoSize = true;
            chZRTP.Location = new System.Drawing.Point(158, 174);
            chZRTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chZRTP.Name = "chZRTP";
            chZRTP.Size = new System.Drawing.Size(52, 19);
            chZRTP.TabIndex = 27;
            chZRTP.Text = "ZRTP";
            chZRTP.UseVisualStyleBackColor = true;
            // 
            // btnProbeSip
            // 
            btnProbeSip.Location = new System.Drawing.Point(192, 239);
            btnProbeSip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProbeSip.Name = "btnProbeSip";
            btnProbeSip.Size = new System.Drawing.Size(88, 27);
            btnProbeSip.TabIndex = 26;
            btnProbeSip.Text = "Probe SIP";
            btnProbeSip.UseVisualStyleBackColor = true;
            btnProbeSip.Click += btnProbeSip_Click;
            // 
            // ZoiperMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1038, 705);
            Controls.Add(grpAddUser);
            Controls.Add(grpBActication);
            Controls.Add(grpBAccountState);
            Controls.Add(rtbRunLog);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ZoiperMain";
            Text = "Zoiper SDK";
            FormClosing += ZoiperMain_FormClosing;
            Load += ZoiperMain_Load;
            MouseDoubleClick += ZoiperMain_MouseDoubleClick;
            grpBAccountState.ResumeLayout(false);
            grpBAccountState.PerformLayout();
            grpCallControl.ResumeLayout(false);
            grpCallControl.PerformLayout();
            grpBActication.ResumeLayout(false);
            grpBActication.PerformLayout();
            grpAddUser.ResumeLayout(false);
            grpAddUser.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRemoveCallFromConference;
        private System.Windows.Forms.CheckBox chHangupCallFromConference;
    }
}

