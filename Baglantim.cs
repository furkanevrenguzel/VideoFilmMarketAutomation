using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMarketPortalim
{
    public class Baglantim
    {
        private String cnnstring = @"Data Source=(LocalDb)\V11.0;Initial Catalog=VideoFilmMarketVeritabanim;Integrated Security=True";

        public static int M_No;//v-12 açıklama 2:40
        public static string M_Adi;
        public static string M_SoyAdi;
        public static int F_No;
        public static string F_Adi;

        public String Cnnstring
        {
            get { return cnnstring; }
            set { cnnstring = value; }
        }

    }
}
