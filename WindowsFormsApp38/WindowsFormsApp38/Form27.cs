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
using System.Collections;

namespace WindowsFormsApp38
{
    public partial class Form27 : Form
    {
        public static ArrayList a = new ArrayList();
        public static ArrayList a1 = new ArrayList();
        public static ArrayList s = new ArrayList();
        public Form27()
        {
            InitializeComponent();
        }
        public string fileName = "Untitled";
        private void Form27_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = saveFileDialog1.FileName;
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBox1.Text);
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        

        private void button4_Click(object sender, EventArgs e)
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
                        textBox1.Clear();
                        textBox1.Text = reader.ReadToEnd();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            toolStripStatusLabel1.Text = date.ToString();
            string time = DateTime.Now.ToString("HH:mm:ss");
            toolStripStatusLabel2.Text = time.ToString();
            toolStripStatusLabel3.Text = $"Путь к выбранному файлу: {fileName.ToString()}";
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            string[] vseslova; 
            Dictionary<string, int> slovar = new Dictionary<string, int>(); 
            List<string> povtoryayuschiesyaslova = new List<string>(); 
                                                        
            vseslova = textBox1.Text.Split(new char[] { ' ', '.', ','});
            foreach (string slovo in vseslova)
            {
                if (slovar.ContainsKey(slovo))
                    slovar[slovo]++;
                else
                    slovar[slovo] = 1;

            }

            // находим повторяющиеся слова
            var sortirovka = slovar.OrderByDescending(p => p.Value).Take(3);
            foreach (var nomerelementa in sortirovka)
            {
                povtoryayuschiesyaslova.Add(nomerelementa.Key);
            }

            // переносим найденные слова в комбобокс
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(povtoryayuschiesyaslova.ToArray());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poiskslova = comboBox1.SelectedItem.ToString();
            string[] vseslova = textBox1.Lines;
            int schet = 0;
            foreach (string slovo in vseslova)
            {
                int index = slovo.IndexOf(poiskslova);
                while (index >= 0)
                {
                    schet++;
                    index = slovo.IndexOf(poiskslova, index + 1);
                }
            }

            toolStripStatusLabel4.Text = $"Нашли '{poiskslova}' = {schet}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.form29.ShowDialog();
        }
    }
}


