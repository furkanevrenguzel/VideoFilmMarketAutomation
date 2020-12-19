using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VideoMarketPortalim
{
    public class Satislar
    {
        Baglantim bl = new Baglantim();
        #region Field
        private int _SatisNo;
        private DateTime _Tarih;
        private int _FilmNo;
        private int _MusteriNo;
        private int _Adet;
        private decimal _BirimFiyat;
        #endregion

        #region Properties
        public int SatisNo
        {
            get { return _SatisNo; }
            set { _SatisNo = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public int FilmNo
        {
            get { return _FilmNo; }
            set { _FilmNo = value; }
        }
        public int MusteriNo
        {
            get { return _MusteriNo; }
            set { _MusteriNo = value; }
        }
        public int Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }
        public decimal BirimFiyat
        {
            get { return _BirimFiyat; }
            set { _BirimFiyat = value; }
        }

        #endregion



        public void SatislariTariheGoreGetir(ListView lsvSatislar, string tarih, TextBox txtToplamAdet, TextBox txtToplamTutar)
        {
            lsvSatislar.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select Satislar.*,Filmler.FilmAd,Musteriler.MusteriAd + ' '+Musteriler.MusteriSoyad as Musteri from Satislar inner join Musteriler on Satislar.MusteriNo=Musteriler.MusteriNo inner join Filmler on Satislar.FilmNo=Filmler.FilmNo where Convert(varchar(20),Satislar.Tarih,104)=@Tarih", cnn);
            cmd.Parameters.AddWithValue("@Tarih", tarih);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader rdr;
            int ToplamAdet = 0;
            decimal ToplamTutar = 0;
            try
            {
                rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lsvSatislar.Items.Add(Convert.ToInt32(rdr["SatisNo"]).ToString());
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToDateTime(rdr["Tarih"]).ToShortDateString());
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToString(rdr["Musteri"]));
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToString(rdr["FilmAd"]));
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToInt32(rdr["Adet"]).ToString());
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToDecimal(rdr["BirimFiyat"]).ToString());
                    lsvSatislar.Items[i].SubItems.Add((Convert.ToInt32(rdr["Adet"]) * Convert.ToDecimal(rdr["BirimFiyat"])).ToString());
                    ToplamAdet += Convert.ToInt32(rdr["Adet"]);
                    ToplamTutar += Convert.ToInt32(rdr["Adet"]) * Convert.ToDecimal(rdr["BirimFiyat"]);
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());
                    lsvSatislar.Items[i].SubItems.Add(Convert.ToInt32(rdr["MusteriNo"]).ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            txtToplamAdet.Text = ToplamAdet.ToString();
            txtToplamTutar.Text = ToplamTutar.ToString();
        }

        public bool SatisEkle(Satislar s)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Insert Into Satislar(Tarih,FilmNo,MusteriNo,Adet,BirimFiyat) values(@Tarih,@FilmNo,@MusteriNo,@Adet,@BirimFiyat)", cnn);
            cmd.Parameters.AddWithValue("@Tarih", s.Tarih);
            cmd.Parameters.AddWithValue("@FilmNo", s.FilmNo);
            cmd.Parameters.AddWithValue("@MusteriNo", s.MusteriNo);
            cmd.Parameters.AddWithValue("@Adet", s.Adet);
            cmd.Parameters.AddWithValue("@BirimFiyat", s.BirimFiyat);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return sonuc;
        }

            public bool SatisDegistir(Satislar s)
            {
                bool sonuc = false;
                SqlConnection cnn = new SqlConnection(bl.Cnnstring);
                SqlCommand cmd = new SqlCommand("Update Satislar set Tarih=@Tarih,FilmNo=@FilmNo,MusteriNo=@MusteriNo,Adet=@Adet,BirimFiyat=@BirimFiyat where SatisNo=@SatisNo",cnn);
                cmd.Parameters.AddWithValue("@Tarih", s.Tarih);
                cmd.Parameters.AddWithValue("@FilmNo", s.FilmNo);
                cmd.Parameters.AddWithValue("@MusteriNo", s.MusteriNo);
                cmd.Parameters.AddWithValue("@Adet", s.Adet);
                cmd.Parameters.AddWithValue("@BirimFiyat", s.BirimFiyat);
                cmd.Parameters.AddWithValue("@SatisNo", s.SatisNo);
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
                catch (SqlException ex)
                {
                    
                    string hata = ex.Message;
                }
                finally
                {
                    cnn.Close();
                }
                return sonuc;
            }

            public bool SatisSil(int satisno)
            {
                bool sonuc = false;
                SqlConnection cnn = new SqlConnection(bl.Cnnstring);
                SqlCommand cmd = new SqlCommand("Delete from Satislar where SatisNo=@SatisNo",cnn);
                cmd.Parameters.AddWithValue("@SatisNo", satisno);
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
                catch (SqlException ex)
                {
                    
                    string hata = ex.Message;
                }
                finally
                {
                    cnn.Close();
                }
                return sonuc;
            }

            public DataSet SatislariGetirbyTarih(DateTimePicker dtpilk, DateTimePicker dtpSon)
            {
                DataSet ds = new DataSet();
                SqlConnection cnn = new SqlConnection(bl.Cnnstring);
                SqlDataAdapter adp = new SqlDataAdapter("select Satislar.SatisNo,Tarih,Filmler.FilmAd,Musteriler.MusteriAd+ ' ' +Musteriler.MusteriSoyad as Musteri,Adet,BirimFiyat, Adet*BirimFiyat as Tutar,Satislar.FilmNo,Satislar.MusteriNo from Satislar inner join Musteriler on Satislar.MusteriNo=Musteriler.MusteriNo inner join Filmler on Satislar.FilmNo=Filmler.FilmNo where Convert(varchar(20),Satislar.Tarih,104) between @Tarih1 and @Tarih2",cnn);
                adp.SelectCommand.Parameters.AddWithValue("@Tarih1",dtpilk.Value.ToShortDateString());
                adp.SelectCommand.Parameters.AddWithValue("@Tarih2",dtpSon.Value.ToShortDateString());
                try
                {
                    adp.Fill(ds, "Satislar");
                }
                catch (SqlException ex)
                {

                    string hata = ex.Message;
                }
                return ds;
            }
    }
}
