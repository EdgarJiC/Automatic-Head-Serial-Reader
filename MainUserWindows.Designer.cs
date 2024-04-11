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
            this.PictMain = new System.Windows.Forms.PictureBox();
            this.TxtMainSerial = new System.Windows.Forms.TextBox();
            this.CMDRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PictMain
            // 
            this.PictMain.BackgroundImage = global::Automatic_Head_Serial_Reader.Properties.Resources.Head_Number_Box;
            this.PictMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictMain.Location = new System.Drawing.Point(55, 80);
            this.PictMain.Name = "PictMain";
            this.PictMain.Size = new System.Drawing.Size(436, 420);
            this.PictMain.TabIndex = 0;
            this.PictMain.TabStop = false;
            this.PictMain.Click += new System.EventHandler(this.PictMain_Click);
            // 
            // TxtMainSerial
            // 
            this.TxtMainSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TxtMainSerial.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMainSerial.ForeColor = System.Drawing.Color.LightGreen;
            this.TxtMainSerial.Location = new System.Drawing.Point(182, 516);
            this.TxtMainSerial.Name = "TxtMainSerial";
            this.TxtMainSerial.Size = new System.Drawing.Size(180, 47);
            this.TxtMainSerial.TabIndex = 1;
            this.TxtMainSerial.Text = "33FTHS54N6";
            // 
            // CMDRun
            // 
            this.CMDRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDRun.Location = new System.Drawing.Point(613, 101);
            this.CMDRun.Name = "CMDRun";
            this.CMDRun.Size = new System.Drawing.Size(117, 48);
            this.CMDRun.TabIndex = 2;
            this.CMDRun.Text = "STOP";
            this.CMDRun.UseVisualStyleBackColor = true;
            // 
            // Main_User_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(831, 684);
            this.Controls.Add(this.CMDRun);
            this.Controls.Add(this.TxtMainSerial);
            this.Controls.Add(this.PictMain);
            this.Name = "Main_User_UI";
            this.Text = "Automatic Head Serial Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictMain;
        private System.Windows.Forms.TextBox TxtMainSerial;
        private System.Windows.Forms.Button CMDRun;
    }
}

