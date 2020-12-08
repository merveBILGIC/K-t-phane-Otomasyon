using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();


        }

        private void button1_GRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2GRS form2GRS = new Form2GRS();
            form2GRS.Show();
                 


        }

        private void button2_UYE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3UYE form3UYE = new Form3UYE();
            form3UYE.Show();
        }

    }
}
