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
    public partial class degisiklikform : Form
    {
        public degisiklikform(int id)
        {
            InitializeComponent();
            _id = id;
        }
        public int _id;
        private void degisiklikform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokGuncelle frm2 = new StokGuncelle(_id);
            frm2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data2.Model1Container1 db = new Data2.Model1Container1();
            db.sp_sil2(_id);
            this.Close();
            MessageBox.Show("Ürün Silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
