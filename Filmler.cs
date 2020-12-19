using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace VideoMarketPortalim
{
    public class Filmler
    {
        Baglantim bl = new Baglantim();
        #region Fields
        private int _FilmNo;
        private string _FilmAd;
        private int _FilmTurNo;
        private string _Yonetmen;
        private string _Oyuncular;
        private string _Ozet;
        private int _Miktar;
        private bool _VarMi; 
        #endregion


        #region Properties
        public int FilmNo
        {
            get { return _FilmNo; }
            set { _FilmNo = value; }
        }
        public string FilmAd
        {
            get { return _FilmAd; }
            set { _FilmAd = value; }
        }
        public int FilmTurNo
        {
            get { return _FilmTurNo; }
            set { _FilmTurNo = value; }
        }
        public string Yonetmen
        {
            get { return _Yonetmen; }
            set { _Yonetmen = value; }
        }
        public string Oyuncular
        {
            get { return _Oyuncular; }
            set { _Oyuncular = value; }
        }
        public string Ozet
        {
            get { return _Ozet; }
            set { _Ozet = value; }
        }
        public int Miktar
        {
            get { return _Miktar; }
            set { _Miktar = value; }
        }
        public bool VarMi
        {
            get { return _VarMi; }
            set { _VarMi = value; }
        } 
        #endregion


        public void FilmGetir(ListView lsvFilmler)
        {
            lsvFilmler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd=new SqlCommand("Select * from Filmler inner join FilmTurler on Filmler.FilmTurNo=FilmTurler.FilmTurNo",cnn);
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
                    lsvFilmler.Items.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(rdr["FilmAd"].ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Yonetmen"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Oyuncular"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Ozet"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["Miktar"]).ToString());

                   
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

        }

        public bool FilmKontrol(string FilmAdi)
        {
            bool sonuc=false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select FilmAd from Filmler where FilmAd=@FilmAd", cnn);
            cmd.Parameters.AddWithValue("@FilmAd", FilmAdi);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sonuc = true;
                }
                rdr.Dispose();
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

        public bool FilmEkle(string FilmAdi,int TurNo,string Yonetmen,string Oyuncular,string Ozet,int Miktar,bool stoktavarmi,byte[] Resim)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Insert Into Filmler (FilmAd,FilmTurNo,Yonetmen,Oyuncular,Ozet,Miktar,Resim) values (@FilmAd,@FilmTurNo,@Yonetmen,@Oyuncular,@Ozet,@Miktar,@Resim)",cnn);
            cmd.Parameters.AddWithValue("@FilmAd",FilmAdi);
            cmd.Parameters.AddWithValue("@FilmTurNo",TurNo);
            cmd.Parameters.AddWithValue("@Yonetmen",Yonetmen);
            cmd.Parameters.AddWithValue("@Oyuncular",Oyuncular);
            cmd.Parameters.AddWithValue("@Ozet",Ozet);
            cmd.Parameters.AddWithValue("@Miktar",Miktar);
           
            cmd.Parameters.AddWithValue("@Resim",Resim);

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

        public bool FilmGuncelle(int FilmNo, string FilmAdi, int TurNo, string Yonetmen, string Oyuncular, string Ozet, int Miktar)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Update Filmler set FilmAd=@FilmAdi,FilmTurNo=@TurNo,Yonetmen=@Yonetmen,Oyuncular=@Oyuncular,Ozet=@Ozet,Miktar=@Miktar where FilmNo=@FilmNo", cnn);
            cmd.Parameters.AddWithValue("@FilmNo", FilmNo);
            cmd.Parameters.AddWithValue("@FilmAdi", FilmAdi);
            cmd.Parameters.AddWithValue("@TurNo", TurNo);
            cmd.Parameters.AddWithValue("@Yonetmen", Yonetmen);
            cmd.Parameters.AddWithValue("@Oyuncular", Oyuncular);
            cmd.Parameters.AddWithValue("@Ozet", Ozet);
            cmd.Parameters.AddWithValue("@Miktar", Miktar);
            
          
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

        public bool FilmSil(int FilmNo)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Delete From Filmler where FilmNo=@FilmNo",cnn);
            cmd.Parameters.AddWithValue("@FilmNo", FilmNo);
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

        public void FilmTurlerineGoreGetir(ListView lsvFilmler, int TurNo)
        {
            lsvFilmler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("select * from Filmler inner join FilmTurler on Filmler.FilmTurNo=FilmTurler.FilmTurNo where Filmler.FilmTurNo=@FilmTurNo",cnn);
            cmd.Parameters.AddWithValue("@FilmTurNo",TurNo);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while(rdr.Read())
                {
                    lsvFilmler.Items.Add(Convert.ToString(rdr["FilmAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Yonetmen"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Oyuncular"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Ozet"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["Miktar"]).ToString());
                   
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());

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

        public void FilmleriGosterByAdinaGore(ListView lsvFilmler, string FilmAd)
        {
            lsvFilmler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Filmler inner join FilmTurler on Filmler.FilmTurNo=FilmTurler.FilmTurNo where Filmler.FilmAd like '%'+@FilmAdi+'%'", cnn);
            cmd.Parameters.AddWithValue("@FilmAdi",FilmAd);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                 while(rdr.Read())
                {
                    lsvFilmler.Items.Add(Convert.ToString(rdr["FilmAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Yonetmen"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Oyuncular"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Ozet"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["Miktar"]).ToString());
                    
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());
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

        public void FilmleriYonetmeneGoreGetir(ListView lsvFilmler, string Yonetmen)
        {
            lsvFilmler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Filmler inner join FilmTurler on Filmler.FilmTurNo=FilmTurler.FilmTurNo where Filmler.Yonetmen like '%'+@Yonetmen+'%'", cnn);
            cmd.Parameters.AddWithValue("@Yonetmen", Yonetmen);
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
                    lsvFilmler.Items.Add(Convert.ToString(rdr["FilmAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Yonetmen"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Oyuncular"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Ozet"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["Miktar"]).ToString());
                   
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());
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

        public void FilmleriOyuncuyaGoreGetir(ListView lsvFilmler, string Oyuncu)
        {
            lsvFilmler.Items.Clear();
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Filmler inner join FilmTurler on Filmler.FilmTurNo=FilmTurler.FilmTurNo where Filmler.Oyuncular like '%'+@Oyuncular+'%'", cnn);
            cmd.Parameters.AddWithValue("@Oyuncular", Oyuncu);
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
                    lsvFilmler.Items.Add(Convert.ToString(rdr["FilmAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Yonetmen"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Oyuncular"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToString(rdr["Ozet"]));
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["Miktar"]).ToString());
                   
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                    lsvFilmler.Items[i].SubItems.Add(Convert.ToInt32(rdr["FilmNo"]).ToString());
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

        public int StogaGoreFilmGetir(int filmno)
        {
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select Miktar from Filmler where FilmNo=@FilmNo",cnn);
            cmd.Parameters.AddWithValue("@FilmNo",filmno);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int Miktar = 0;
            try
            { 
                Miktar = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return Miktar;
        }
        public bool YeniStokMiktariGuncelle(int yenistogum,int filmnom,string girilenStok)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Filmler where FilmAd=@FilmAd", cnn);
            SqlDataReader dr = new SqlDataReader();
            dr = cmd.ExecuteReader();
            int eskiStok = 0;
            int yeniStok = 0;
            while (dr.Read())
            {
                eskiStok = Convert.ToInt32(dr[6].ToString());
            }

            yeniStok = eskiStok + Convert.ToInt32(girilenStok);
            cmd = new SqlCommand("Update Filmler set Miktar=@Miktar where FilmNo=@FilmNo", cnn);
            cmd.Parameters.AddWithValue("@Miktar", yenistogum);
            cmd.Parameters.AddWithValue("@FilmNo", filmnom);
            cmd.Parameters.AddWithValue("@FilmNo", filmnom);
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
        public bool StokMiktariniGuncelle(int filmno, int adet)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Update Filmler set Miktar-=@Miktar where FilmNo=@FilmNo", cnn);
            cmd.Parameters.AddWithValue("@Miktar",adet);
            cmd.Parameters.AddWithValue("@FilmNo",filmno);
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

        public bool StokMiktariGuncelleFromDegistir(int filmno, int yeniadet, int orjmiktar)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Update Filmler set Miktar=Miktar+@orjinalmiktar-@YeniAdet where FilmNo=@FilmNo", cnn);
            cmd.Parameters.AddWithValue("@orjinalmiktar", orjmiktar);
            cmd.Parameters.AddWithValue("@YeniAdet", yeniadet);
            cmd.Parameters.AddWithValue("@FilmNo", filmno);
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

        public bool FilmStokMiktariniSilerekGuncelle(int filmno, int orjmiktar)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Update Filmler set Miktar=Miktar+@orjin where FilmNo=@FilmNo", cnn);
            cmd.Parameters.AddWithValue("@orjin", orjmiktar);
            cmd.Parameters.AddWithValue("@FilmNo", filmno);
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
    }
}
