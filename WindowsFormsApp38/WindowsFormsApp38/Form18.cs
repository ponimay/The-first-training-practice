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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
     
        List<int> raznieelementi = new List<int>();
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Напиши что-нибудь уже наконец");
                    return;
                }
                else
                {
                    n = Convert.ToInt32(textBox2.Text);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("не надо букавы вводить");
                return;
            }
            if (n<0)
            {
                MessageBox.Show("Надо положительное число вообще-то");
                return;
            }
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int q = 0; q < n; q++)
            {
                for (int a = 0; a < n; a++)
                {
                    arr[q, a] = rnd.Next(-10, 10);
                    dataGridView1.Rows[q].Cells[a].Value = arr[q, a].ToString();
                }
            }
            
            foreach (int element in arr)
            {
                bool unikalniy = true;

                // проверяем элемент на уникальность
                foreach (int drugoielement in arr)
                {
                    if (element != drugoielement && !raznieelementi.Contains(drugoielement))
                    {
                        if (element == drugoielement)
                        {
                            unikalniy = false;
                            break;
                        }
                    }
                }

                if (unikalniy && !raznieelementi.Contains(element))
                {
                    raznieelementi.Add(element); 
                    
                    textBox1.Text += element + ", ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form35.ShowDialog();
        }
    }
}
