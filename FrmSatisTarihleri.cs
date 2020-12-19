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
    public partial class FrmSatisTarihleri : Form
    {
        public FrmSatisTarihleri()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int toplamAdet = 0;
        decimal toplamTutar = 0;
        private void FrmSatisTarihleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            dtpilk.Value = DateTime.Today;
            dtpSon.Value = DateTime.Today;
            Satislar s=new Satislar();
            ds = s.SatislariGetirbyTarih(dtpilk, dtpSon);
            dgvSatislar.DataSource = ds.Tables["Satislar"];
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                toplamAdet+=Convert.ToInt32(item["Adet"]);
                toplamTutar+=Convert.ToDecimal(item["Tutar"]);
            }
            txtToplamAdet.Text = toplamAdet.ToString();
            txtToplamTutar.Text = toplamTutar.ToString();

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            toplamAdet = 0;
            toplamTutar = 0;
            Satislar s = new Satislar();
            ds = s.SatislariGetirbyTarih(dtpilk, dtpSon);
            dgvSatislar.DataSource = ds.Tables["Satislar"];
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                toplamAdet += Convert.ToInt32(item["Adet"]);
                toplamTutar += Convert.ToDecimal(item["Tutar"]);
            }
            txtToplamAdet.Text = toplamAdet.ToString();
            txtToplamTutar.Text = toplamTutar.ToString();
        }
    }
}
