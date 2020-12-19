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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnCikis_Click(object sender, EventArgs e)
        {
            DialogResult ext;
            ext = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Çıkış Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ext == DialogResult.Yes)
            {
                Application.Exit();

            } 
        }

        public void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            
            }

            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }


        }

        private void mnItemFilmTanimlama_Click(object sender, EventArgs e)
        {
            FrmFilmTanimlamaEkrani frm = new FrmFilmTanimlamaEkrani();
            frm.Show();
        }

        private void mnItemFilmSorgulama_Click(object sender, EventArgs e)
        {
            FrmFilmSorgula frm = new FrmFilmSorgula();
            FormAcikmi(frm);
        }

        private void mnItemFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            FrmFilmTurleri frm = new FrmFilmTurleri();
            FormAcikmi(frm);
        }

        private void mnItemMusteriKarti_Click(object sender, EventArgs e)
        {
            FrmMusteriIslemleri frm = new FrmMusteriIslemleri();
            FormAcikmi(frm);
        }

        private void mnItemMusteriSorgulama_Click(object sender, EventArgs e)
        {
            FrmMusteriSorgulama frm = new FrmMusteriSorgulama();
            FormAcikmi(frm);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void mnItemFilmSatisIslemleri_Click(object sender, EventArgs e)
        {
            FrmFilmSatisIslemleri frm = new FrmFilmSatisIslemleri();
            FormAcikmi(frm);
        }

        private void mnItemSatisSorgulama_Click(object sender, EventArgs e)
        {
            FrmSatisTarihleri frm = new FrmSatisTarihleri();
            FormAcikmi(frm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void lnkBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkBilgi.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com.tr/");
        }

        private void mnMusteriler_Click(object sender, EventArgs e)
        {

        }
    }
}
