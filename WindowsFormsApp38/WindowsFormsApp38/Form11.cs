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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(comboBox1.Text);
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Медведи");
            comboBox1.Items.Add("Лошади");
            comboBox1.Items.Add("Пони");
            comboBox1.Items.Add("Зебры");
            comboBox1.Items.Add("Зайцы");
        }



        string path = @"C:\Users\k2510\O.А. 2.2ИСиП - 2 Чева Кирп\qqqqqqqqqqqqqqq.txt";
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox1.Items[i]);

                }
                writer.Close();
            }
            dlg.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(listBox1.SelectedItem);
            comboBox1.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.form12.ShowDialog();
        }

       
    }
}
    

        


    

