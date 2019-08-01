namespace ZoiperWinForms
{
    partial class CameraForm
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
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.pboxLocal = new System.Windows.Forms.PictureBox();
            this.pboxRemote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRemote)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(72, 12);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(260, 21);
            this.cmbDevice.TabIndex = 0;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(12, 15);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "Device:";
            // 
            // pboxLocal
            // 
            this.pboxLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxLocal.Location = new System.Drawing.Point(12, 219);
            this.pboxLocal.Name = "pboxLocal";
            this.pboxLocal.Size = new System.Drawing.Size(80, 60);
            this.pboxLocal.TabIndex = 2;
            this.pboxLocal.TabStop = false;
            // 
            // pboxRemote
            // 
            this.pboxRemote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxRemote.Location = new System.Drawing.Point(12, 39);
            this.pboxRemote.Name = "pboxRemote";
            this.pboxRemote.Size = new System.Drawing.Size(320, 240);
            this.pboxRemote.TabIndex = 3;
            this.pboxRemote.TabStop = false;
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 286);
            this.Controls.Add(this.pboxLocal);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.pboxRemote);
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraForm_FormClosing);
            this.Load += new System.EventHandler(this.CameraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRemote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.PictureBox pboxLocal;
        private System.Windows.Forms.PictureBox pboxRemote;
    }
}