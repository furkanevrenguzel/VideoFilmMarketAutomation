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
    public partial class FrmFilmSorgula : Form
    {
        public FrmFilmSorgula()
        {
            InitializeComponent();
        }

        private void FrmFilmSorgula_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            FilmTurler ft = new FilmTurler();
            ft.FilmTurleriGetir(cmbTurler);

            Filmler f = new Filmler();
            f.FilmGetir(lsvFilmler);
        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTurler ft =(FilmTurler) cmbTurler.SelectedItem;
            Filmler f = new Filmler();
            f.FilmTurlerineGoreGetir(lsvFilmler, ft.FilmTurNo);
        }

        private void txtFilmAdinaGore_TextChanged(object sender, EventArgs e)
        {
            Filmler f = new Filmler();
            f.FilmleriGosterByAdinaGore(lsvFilmler,txtFilmAdinaGore.Text);
        }

        private void txtYonetmeneGore_TextChanged(object sender, EventArgs e)
        {
            Filmler f = new Filmler();
            f.FilmleriYonetmeneGoreGetir(lsvFilmler, txtYonetmeneGore.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Filmler f = new Filmler();
            f.FilmleriOyuncuyaGoreGetir(lsvFilmler, txtOyuncuyaGore.Text);
        }

        private void txtFilmAdinaGore_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtYonetmeneGore_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOyuncuyaGore_KeyPress(object sender, KeyPressEventArgs e)
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
