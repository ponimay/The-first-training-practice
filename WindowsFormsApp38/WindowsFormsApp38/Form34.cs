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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Человек с фамилией " + textBox1.Text + " находится в читательном зале");
            }
            else
            {
                MessageBox.Show("Человека с фамилией " + textBox1.Text+ " сегодня нет в читательном зале");
            }
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Семушев");
            listBox1.Items.Add("Семушева");
            listBox1.Items.Add("Федорова");
            listBox1.Items.Add("Филатова");
            listBox1.Items.Add("Лаухина");
            listBox1.Items.Add("Трунилин");
            listBox1.Items.Add("Минаев");
        }
    }
}
