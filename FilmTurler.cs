using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace VideoMarketPortalim
{
    public class FilmTurler
    {
       Baglantim bl = new Baglantim();
        #region Fields
        private int _FilmTurNo;
        private string _TurAd;
        private string _Aciklama; 
        #endregion

        #region Properties
        public int FilmTurNo
        {
            get { return _FilmTurNo; }
            set { _FilmTurNo = value; }
        }
        public string TurAd
        {
            get { return _TurAd; }
            set { _TurAd = value; }
        }
        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        } 
        #endregion

        public override string ToString()
        {
            return TurAd;
        }
       public void FilmTurleriGetir(ComboBox cmbTurler)
        {
            SqlConnection cnn = new SqlConnection(bl.Cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from FilmTurler", cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FilmTurler fr = new FilmTurler();
                    fr.FilmTurNo=Convert.ToInt32(rdr["FilmTurNo"]);
                    fr.TurAd = Convert.ToString(rdr["TurAd"]);
                    fr.Aciklama = Convert.ToString(rdr["Aciklama"]);
                    cmbTurler.Items.Add(fr);
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

       public void FilmTurleriGetirLst(ListView lsvFilmTur)
       {
           lsvFilmTur.Items.Clear();
           SqlConnection cnn = new SqlConnection(bl.Cnnstring);
           SqlCommand cmd = new SqlCommand("Select * from FilmTurler", cnn);

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
                   lsvFilmTur.Items.Add(Convert.ToInt32(rdr["FilmTurNo"]).ToString());
                   lsvFilmTur.Items[i].SubItems.Add(Convert.ToString(rdr["TurAd"]));
                   lsvFilmTur.Items[i].SubItems.Add(Convert.ToString(rdr["Aciklama"]));
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

       public bool FilmTurKaydet(string turAdi, string aciklama)
       {
           bool sonuc = false;
           SqlConnection cnn = new SqlConnection(bl.Cnnstring);
           SqlCommand cmd = new SqlCommand("Insert Into FilmTurler (TurAd,Aciklama) values (@TurAd,@Aciklama)", cnn);
           cmd.Parameters.AddWithValue("@TurAd", turAdi);
           cmd.Parameters.AddWithValue("@Aciklama", aciklama);
      
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

       public bool FilmTurGuncelle(string turadi, string aciklama, int turno)
       {
           bool sonuc = false;
           SqlConnection cnn = new SqlConnection(bl.Cnnstring);
           SqlCommand cmd = new SqlCommand("Update FilmTurler set TurAd=@TurAd,Aciklama=@Aciklama where FilmTurNo=@turno ", cnn);
           cmd.Parameters.AddWithValue("@TurAd", turadi);
           cmd.Parameters.AddWithValue("@Aciklama", aciklama);
           cmd.Parameters.AddWithValue("@TurNo", turno);
     
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

       public bool FilmTurSil(int turno)
       {
           bool sonuc = false;
           SqlConnection cnn = new SqlConnection(bl.Cnnstring);
           SqlCommand cmd = new SqlCommand("Delete from FilmTurler where FilmTurNo=@FilmTurNo",cnn);
           cmd.Parameters.AddWithValue("@FilmTurNo", turno);
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
