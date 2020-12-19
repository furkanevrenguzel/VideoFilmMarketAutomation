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
    public class Musteriler
    {
        Baglantim bl = new Baglantim();
        #region Fields
        private int _MusteriNo;
        private string _MusteriAd;
        private string _MusteriSoyad;
        private string _Telefon;
        private string _Adres; 
        #endregion

        #region Properties
        public int MusteriNo
        {
            get { return _MusteriNo; }
            set { _MusteriNo = value; }
        }
        public string MusteriAd
        {
            get { return _MusteriAd; }
            set { _MusteriAd = value; }
        }
        public string MusteriSoyad
        {
            get { return _MusteriSoyad; }
            set { _MusteriSoyad = value; }
        }
        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }
        public string Adres
        {
            get { return _Adres; }
            set { _Adres = value; }
        }
        
        #endregion

        public void MusteriGetir(ListView lsvMusteri)
        {
            lsvMusteri.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Musteriler",cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lsvMusteri.Items.Add(Convert.ToInt32(rdr["MusteriNo"]).ToString());
                    lsvMusteri.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriAd"]));
                    lsvMusteri.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriSoyad"]));
                    lsvMusteri.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lsvMusteri.Items[i].SubItems.Add(Convert.ToString(rdr["Adres"]));
                    i++;

                }
                rdr.Close();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        public bool MusteriEkle(Musteriler m)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Insert Into Musteriler(MusteriAd,MusteriSoyad,Telefon,Adres) values(@MusteriAd,@MusteriSoyad,@Telefon,@Adres)",cnn);
            cmd.Parameters.AddWithValue("@MusteriAd",m.MusteriAd);
            cmd.Parameters.AddWithValue("@MusteriSoyad",m._MusteriSoyad);
            cmd.Parameters.AddWithValue("@Telefon",m.Telefon);
            cmd.Parameters.AddWithValue("@Adres",m.Adres);
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

        public bool MusteriGuncelle(Musteriler m)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Update Musteriler set MusteriAd=@MusteriAd,MusteriSoyad=@MusteriSoyad,Telefon=@Telefon,Adres=@Adres where MusteriNo=@MusteriNo",cnn);
            cmd.Parameters.AddWithValue("@MusteriAd",m.MusteriAd);
            cmd.Parameters.AddWithValue("@MusteriSoyad",m.MusteriSoyad);
            cmd.Parameters.AddWithValue("@Telefon",m.Telefon);
            cmd.Parameters.AddWithValue("@Adres",m.Adres);
            cmd.Parameters.AddWithValue("@MusteriNo",m.MusteriNo);
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

        public bool MusteriSil(int musteriNo)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Delete From Musteriler where MusteriNo=@MusteriNo", cnn);
        
            cmd.Parameters.AddWithValue("@MusteriNo",musteriNo);
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

        public void MusteriAdaGoreGetir(ListView lsvMusteriler, string ad)
        {
            lsvMusteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Musteriler Where MusteriAd like '%'+@MusteriAd+'%'",cnn);
            cmd.Parameters.AddWithValue("@MusteriAd",ad);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lsvMusteriler.Items.Add(Convert.ToInt32(rdr["MusteriNo"]).ToString());
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriAd"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriSoyad"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["Adres"]));
                    i++;
                }
                rdr.Close();
               
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        public void MusteriSoyadaGoreGetir(ListView lsvMusteriler, string soyad)
        {
            lsvMusteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Musteriler Where MusteriSoyad like '%'+@MusteriSoyAdAd+'%'", cnn);
            cmd.Parameters.AddWithValue("@MusteriSoyAdAd", soyad);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {

                    lsvMusteriler.Items.Add(Convert.ToInt32(rdr["MusteriNo"]).ToString());
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriAd"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["MusteriSoyad"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lsvMusteriler.Items[i].SubItems.Add(Convert.ToString(rdr["Adres"]));
                    i++;

                }
                rdr.Close();
                
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
