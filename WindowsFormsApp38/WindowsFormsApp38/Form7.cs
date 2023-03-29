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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            double S = 0;
            double B = 0;
            for (int i = 0; i<n; i++)
            {
                B += arr[i];
                S += 1 / B;
                textBox1.Text = Math.Round(S,2).ToString();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form8.ShowDialog();
        }
    }
}
