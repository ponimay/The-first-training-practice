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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        public double S (double a, double b, double c)
        {
            double p = a + b + c;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;

        }
        int a, b, c, d;

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form21.ShowDialog();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Напиши что-нибудь уже наконец");
                    return;
                }
                else
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    c = Convert.ToInt32(textBox3.Text);
                    d = Convert.ToInt32(textBox4.Text);
                    button1.Enabled = true;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("не надо букавы вводить");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (a == 0 || b == 0 || c == 0 || d == 0)
            {
                MessageBox.Show("Сторона треугольника не может быть = 0");
            }
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double ss = S(a, b, c);
                textBox5.Text = Math.Round(ss, 2).ToString();
            }
            else
            {
                textBox5.Text = "Треугольник abc начертить нельзя";
            }
            if ((a + b > d) && (b + d > a) && (a + d > b))
            {
                double ss1 = S(a, b, d);
                textBox6.Text = Math.Round(ss1, 2).ToString();
            }
            else
            {
                textBox6.Text = "Треугольник abd начертить нельзя";
            }
            if ((a + d > c) && (d + c > a) && (a + c > d))
            {
                double ss2 = S(a, d, c);
                textBox7.Text = Math.Round(ss2, 2).ToString();
            }
            else
            {
                textBox7.Text = "Треугольник adc начертить нельзя";
            }
            if ((d + b > c) && (b + c > d) && (d + c > b))
            {
                double ss3 = S(d, b, c);
                textBox8.Text = Math.Round(ss3, 2).ToString();
            }
            else
            {
                textBox8.Text = "Треугольник dbc начертить нельзя";
            }
        }
    }
}
