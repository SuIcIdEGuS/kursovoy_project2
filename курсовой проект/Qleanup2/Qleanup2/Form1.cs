using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qleanup2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form newForm5 = new Form5();
            newForm5.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form newForm2 = new Form2();
            newForm2.Show();
            this.Hide ();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form newForm4 = new Form4();
            newForm4.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form newForm3 = new Form3();
            newForm3.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form newForm2 = new Form2();
            newForm2.Show();
            this.Hide();
        }
    }
}
