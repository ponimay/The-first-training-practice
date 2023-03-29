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
    public partial class Form29 : Form
    {
        public Form29()
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
                        textBox2.Clear();
                        textBox2.Text = reader.ReadToEnd();
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
            string slovo = textBox1.Text;
            string[] lines = textBox2.Lines;

            foreach (string line in lines)
            {
                if (line.Contains(slovo))
                {

                    textBox3.Text = line;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
