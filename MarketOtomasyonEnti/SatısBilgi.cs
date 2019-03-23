using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonEnti
{
    public partial class SatısBilgi : Form
    {
        public SatısBilgi()
        {
            InitializeComponent();
        }

        private void SatısBilgi_Load(object sender, EventArgs e)
        {
         
            Data2.Model1Container1 db = new Data2.Model1Container1();
            var satıs = (from t in db.Satıs
                         select t).ToList();
            dataGridView1.DataSource = satıs;
            this.dataGridView1.Columns["Urunler"].Visible = false;
        }
    }
}
