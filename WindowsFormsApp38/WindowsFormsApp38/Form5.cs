using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp38
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double eps;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (maskedTextBox1.Text == "" )
                {
                    MessageBox.Show("Напиши что-нибудь уже наконец");
                    return;
                }
                else
                {
                    eps = Convert.ToDouble(maskedTextBox1.Text);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("не надо букавы вводить");
            }
            double sum = 0;
            int n = 1;
            double S = 1/Math.Sqrt(n);
            while (S>eps)
            {
                sum = sum + S;
                n++;
                S = 1 / Math.Sqrt(n);
            }
            if (eps < 0)
            {
                MessageBox.Show("Вы ввели отрицательный eps");
            }
            else
            {
                textBox1.Text = Math.Round(sum, 2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form7.ShowDialog();
        }
    }
}
