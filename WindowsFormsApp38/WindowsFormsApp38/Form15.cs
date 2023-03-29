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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] arr = textBox1.Text.Split(' ');
            int korotkoeslovo = arr[0].Length;
            string schetchik = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < korotkoeslovo)
                {
                    korotkoeslovo = arr[i].Length;
                    schetchik = arr[i];
                }
            }
            textBox2.Text = schetchik.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form16.ShowDialog();
        }
    }
}
