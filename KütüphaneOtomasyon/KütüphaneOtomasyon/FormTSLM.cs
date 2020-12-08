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
    public partial class FormTSLM : Form
    {
        public FormTSLM()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-SP9ARMQK\\SQLEXPRESS;Initial Catalog=kutuphaneOtomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                var k_adı = textBox1.Text;
                var k_yazarı = textBox2.Text;
                var b_yılı = textBox3.Text;
                var s_sayısı = textBox4.Text;
                var k_turu = textBox5.Text;
                string sql = "INSERT INTO KITAPLAR values (@KitapAdı,@Yazar,@BasımYılı,@SayfaSayısı,@KitapTürü)";
                komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(new SqlParameter("@KitapAdı", k_adı));
                komut.Parameters.Add(new SqlParameter("@Yazar", k_yazarı));
                komut.Parameters.Add(new SqlParameter("@BasımYılı", b_yılı));
                komut.Parameters.Add(new SqlParameter("@SayfaSayısı", s_sayısı));
                komut.Parameters.Add(new SqlParameter("@KitapTürü", k_turu));
                MessageBox.Show("TESLİM ALINMIŞTIR");
            }

            catch
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN!");
            }
           finally
            { baglantı.Close(); }

        }

        private void FormTSLM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
