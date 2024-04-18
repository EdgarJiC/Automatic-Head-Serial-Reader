namespace Automatic_Head_Serial_Reader
{
    partial class Main_User_UI
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
            this.TxtMainSerial = new System.Windows.Forms.TextBox();
            this.CMDStop = new System.Windows.Forms.Button();
            this.PctName = new System.Windows.Forms.PictureBox();
            this.PictMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMainSerial
            // 
            this.TxtMainSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TxtMainSerial.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMainSerial.ForeColor = System.Drawing.Color.LightGreen;
            this.TxtMainSerial.Location = new System.Drawing.Point(174, 504);
            this.TxtMainSerial.Name = "TxtMainSerial";
            this.TxtMainSerial.Size = new System.Drawing.Size(189, 47);
            this.TxtMainSerial.TabIndex = 1;
            this.TxtMainSerial.Text = "33FTHS54N6";
            // 
            // CMDStop
            // 
            this.CMDStop.BackColor = System.Drawing.Color.DarkRed;
            this.CMDStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStop.ForeColor = System.Drawing.Color.White;
            this.CMDStop.Location = new System.Drawing.Point(520, 329);
            this.CMDStop.Name = "CMDStop";
            this.CMDStop.Size = new System.Drawing.Size(115, 38);
            this.CMDStop.TabIndex = 3;
            this.CMDStop.Text = "STOP";
            this.CMDStop.UseVisualStyleBackColor = false;
            // 
            // PctName
            // 
            this.PctName.BackColor = System.Drawing.Color.Transparent;
            this.PctName.Image = global::Automatic_Head_Serial_Reader.Properties.Resources.MainTGreenPlay;
            this.PctName.Location = new System.Drawing.Point(520, 179);
            this.PctName.Name = "PctName";
            this.PctName.Size = new System.Drawing.Size(115, 125);
            this.PctName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctName.TabIndex = 2;
            this.PctName.TabStop = false;
            this.PctName.Click += new System.EventHandler(this.PctPlay);
            // 
            // PictMain
            // 
            this.PictMain.BackgroundImage = global::Automatic_Head_Serial_Reader.Properties.Resources.Head_Number_Box;
            this.PictMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictMain.Location = new System.Drawing.Point(25, 26);
            this.PictMain.Name = "PictMain";
            this.PictMain.Size = new System.Drawing.Size(476, 462);
            this.PictMain.TabIndex = 0;
            this.PictMain.TabStop = false;
            this.PictMain.Click += new System.EventHandler(this.PictMain_Click);
            // 
            // Main_User_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(658, 619);
            this.Controls.Add(this.CMDStop);
            this.Controls.Add(this.PctName);
            this.Controls.Add(this.TxtMainSerial);
            this.Controls.Add(this.PictMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_User_UI";
            this.Text = "Automatic Head Serial Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictMain;
        private System.Windows.Forms.TextBox TxtMainSerial;
        private System.Windows.Forms.PictureBox PctName;
        private System.Windows.Forms.Button CMDStop;
    }
}

