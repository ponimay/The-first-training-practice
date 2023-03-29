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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
          
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown2.Value;
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            int[,] arr = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            Random rnd = new Random();
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    arr[i, j] = rnd.Next(0, 3);

                }
            }


            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
            int n = 0;
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        n++;
                        textBox1.Text = n.ToString();
                    }

                }
            }
            int nuli = 0;
            int stroki = 0;
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if (Convert.ToInt32(dataGridView1[j, i].Value) == 0)
                    {
                        nuli++;
                    }
                    
                }
                if (nuli>=1)
                {
                    stroki++;
                    nuli = 0;
                }
            }
            textBox2.Text = stroki.ToString();
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form15.ShowDialog();
        }
    }
}
