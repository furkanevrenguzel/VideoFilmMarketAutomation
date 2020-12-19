using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace VideoMarketPortalim
{
    public partial class FrmFilmTanimlamaEkrani : Form
    {
        public FrmFilmTanimlamaEkrani()
        {
            InitializeComponent();
        }
        Baglantim bl = new Baglantim();
        SqlConnection cnn = new SqlConnection();
        string resimPath;
        private void FrmFilmTanimlamaEkrani_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Filmler fl = new Filmler();
            fl.FilmGetir(lsvFilmler);

            FilmTurler ft = new FilmTurler();
            ft.FilmTurleriGetir(cmbTurler);
        }


        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTurler ft = (FilmTurler)cmbTurler.SelectedItem;
            txtFilmTuru.Text = ft.TurAd;
            txtTurNo.Text = Convert.ToString(ft.FilmTurNo);
            txtYonetmen.Focus();

        }
        private void cmbTurler_Leave(object sender, EventArgs e)
        {
            cmbTurler.Width = 21;
        }

        private void cmbTurler_Enter(object sender, EventArgs e)
        {
            cmbTurler.Width = 120;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = true;
            btnKaydet.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtFilmTuru.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtStokMiktari.Text = "";
            pictureBox1.Image = null;
            txtFilmAdi.Focus();
           


        }
        byte[] resim;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilmAdi.Text == "" || txtTurNo.Text == "" || txtYonetmen.Text == "" || txtOyuncular.Text == "" || txtOzet.Text == "" || txtStokMiktari.Text == "")
                {
                    
                        MessageBox.Show("Film Adı, Film Türü,Yönetmeni,Oyuncuları,Film Özeti, Stok Miktarı  alanları boş geçilmez!", "Bu alanlar boş geçilemez.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }

                else
                {
                   
                    Filmler f = new Filmler();
                    bool sonuc = f.FilmKontrol(txtFilmAdi.Text);
                    
                    Image img=pictureBox1.Image;
                    ImageConverter converter = new ImageConverter();
                    resim=(byte[])converter.ConvertTo(img, typeof(byte[]));
                    SqlConnection cnn = new SqlConnection(bl.Cnnstring);
                    SqlCommand cmd = new SqlCommand("insert into Filmler(Resim) Values (@Resim) ", cnn);
                    cmd.Parameters.Add("@Resim", SqlDbType.Image, resim.Length).Value = resim;
                    
                    if (sonuc)
                    {    
                        MessageBox.Show("Uyarı!Bu film daha önceden eklenmiş.");
                    }
                    else
                    {
                        bool stokvarmi = false;
                        if (Convert.ToInt32(txtStokMiktari.Text) <0 )
                        {
                            MessageBox.Show("Film Miktarı 0'dan küçük olamaz!");
                            txtStokMiktari.Text = "";
                        }
                        
                        sonuc = f.FilmEkle(Kontrol.Temizle(txtFilmAdi.Text),
                            Convert.ToInt32(Kontrol.Temizle(txtTurNo.Text)),
                            Kontrol.Temizle(txtYonetmen.Text),
                            Kontrol.Temizle(txtOyuncular.Text),
                            Kontrol.Temizle(txtOzet.Text),
                            Convert.ToInt32(Kontrol.Temizle(txtStokMiktari.Text)),
                            stokvarmi, resim);
                            
                        if (sonuc)
                        {
                            MessageBox.Show("Film ekleme işlemi başarıyla gerçekleşti.");
                            f.FilmGetir(lsvFilmler);
                            btnKaydet.Enabled = false;
                            btnYeni.Enabled = true;
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Film ekleme işleri sırasında hata ile karşılaşıldı.");

                        }
              
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        private void lsvFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvFilmler.SelectedItems.Count > 0)
                 { 
                    SqlConnection cnn = new SqlConnection(bl.Cnnstring);
                    cnn.Open();
                    MemoryStream stream = new MemoryStream();
                    SqlCommand cmd = new SqlCommand("select Resim from Filmler where FilmNo=@FilmNo", cnn);
                    cmd.Connection = cnn;
                    int a = Convert.ToInt32(lsvFilmler.SelectedItems[0].Text);
                    cmd.Parameters.AddWithValue("@FilmNo",a);
                    byte[] image = (byte[])cmd.ExecuteScalar();
                    stream.Write(image, 0, image.Length);
                    Bitmap bitmap = new Bitmap(stream);
                    pictureBox1.Image = bitmap;
                    Filmler f = new Filmler();

                txtFilmNo.Text = lsvFilmler.SelectedItems[0].SubItems[0].Text;
                txtFilmAdi.Text = lsvFilmler.SelectedItems[0].SubItems[1].Text;
                txtTurNo.Text = lsvFilmler.SelectedItems[0].SubItems[2].Text;
                txtFilmTuru.Text = lsvFilmler.SelectedItems[0].SubItems[3].Text;
                txtYonetmen.Text = lsvFilmler.SelectedItems[0].SubItems[4].Text;
                txtOyuncular.Text = lsvFilmler.SelectedItems[0].SubItems[5].Text;
                txtOzet.Text = lsvFilmler.SelectedItems[0].SubItems[6].Text;
                txtStokMiktari.Text = lsvFilmler.SelectedItems[0].SubItems[7].Text;

                btnKaydet.Enabled = true;
                btnDegistir.Enabled = true;
                btnSil.Enabled = true;
                txtFilmAdi.Focus();
                cnn.Close();
                
            }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text == "" || txtTurNo.Text == "" || txtYonetmen.Text == "" || txtOyuncular.Text == "" || txtOzet.Text == "" || txtStokMiktari.Text == "")
            {
                
                    MessageBox.Show("Film Adı, Film Türü,Yönetmeni,Oyuncuları,Film Özeti, Stok Miktarı alanları boş geçilmez!", "Bu alanlar boş geçilemez.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                
                Filmler f = new Filmler();
                bool sonuc = f.FilmGuncelle(Convert.ToInt32(Kontrol.Temizle(txtFilmNo.Text)),
                            Kontrol.Temizle(txtFilmAdi.Text),
                            Convert.ToInt32(Kontrol.Temizle(txtTurNo.Text)),
                            Kontrol.Temizle(txtYonetmen.Text),
                            Kontrol.Temizle(txtOyuncular.Text),
                            Kontrol.Temizle(txtOzet.Text),
                            Convert.ToInt32(Kontrol.Temizle(txtStokMiktari.Text)));
                         
                            
                if (sonuc)
                {
                    MessageBox.Show("Film bilgileri güncellendi.");
                    f.FilmGetir(lsvFilmler);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    Temizle();
                }

                else
                {
                    
                    if (Convert.ToInt32(txtStokMiktari.Text) < 0)
                    {
                        MessageBox.Show("Film Miktarı 0'dan küçük olamaz!");
                        txtStokMiktari.Text = "";
                    }
                        
                    MessageBox.Show("Film güncelleme işlemleri sırasında hata ile karşılaşıldı.");
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtFilmAdi.Text + " adlı" + "Film silinsin mi?", "Filmi silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Filmler f = new Filmler();
                bool sonuc = f.FilmSil(Convert.ToInt32(Kontrol.Temizle(txtFilmNo.Text)));
                if (sonuc)
                {
                    MessageBox.Show("Film başarı ile silindi.");
                    f.FilmGetir(lsvFilmler);
                    btnKaydet.Enabled = true;
                    btnYeni.Enabled = true;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Film silinemedi.");
                }
            }
            else
            {
                MessageBox.Show("Film silme işleminden vazgeçildi.");
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {  
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }
       
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
                   
        }

        private void txtFilmTuru_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtYonetmen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOyuncular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStokMiktari_KeyPress(object sender, KeyPressEventArgs e)
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
        private void lsvFilmler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Baglantim.F_No = Convert.ToInt32(lsvFilmler.SelectedItems[0].SubItems[0].Text);
            Baglantim.F_Adi = lsvFilmler.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }
        private void txtFilmAdi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtOyuncular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStokMiktari_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void txtYonetmen_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void txtOzet_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
