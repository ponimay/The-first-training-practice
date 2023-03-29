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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }
     
        public string fileName = "Untitled";
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                fileName = openFileDialog1.FileName;
                //новый код, открывает и читает файл
                try
                {

                    using (StreamReader reader = File.OpenText(fileName))
                    {

                        string fileText = File.ReadAllText(fileName);
                        string[] chisla;
                        chisla = fileText.Split(' ');
                        int s, sum = 0;
                        for (int i = 0; i < chisla.Length; i++)
                        {
                            s = Convert.ToInt32(chisla[i]);

                            if (s < 0)
                            {
                                textBox1.Text = "Сумма чисел до отрицательного: " + sum;
                                break;
                            }
                            sum += s;
                        }
                    }


                }

                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    MessageBox.Show("error");
                }
            }
        }

    }
}
    
    