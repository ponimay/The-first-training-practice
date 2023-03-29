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
    
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        int k;
        int[,] arr;int n;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (maskedTextBox1.Text == "")
            {
               MessageBox.Show("Напиши что-нибудь уже наконец");
                return;
            }
            else
            {
                n = Convert.ToInt32(maskedTextBox1.Text);
            }
            
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            arr = new int[n, n];
            Random rnd = new Random();
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;
            for (int q = 0; q < n; q++)
            {
                for (int a = 0; a < n; a++)
                {
                    arr[q, a] = rnd.Next(-1, 10);
                    dataGridView1.Rows[q].Cells[a].Value = arr[q, a].ToString();
                    dataGridView2.Rows[q].Cells[a].Value = arr[q, a].ToString();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count - 1;
            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Напиши что-нибудь уже наконец");
                return;
            }
            else
            {
                 k = Convert.ToInt32((maskedTextBox2.Text)) - 1;
            }
           

            int minIndex = 0;
            int minValue = int.MinValue;
            for (int j = 0; j < n; j++)
            {
                int value = Math.Abs(Convert.ToInt32((dataGridView1.Rows[k].Cells[j].Value.ToString())));
                if (value < minValue)
                {
                    minValue = value;
                    minIndex = j;
                }
            }

            if (minIndex != k)
            {
                for (int i = 0; i <= n; i++)
                {
                    int temp = Convert.ToInt32((dataGridView1.Rows[i].Cells[minIndex].Value.ToString()));
                    dataGridView1.Rows[i].Cells[minIndex].Value = dataGridView1.Rows[k].Cells[i].Value;
                    dataGridView1.Rows[k].Cells[i].Value = temp;
                    dataGridView1.Rows[i].Cells[minIndex].Style.BackColor = Color.LightGray;
                    dataGridView1.Rows[k].Cells[i].Style.BackColor = Color.Beige;
                }
            }
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}

