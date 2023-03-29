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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                double k1 = 1;
                double y = Math.Pow(Math.E, 2) * Math.Sin(k1) * Math.Pow(Math.Tan(k1),2);
                MessageBox.Show($"y = {Math.Round(y,2)}");
            }
            if (radioButton2.Checked == true)
            {
                double k2 = 2;
                double y = Math.PI * Math.Pow(k2, 2);
                MessageBox.Show($"y = {Math.Round(y, 2)}");
            }
            if (radioButton3.Checked == true)
            {
                double k3 = 3;
                double y = (4 / 3 * Math.PI * k3) + 2.1;
                MessageBox.Show($"y = {Math.Round(y, 2)}");
            }
            if (radioButton4.Checked == true)
            {
                double k4 = 4;
                double y = Math.Pow(k4 * Math.Cos(k4), 2);
                MessageBox.Show($"y = {Math.Round(y, 2)}");
            }
        }
    }
}
