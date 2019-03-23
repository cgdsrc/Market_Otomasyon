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
    public partial class UrunSatıs : Form
    {
        public UrunSatıs(int sayi)
        {
            InitializeComponent();
            //textBox2.Text = urunad;
            _sayi = sayi;
        }
        //Form1 frm = new Form1();
       public int a;
        public int _sayi;
        private void button1_Click(object sender, EventArgs e)
        {
           
           
            a = Convert.ToInt32(textBox1.Text);
            Form1 form1 = new Form1();
            
            Data2.Model1Container1 db = new Data2.Model1Container1();
            if (_sayi<a)
            {
                int b = (a-_sayi);
                MessageBox.Show(+ b + " Adet Ürün Eksiğiniz vardır");
                a = 0;
            }
            else
            this.Close();
           
            


            //dataGridView1.DataSource = anaekran;
            //db.sp_satis()
            //   var sat =(from t in db.Stok
            //             )

        }

        private void UrunSatıs_Load(object sender, EventArgs e)
        {
           
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
