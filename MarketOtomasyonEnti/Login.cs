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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text)==123)
            {
 Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
            }
           else
                MessageBox.Show("Yanlış Şifre");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
