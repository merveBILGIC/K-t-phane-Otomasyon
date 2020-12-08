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
    public partial class Form3UYE : Form
    {
        public Form3UYE()
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
                var Ad_soyad = textBox1.Text;
                var TCno = textBox2.Text;
                var telNo = textBox4.Text;
                var email = textBox5.Text;

                komut = new SqlCommand("insert into  Üyeler(ÜyeadSoyad, TCNO,TelNo,E-mail)values('" + Ad_soyad + "','" + TCno + "','" + telNo + "','" + email + "')", baglantı);

                komut.ExecuteNonQuery();


                MessageBox.Show("KAYIT OLUŞTURULDU.GİRİŞ SAYFASINA GEÇİŞ YAPILIYOR");
                this.Hide();
                Form3UYE form3 = new Form3UYE();
                form3.Show();
            }


            catch
            {
                MessageBox.Show("HATA OLUŞTU YENİDEN DENEYİN");
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }   textBox5.Clear();
            
            baglantı.Close();
        }
       
        private void Form3UYE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
