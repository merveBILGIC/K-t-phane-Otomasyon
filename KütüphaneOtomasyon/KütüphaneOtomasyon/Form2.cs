using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneOtomasyon
{
    public partial class Form2 : Form
    {

        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-SP9ARMQK\\SQLEXPRESS;Initial Catalog=kutuphaneOtomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataSet ds;
        void kitapGetir()
        {
            adaptor = new SqlDataAdapter("SELECT *FROM KITAPLAR ", baglantı);
            ds = new DataSet();
            baglantı.Open();
            adaptor.Fill( ds,"KITAPLAR");
            dataGridView1.DataSource = ds.Tables["KITAPLAR"];
            baglantı.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonARA_Click(object sender, EventArgs e)
        {
             var kitapAdı =textBox1.Text;
            string sorgu = "SELECT *FROM KITAPLAR WHERE Kitaptürü LİKE '%kitapAdı'";
            adaptor = new SqlDataAdapter(sorgu, baglantı);
            ds = new DataSet();
            baglantı.Open();
            adaptor.Fill(ds, "KITAPLAR");
            dataGridView1.DataSource = ds.Tables["KITAPLAR"];
            baglantı.Close();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3odnc form3Odnc = new Form3odnc();
            form3Odnc.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTSLM formTSLM = new FormTSLM();
            formTSLM.Show();

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            kitapGetir();
           
        }

        private void Ksec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = Ksec.Text;
            string sorgu = "SELECT *FROM" + tablo;
            adaptor = new SqlDataAdapter(sorgu, baglantı);
            ds = new DataSet();
            baglantı.Open();
            adaptor.Fill(ds, tablo);
            dataGridView1.DataSource = ds.Tables[tablo];
            baglantı.Close();
        }
    }
}
