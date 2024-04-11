using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Head_Serial_Reader
{
    public partial class Main_User_UI : Form
    {
        public Main_User_UI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Automatic Head Serial Reader";
            this.Size = new System.Drawing.Size(565,725);
            BackColor = Color.FromArgb(51,51,51);

        }

        private void PictMain_Click(object sender, EventArgs e)
        {

        }
    }
}
