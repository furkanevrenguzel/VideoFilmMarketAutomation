using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarketPortalim
{
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }

        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Musteriler m = new Musteriler();
            m.MusteriGetir(lsvMusteri);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = true;
            btnKaydet.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtMusteriNo.Text = "";
            txtAdres.Clear();
            txtMusteriAdi.Clear();
            txtMusteriSoyAdi.Clear();
            txtTelefon.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMusteriAdi.Text == "" || txtMusteriSoyAdi.Text == "" || txtTelefon.Text == "" || txtAdres.Text == "")
                {
                    MessageBox.Show("Müşteri Adı,Soyadı,Telefon ve Adres alanları boş geçilmez!", "Bu alanlar boş geçilemez.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Musteriler m = new Musteriler();
                    m.MusteriAd = Kontrol.Temizle(txtMusteriAdi.Text);
                    m.MusteriSoyad = Kontrol.Temizle(txtMusteriSoyAdi.Text);
                    m.Telefon = Kontrol.Temizle(txtTelefon.Text);
                    m.Adres = Kontrol.Temizle(txtAdres.Text);

                    bool sonuc = m.MusteriEkle(m);
                    if (sonuc)
                    {
                        MessageBox.Show("Müşteri ekleme işlemi başarıyla gerçekleştirildi.");
                        m.MusteriGetir(lsvMusteri);
                        btnKaydet.Enabled = true;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri eklenemedi.");
                    }

                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

    

        private void lsvMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMusteri.SelectedItems.Count > 0)
            {
                txtMusteriNo.Text = lsvMusteri.SelectedItems[0].SubItems[0].Text;
                txtMusteriAdi.Text = lsvMusteri.SelectedItems[0].SubItems[1].Text;
                txtMusteriSoyAdi.Text = lsvMusteri.SelectedItems[0].SubItems[2].Text;
                txtTelefon.Text = lsvMusteri.SelectedItems[0].SubItems[3].Text;
                txtAdres.Text = lsvMusteri.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdi.Text == "" || txtMusteriSoyAdi.Text == "")
            {
                MessageBox.Show("Müşteri Adı ve Soyadı boş geçilemez!", "Dikkat eksik bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Musteriler m = new Musteriler();
                m.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                m.MusteriAd = txtMusteriAdi.Text;
                m.MusteriSoyad = txtMusteriSoyAdi.Text;
                m.Telefon = txtTelefon.Text;
                m.Adres = txtAdres.Text;

                bool sonuc = m.MusteriGuncelle(m);
                if (sonuc)
                {
                    MessageBox.Show("Müşteri güncellendi.");
                    m.MusteriGetir(lsvMusteri);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri güncellenmedi.");
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtMusteriAdi + "adlı müşteriyi silmek istediğinizden emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Musteriler m = new Musteriler();
                bool sonuc = m.MusteriSil(Convert.ToInt32(txtMusteriNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Müşteri başarı ile silindi.");
                    m.MusteriGetir(lsvMusteri);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    btnDegistir.Enabled = true; ;
                    btnSil.Enabled = true;
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi.");
                }
            }
            else
            {
                MessageBox.Show("Müşteri silme işleminden vazgeçildi.");
            }
        }

     
       
        private void txtMusteriAdi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMusteriSoyAdi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void lsvMusteri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Baglantim.M_No = Convert.ToInt32(lsvMusteri.SelectedItems[0].SubItems[0].Text);
            Baglantim.M_Adi = lsvMusteri.SelectedItems[0].SubItems[1].Text;
            Baglantim.M_SoyAdi = lsvMusteri.SelectedItems[0].SubItems[2].Text;
            //this.Close();//
        }
    }
}
