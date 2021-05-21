using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeleteFirstFewLine
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.qiandao8.com/soft/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void label6_Click(object sender, EventArgs e)
        {
               
        }
    }
}
