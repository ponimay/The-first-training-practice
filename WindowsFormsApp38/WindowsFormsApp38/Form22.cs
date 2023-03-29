using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp38
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent(); 
        }
        double a,a1,b1,c1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Напиши что-нибудь уже наконец");
                        return;
                    }
                    else
                    {
                        a = Convert.ToDouble(textBox1.Text);
                        
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("не надо букавы вводить");
                }
                for (double i = 0.1; i < 1; i+=0.1)
                {
                    double k = a * (i + 1) + 2;
                    chart1.Series[0].Points.AddXY(i, k);
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    if (textBox4.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Напиши что-нибудь уже наконец");
                        return;
                    }
                    else
                    {
                        a1 = Convert.ToDouble(textBox4.Text);
                        b1 = Convert.ToDouble(textBox2.Text);
                        c1 = Convert.ToDouble(textBox3.Text);
                        
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("не надо букавы вводить");
                }
                for (double i = -10; i < 10; i += 2)
                {
                    double k = a*Math.Pow(i,2)+b1*i+c1;
                    chart2.Series[0].Points.AddXY(i, k);
                }
            }

        }
    }
}
