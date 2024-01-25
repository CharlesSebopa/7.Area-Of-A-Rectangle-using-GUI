using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Area_Of_A_Rectangle_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, L, H;
            if (double.TryParse(textBox1.Text, out H) && double.TryParse(textBox2.Text, out L))
            {

                A = L * H;
                textBox3.Text = A.ToString();
            }
            else
            {
                MessageBox.Show("invalid entry", "error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double L, H, P;
            if (double.TryParse(textBox1.Text, out H) && double.TryParse(textBox2.Text, out L))
            {

                P = 2 * (L + H);
                textBox4.Text = P.ToString();
            }
            else
            {
                MessageBox.Show("invalid entry", "error");
            }
        }
    }
}
