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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public static int[] arr;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true; 
            Random random = new Random();
            int N = Convert.ToInt32(numericUpDown1.Value);
            arr = new int[N];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = random.Next(0, 100);
                textBox1.Text += arr[i] + " ".ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = true; button6.Enabled = true; button7.Enabled = true; button8.Enabled = true;
            var nomera = from i in arr
                         orderby i ascending
                         select i;
            foreach (int i in nomera)
                listBox1.Items.Add(i);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex--;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = Convert.ToInt32(numericUpDown1.Value - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            button2.Enabled = false; button5.Enabled = false; button6.Enabled = false; button7.Enabled = false; button8.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form18.ShowDialog();
        }
    }
}
