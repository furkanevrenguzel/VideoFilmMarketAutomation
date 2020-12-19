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
    public partial class FrmFilmTurleri : Form
    {
        public FrmFilmTurleri()
        {
            InitializeComponent();
        }

        private void FrmFilmTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            FilmTurler ft = new FilmTurler();
            ft.FilmTurleriGetirLst(lsvFilmTur);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = true;
            btnKaydet.Enabled = true;
            Temizle();

        }

        private void Temizle()
        {
            txtFilmTurNo.Clear();
            txtAciklama.Clear();
            txtTurAd.Clear();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" || txtTurAd.Text == "")
            {
                MessageBox.Show("Film Tür Açıklama ve Film Tür Adı boş geçilemez!", "Dikkat eksik bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                FilmTurler ft = new FilmTurler();
                bool sonuc = ft.FilmTurKaydet(txtTurAd.Text, txtAciklama.Text);
                if (sonuc)
                {
                    MessageBox.Show("Film Türü başarı ile eklendi!");
                    ft.FilmTurleriGetirLst(lsvFilmTur);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    Temizle();
                }

                else
                {
                    MessageBox.Show("Film eklenmedi.");
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmTurNo.Text == "")
            {
                MessageBox.Show("Film Türü bilgilerinizi eksik bırakmayınız.", "Dikkat eksik bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FilmTurler ft = new FilmTurler();
                bool sonuc = ft.FilmTurGuncelle(txtTurAd.Text, txtAciklama.Text, Convert.ToInt32(txtFilmTurNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Film Tür güncellendi.");
                    ft.FilmTurleriGetirLst(lsvFilmTur);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    Temizle();
                }

                else
                {
                    MessageBox.Show("Film Tür güncelleme işlemi yapılmadı.");
                }
            }
        }

        private void lsvFilmTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvFilmTur.SelectedItems.Count > 0)
            {
                txtFilmTurNo.Text = lsvFilmTur.SelectedItems[0].SubItems[0].Text;
                txtTurAd.Text = lsvFilmTur.SelectedItems[0].SubItems[1].Text;
                txtAciklama.Text = lsvFilmTur.SelectedItems[0].SubItems[2].Text;

                btnKaydet.Enabled = true;
                btnDegistir.Enabled = true;
                btnSil.Enabled = true;
                txtTurAd.Focus();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtFilmTurNo.Text != "")
            {
                if (MessageBox.Show(txtTurAd.Text + "Film Türünü silmek istediğinizden emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FilmTurler ft = new FilmTurler();
                    bool sonuc = ft.FilmTurSil(Convert.ToInt32(txtFilmTurNo.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Film Tür başarı ile silindi.");
                        ft.FilmTurleriGetirLst(lsvFilmTur);
                        btnKaydet.Enabled = true;
                        btnYeni.Enabled = true;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;
                        Temizle();
                    }

                    else
                    {
                        MessageBox.Show("Film Tür silinemedi.");
                    }

                }
                else
                {
                    MessageBox.Show("Film Tür silme işleminden vazgeçildi.");
                }
                
            }
            else
            {
                MessageBox.Show("Film Tür silebilmek için listeden bir film seçiniz.");
            }
        }

        private void txtTurAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
