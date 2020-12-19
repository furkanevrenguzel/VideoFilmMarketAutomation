using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarketPortalim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkBilgi.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com.tr/");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            //FrmGiris frm=new FrmGiris();
            frm.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
