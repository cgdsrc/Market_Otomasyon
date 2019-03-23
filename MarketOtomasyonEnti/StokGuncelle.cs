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
    public partial class StokGuncelle : Form
    {
       
        public StokGuncelle(int id)
        {
            InitializeComponent();
            _id = id;
        }
        //Data.MarketEntities db = new Data.MarketEntities();
        Data2.Model1Container1 db = new Data2.Model1Container1();
        public int StokGiren;
       public int _id ;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            StokGiren = Convert.ToInt32(textBox1.Text);
          db.sp_StokGuncelle(_id, StokGiren);
            this.Close();
           


            //dataGridView1.DataSource = anaekran;

            //refreş gelmesi lazım tüm butonlara
        }
      
    }
}
