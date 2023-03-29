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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        double o;
        double y;
        double t;
        double r;
        double p;
        int m;
        private void button1_Click(object sender, EventArgs e)
        {
            int Vichislenie(double i, double j, double u, double v)
            {
                return Convert.ToInt32(Math.Pow(u, i) - Math.Pow(v, j));
                
            }
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "")
            {
                MessageBox.Show("Напиши что-нибудь уже наконец");
                return;
            }
            else
            {
                o = Convert.ToDouble(maskedTextBox1.Text);
                y = Convert.ToDouble(maskedTextBox2.Text);
                t = Convert.ToDouble(maskedTextBox3.Text);
                r = Convert.ToDouble(maskedTextBox4.Text);
                textBox1.Text = $"{Vichislenie(o,y,t,r)}";
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iks(double x, int n)
            {
                if (n == 0)
                {
                    return 1;
                
                }
                if (n < 0)
                {
                    return Convert.ToInt32(1 / Math.Pow(x, Math.Abs(n)));
                }
                else
                {
                    return Convert.ToInt32(x * Math.Pow(x, n - 1));
                }
            }
            if (maskedTextBox5.Text == "" || maskedTextBox6.Text == "")
            {
                MessageBox.Show("Напиши что-нибудь уже наконец");
                return;
            }
            else
            {
               p = Convert.ToDouble(maskedTextBox5.Text);
               m = Convert.ToInt32(maskedTextBox6.Text);
               textBox2.Text = $"{iks(p,m)}";
            }
           
          
        }
    }
}
