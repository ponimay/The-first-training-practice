using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp38
{

    public partial class Form30 : Form
    {
        public string fileName = "Untitled";
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1","Пункт посадки");
            dataGridView1.Columns.Add("Column2", "Время отправления");
            dataGridView1.Columns.Add("Column3", "Время прибытия");
            dataGridView1.Columns.Add("Column4", "Время полёта");
            dataGridView1.Columns.Add("Column5", "Стоимость билета");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                fileName = openFileDialog1.FileName;
                //новый код, открывает и читает файл
                try
                {
                    foreach (var line in File.ReadLines(@"C:\Users\k2510\O.А. 2.2ИСиП-2 Чева Кирп\Untitled.txt"))
                    {
                        var arr = line.Split('2');
                        
                            try
                            {
                                dataGridView1.Rows[0].Cells["Column1"].Value = arr[0];
                                dataGridView1.Rows[1].Cells["Column1"].Value = arr[1];
                                dataGridView1.Rows[2].Cells["Column1"].Value = arr[2];
                                dataGridView1.Rows[0].Cells["Column5"].Value = arr[3];
                                dataGridView1.Rows[1].Cells["Column5"].Value = arr[4];
                                dataGridView1.Rows[2].Cells["Column5"].Value = arr[5];
                                
                            }

                            catch (Exception ex)
                            {
                                return;
                            }
                        
                    }

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = (n).ToString();
            dataGridView1.Rows[n].Cells[1].Value = dateTimePicker1.Value.ToString();
            dataGridView1.Rows[n].Cells[2].Value = (n).ToString();
            dataGridView1.Rows[n].Cells[3].Value = dateTimePicker2.Value.ToString();
            dataGridView1.Rows[n].Cells[4].Value = (n).ToString();
            dataGridView1.Rows[n].Cells[2].Value = dateTimePicker3.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form31.ShowDialog();
        }
    }
}
