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
    public partial class FrmMusteriSorgulama : Form
    {
        public FrmMusteriSorgulama()
        {
            InitializeComponent();
        }

        private void txtAdinaGoreAra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoyAdaGore_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAdinaGoreAra_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriAdaGoreGetir(lsvMusteriler,txtAdinaGoreAra.Text);
        }

        private void txtAdinaGoreAra_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Musteriler m = new Musteriler();
            m.MusteriGetir(lsvMusteriler);
        }

        private void txtAdinaGoreAra_TextChanged_1(object sender, EventArgs e)
        {

            Musteriler m = new Musteriler();
            m.MusteriAdaGoreGetir(lsvMusteriler, txtAdinaGoreAra.Text);
        }

        private void txtSoyAdaGore_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriSoyadaGoreGetir(lsvMusteriler,txtSoyAdaGore.Text);
        }

       
    }
}
