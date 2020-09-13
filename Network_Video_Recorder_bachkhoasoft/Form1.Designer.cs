namespace Network_Video_Recorder01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBox_Connect = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.button_CaptureVideo1Stop = new System.Windows.Forms.Button();
            this.TextBox_SaveTo = new System.Windows.Forms.TextBox();
            this.button_SaveTo1 = new System.Windows.Forms.Button();
            this.button_CaptureVideo1Start = new System.Windows.Forms.Button();
            this.GroupBox_Capture = new System.Windows.Forms.GroupBox();
            this.GroupBox_Connect.SuspendLayout();
            this.GroupBox_Capture.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Connect
            // 
            this.GroupBox_Connect.Controls.Add(this.button_Connect);
            this.GroupBox_Connect.Location = new System.Drawing.Point(10, 10);
            this.GroupBox_Connect.Name = "GroupBox_Connect";
            this.GroupBox_Connect.Size = new System.Drawing.Size(110, 60);
            this.GroupBox_Connect.TabIndex = 0;
            this.GroupBox_Connect.TabStop = false;
            this.GroupBox_Connect.Text = "Connect";
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(10, 20);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(90, 25);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(10, 90);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(290, 210);
            this.CameraBox.TabIndex = 3;
            this.CameraBox.TabStop = false;
            this.CameraBox.Text = "Live camera ";
            // 
            // button_CaptureVideo1Stop
            // 
            this.button_CaptureVideo1Stop.Location = new System.Drawing.Point(190, 20);
            this.button_CaptureVideo1Stop.Name = "button_CaptureVideo1Stop";
            this.button_CaptureVideo1Stop.Size = new System.Drawing.Size(90, 25);
            this.button_CaptureVideo1Stop.TabIndex = 36;
            this.button_CaptureVideo1Stop.Text = "Stop capture";
            this.button_CaptureVideo1Stop.UseVisualStyleBackColor = true;
            this.button_CaptureVideo1Stop.Click += new System.EventHandler(this.Button_CaptureVideoStop_Click);
            // 
            // TextBox_SaveTo
            // 
            this.TextBox_SaveTo.Location = new System.Drawing.Point(140, 60);
            this.TextBox_SaveTo.Name = "TextBox_SaveTo";
            this.TextBox_SaveTo.Size = new System.Drawing.Size(140, 20);
            this.TextBox_SaveTo.TabIndex = 35;
            // 
            // button_SaveTo1
            // 
            this.button_SaveTo1.Location = new System.Drawing.Point(10, 60);
            this.button_SaveTo1.Name = "button_SaveTo1";
            this.button_SaveTo1.Size = new System.Drawing.Size(90, 25);
            this.button_SaveTo1.TabIndex = 34;
            this.button_SaveTo1.Text = "Save to:";
            this.button_SaveTo1.UseVisualStyleBackColor = true;
            this.button_SaveTo1.Click += new System.EventHandler(this.Button_SaveTo_Click);
            // 
            // button_CaptureVideo1Start
            // 
            this.button_CaptureVideo1Start.Location = new System.Drawing.Point(10, 20);
            this.button_CaptureVideo1Start.Name = "button_CaptureVideo1Start";
            this.button_CaptureVideo1Start.Size = new System.Drawing.Size(90, 25);
            this.button_CaptureVideo1Start.TabIndex = 33;
            this.button_CaptureVideo1Start.Text = "Start capture";
            this.button_CaptureVideo1Start.UseVisualStyleBackColor = true;
            this.button_CaptureVideo1Start.Click += new System.EventHandler(this.Button_CaptureVideoStart_Click);
            // 
            // GroupBox_Capture
            // 
            this.GroupBox_Capture.Controls.Add(this.TextBox_SaveTo);
            this.GroupBox_Capture.Controls.Add(this.button_CaptureVideo1Stop);
            this.GroupBox_Capture.Controls.Add(this.button_CaptureVideo1Start);
            this.GroupBox_Capture.Controls.Add(this.button_SaveTo1);
            this.GroupBox_Capture.Location = new System.Drawing.Point(10, 300);
            this.GroupBox_Capture.Name = "GroupBox_Capture";
            this.GroupBox_Capture.Size = new System.Drawing.Size(290, 100);
            this.GroupBox_Capture.TabIndex = 0;
            this.GroupBox_Capture.TabStop = false;
            this.GroupBox_Capture.Text = "Capture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 414);
            this.Controls.Add(this.GroupBox_Capture);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.GroupBox_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Video Recorder";
            this.GroupBox_Connect.ResumeLayout(false);
            this.GroupBox_Capture.ResumeLayout(false);
            this.GroupBox_Capture.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GroupBox_Connect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox CameraBox;
        private System.Windows.Forms.Button button_CaptureVideo1Stop;
        private System.Windows.Forms.TextBox TextBox_SaveTo;
        private System.Windows.Forms.Button button_SaveTo1;
        private System.Windows.Forms.Button button_CaptureVideo1Start;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox GroupBox_Capture;
    }
}