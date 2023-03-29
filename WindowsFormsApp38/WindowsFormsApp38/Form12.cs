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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            int a1 = random.Next(0, 100);
            int a2 = random.Next(0, 100);
            int a3 = random.Next(0, 100);
            int a4 = random.Next(0, 100);
            int a5 = random.Next(0, 100);
            int a6 = random.Next(0, 100);
            int a7 = random.Next(0, 100);
            int a8 = random.Next(0, 100);
            int a9 = random.Next(0, 100);
            dataGridView1[0, 0].Value = a1;
            dataGridView1[1, 0].Value = a2;
            dataGridView1[2, 0].Value = a3;
            dataGridView1[3, 0].Value = a4;
            dataGridView1[0, 1].Value = a5;
            dataGridView1[1, 1].Value = a6;
            dataGridView1[0, 2].Value = a7;
            dataGridView1[0, 3].Value = a8;
            dataGridView1[1, 3].Value = a9;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form13.ShowDialog();
        }
    }
}
