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
    public partial class FrmFilmSatisIslemleri : Form
    {
        public FrmFilmSatisIslemleri()
        {
            InitializeComponent();
        }
        int orjmiktar = 0;

        private void FrmFilmSatisIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();//seçtiğim tarihin textboxa gelmesi için//

        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            Satislar s = new Satislar();
            s.SatislariTariheGoreGetir(lsvSatislar,txtTarih.Text,txtToplamAdet,txtToplamTutar);

        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            FrmMusteriIslemleri frm = new FrmMusteriIslemleri();
            frm.ShowDialog();
            txtMusteriNo.Text = Baglantim.M_No.ToString();
            txtMusteriAra.Text=Baglantim.M_Adi+""+Baglantim.M_SoyAdi;

        }

        private void btnFilmAra_Click(object sender, EventArgs e)
        {
            FrmFilmTanimlamaEkrani frm = new FrmFilmTanimlamaEkrani();
            frm.ShowDialog();
            txtFilmNo.Text = Baglantim.F_No.ToString();
            txtFilmAra.Text = Baglantim.F_Adi;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnKaydet.Enabled=true;

        }

        private void Temizle()
        {
 	        txtAdet.Text="";
            txtFiyat.Text="";
            txtAdet.Focus();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if(txtAdet.Text=="")
            {
                txtAdet.Text="0";
            }
            if(txtFiyat.Text=="")
            {
                txtFiyat.Text="0";
            }

            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            txtAdet_TextChanged(sender, e);//eden geleni burdaki fiyatın text changed olduğunda bunu hesaplanıp gelmesini istedik//
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text == "" || txtFilmNo.Text == "" || txtAdet.Text == "" ||txtFiyat.Text == "")
            {
                MessageBox.Show("Müşteri ve Film bilgileri seçilmelidir!", "Dikkat eksik bilgi!");
            }
            else
            {
                Filmler f = new Filmler();
                int StokMiktari = f.StogaGoreFilmGetir(Convert.ToInt32(txtFilmNo.Text));
                if (StokMiktari >= Convert.ToInt32(txtAdet.Text))
                {
                    Satislar s = new Satislar();
                    s.Tarih = Convert.ToDateTime(txtTarih.Text);
                    s.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    s.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    s.Adet = Convert.ToInt32(txtAdet.Text);
                    s.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
                    s.SatisEkle(s);
                    s.SatislariTariheGoreGetir(lsvSatislar, txtTarih.Text, txtToplamAdet, txtToplamTutar);
                    f.StokMiktariniGuncelle(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text));
                    Temizle();
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
                }
                else
                {
                    MessageBox.Show("Stok seviyesi yetersiz, mevcut stok miktarı:"+StokMiktari.ToString());
                }
            }
        }
        
        private void lsvSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSatisNo.Text = lsvSatislar.SelectedItems[0].SubItems[0].Text;
            txtMusteriNo.Text = lsvSatislar.SelectedItems[0].SubItems[8].Text;
            txtFilmNo.Text = lsvSatislar.SelectedItems[0].SubItems[7].Text;
            txtFilmAra.Text = lsvSatislar.SelectedItems[0].SubItems[3].Text;
            txtMusteriAra.Text = lsvSatislar.SelectedItems[0].SubItems[2].Text;
            txtAdet.Text = lsvSatislar.SelectedItems[0].SubItems[4].Text;
            txtFiyat.Text = lsvSatislar.SelectedItems[0].SubItems[5].Text;
            txtTarih.Text = lsvSatislar.SelectedItems[0].SubItems[1].Text;
            orjmiktar = Convert.ToInt32(lsvSatislar.SelectedItems[0].SubItems[4].Text);
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text == "" || txtFilmNo.Text == "" || txtAdet.Text == "" ||txtFiyat.Text == "")
            {
                MessageBox.Show("Müşteri ve Film bilgileri boş bırakılamaz!", "Dikkat eksik bilgi!");
            }
            else
            {
                Filmler f = new Filmler();
                int stokmiktari = f.StogaGoreFilmGetir(Convert.ToInt32(txtFilmNo.Text));
                if (stokmiktari+orjmiktar>=Convert.ToInt32(txtAdet.Text))
                {
                    Satislar s = new Satislar();
                    s.SatisNo = Convert.ToInt32(txtSatisNo.Text);
                    s.Tarih = Convert.ToDateTime(txtTarih.Text);
                    s.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    s.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    s.Adet = Convert.ToInt32(txtAdet.Text);
                    s.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
                    s.SatisDegistir(s);
                    s.SatislariTariheGoreGetir(lsvSatislar, txtTarih.Text, txtToplamAdet, txtToplamTutar);
                    f.StokMiktariGuncelleFromDegistir(Convert.ToInt32(txtFilmNo.Text),Convert.ToInt32(txtAdet.Text),orjmiktar);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Stok seviyesi yetersiz, mevcut stok:"+stokmiktari);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu satışı silmek istediğinizden emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Filmler f = new Filmler();
                Satislar s = new Satislar();
                bool okmu =s.SatisSil(Convert.ToInt32(txtSatisNo.Text));
                if (okmu)
                {
                    s.SatislariTariheGoreGetir(lsvSatislar, txtTarih.Text, txtToplamAdet, txtToplamTutar);
                    f.FilmStokMiktariniSilerekGuncelle(Convert.ToInt32(txtFilmNo.Text),orjmiktar);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme işlemleri sırasında hata ile karşılaşıldı.");
                }
            }
            else
            {
                MessageBox.Show("Satış silme işleminden vazgeçildi.");
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
