using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMarketPortalim
{
    public class Kontrol
    {
        public Kontrol()
        {

        }

        public static string Temizle(string Metin)
        {
            string keyword = Metin;
            keyword = keyword.Replace("'", "");
            keyword = keyword.Replace("[", "");
            keyword = keyword.Replace("(", "");
            keyword = keyword.Replace("?", "");
            return keyword;
        }
    }
}
