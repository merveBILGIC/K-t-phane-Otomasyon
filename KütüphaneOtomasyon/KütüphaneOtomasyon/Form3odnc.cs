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
    public partial class Form3odnc : Form
    {
        public Form3odnc()
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
                komut = new SqlCommand("DELETE FROM KITAPLAR WHERE KitapAdı='" + k_adı + "'", baglantı);

                komut.ExecuteNonQuery();
                 void tarih()
                 {
                    DateTime bugun = DateTime.Now;
                    DateTime teslimTarihi;
                    teslimTarihi = bugun.AddDays(15);
                    textBox2.Text = teslimTarihi.ToString();

                 }

                MessageBox.Show("ödünç alınmıştır");

            }
            catch
            {
                MessageBox.Show("HATA OLUŞTU");
            }
            finally
            { baglantı.Close(); }
        }

        private void Form3odnc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
