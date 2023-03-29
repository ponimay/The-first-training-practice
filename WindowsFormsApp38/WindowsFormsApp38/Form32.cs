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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> v = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0] != null && row.Cells[0].Value != null)
                {
                    string kolvo = row.Cells[0].Value.ToString();

                    if (v.Contains(kolvo))
                    {
                        textBox1.Text = "Однофамильцы: " + kolvo;
                        return;
                    }
                    else
                    {
                        v.Add(kolvo);
                        textBox1.Text = "Нет однофамильцев";
                    }
                    
                }
            }
            
        }
    }
}
