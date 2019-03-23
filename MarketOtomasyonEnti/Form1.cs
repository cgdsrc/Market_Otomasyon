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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public decimal birimfiyat;
        public decimal tutar;
        int id;
        public int stoksayisi;


        Data2.Model1Container1 db = new Data2.Model1Container1();

        private void Form1_Load(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Kategori Adı", typeof(string));
            //dt.Columns.Add("Urun Adı", typeof(string));
            //dt.Columns.Add("Alış Fiyatı", typeof(decimal));
            //dt.Columns.Add("Satış Fiyatı", typeof(decimal));
            //dt.Columns.Add("Adet", typeof(int));

            //dataGridView2.DataSource = dt;

            //var anaekran = db.sp_anaekran4();
            //dataGridView1.DataSource = anaekran;

            //DataGridViewButtonColumn SatısBtn = new DataGridViewButtonColumn();
            //SatısBtn.Text = "Ürünü Sat";
            //SatısBtn.HeaderText = "Satış";
            //SatısBtn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(SatısBtn);
            //SatısBtn.DefaultCellStyle.BackColor = Color.Green;
            //DataGridViewButtonColumn StokBtn = new DataGridViewButtonColumn();
            //StokBtn.Text = "Stok Güncelle";
            //StokBtn.HeaderText = "Stok Ekleme";
            //StokBtn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(StokBtn);
            //StokBtn.DefaultCellStyle.BackColor = Color.Brown;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (Convert.ToInt32(row.Cells[5].Value) < 20)
                {
                    row.Cells[5].Style.BackColor = Color.OrangeRed;
                }


            }
        }
        decimal toplamtutar;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //if (e.ColumnIndex == 6)
            //{
            //urunad = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            birimfiyat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
            //frm.ShowDialog();
            UrunSatıs frm = new UrunSatıs(stoksayisi);
            tutar = frm.a * birimfiyat;
            toplamtutar = tutar + toplamtutar;
            textBox1.Text = toplamtutar.ToString();
            //}
            //else if (e.ColumnIndex == 7)
            //{
            degisiklikform degisiklikfrm = new degisiklikform(id);
            degisiklikfrm.ShowDialog();
            //id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //StokGuncelle frm2 = new StokGuncelle(id);
            //frm2.ShowDialog();

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunSatıs frm = new UrunSatıs(stoksayisi);
            db.sp_satis(id, frm.a);
            textBox1.Clear();

            //var anaekran = db.sp_anaekran4();
            //dataGridView1.DataSource = anaekran;

            dataGridView1.Refresh();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle form = new UrunEkle();
            form.ShowDialog();
        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            SatısBilgi form = new SatısBilgi();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stoksayisi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            UrunSatıs frm = new UrunSatıs(stoksayisi);
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            birimfiyat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
          
            frm.ShowDialog();

            tutar = frm.a * birimfiyat;
            toplamtutar = tutar + toplamtutar;
            textBox1.Text = toplamtutar.ToString();





            //dataGridView2.Rows.Add(dataGridView1[0, 0].Value, dataGridView1[1, 0].Value);
        }




        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var anaekran = db.sp_anaekran4();
            dataGridView1.DataSource = anaekran;
            this.dataGridView1.Columns["UrunID"].Visible = false;
            DataGridViewRowCollection copyRows = new DataGridViewRowCollection(new DataGridView());
            copyRows = dataGridView1.Rows;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    return;


                }
                else if (comboBox1.SelectedIndex == 1)
                {


                    if (row.Cells[1].Value.ToString() == "Yiyecek")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                else if (comboBox1.SelectedIndex == 2)
                {

                    if (row.Cells[1].Value.ToString() == "Sigara")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }


                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    if (row.Cells[1].Value.ToString() == "Alkol")
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;

                }

                else if (comboBox1.SelectedIndex == 4)
                {


                    if (row.Cells[1].Value.ToString() == "Temizlik")
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }
            currencyManager1.ResumeBinding();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{



        //}
    }
}
