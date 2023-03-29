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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        public double reshenie(int a0, int a1, int a2, int a3, int x)
        {
            double py = a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + (a1 * x) + a0;
            return py;
        }
        int a0, a1, a2, a3, x;

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form20.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Напиши число!");
                    return;
                }
                else
                {
                    a0 = Convert.ToInt32(textBox1.Text);
                    a1 = Convert.ToInt32(textBox2.Text);
                    a2 = Convert.ToInt32(textBox3.Text);
                    a3 = Convert.ToInt32(textBox4.Text);
                    x = Convert.ToInt32(textBox5.Text);
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
            
         textBox6.Text = (reshenie(a0, a1, a2, a3, x + 1) - reshenie(a0, a1, a2, a3, x)).ToString();
                
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
