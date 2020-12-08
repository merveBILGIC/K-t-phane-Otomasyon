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

    public partial class Form2GRS : Form
    {
        public Form2GRS()
        {
            InitializeComponent();
        }
        /*
        private void label2_Click(object sender, EventArgs e)
        {

        }
        */
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-SP9ARMQK\\SQLEXPRESS;Initial Catalog=kutuphaneOtomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();




        private void frm2grs_Click(object sender, EventArgs e)
        {


            var TCNO= textBox1.Text;
           
           

            baglantı.Open();
            komut = new SqlCommand("Select * FROM Üyeler", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text != " " )
                {

                    if (TCNO == oku["TCNO"].ToString())
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        textBox1.Clear();
                       
                        Hmsj.Visible = true;

                    }

                }
                else
                {
                    Umsj1.Visible = true;
                    

                }




            }
            baglantı.Close();
          
            
            
        }

        private void Form2GRS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /* private void Hmsj_Click(object sender, EventArgs e)
         {

         }
         */
    }
}
