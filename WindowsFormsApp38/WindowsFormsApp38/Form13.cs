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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }
        public void proverka (string n)
        {
            if (listBox1.Items[0].ToString() != listBox2.Items[0].ToString())
            { }
            else
            {
                listBox2.Items.Clear();
                foreach (string l in listBox1.Items)
                {
                    listBox2.Items.Add(l);
                    n = l;
                }
            }
            return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string x = "";
            proverka(x);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form34.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
