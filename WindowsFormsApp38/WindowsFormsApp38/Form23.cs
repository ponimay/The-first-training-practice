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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        
        public double msec = 0;
        public double sec = 0;
        public double min = 0;
        public double h = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            msec++;
            if (msec == 100)
            {
                sec++;

                if (sec == 60)
                {
                    min++;
                    sec = 0;
                    MessageBox.Show("Прошла минута");
                }
                msec = 0;
            }
            if (min == 60)
            {
                h++;
                min = 0;
            }
           
            label1.Text = "часы: " + h + " минуты: " + min + " секунды:" + sec + " миллисекунды: " + msec;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            msec = 0;
            sec = 0;
            min = 0;
            h = 0;
            label1.Text = "часы: " + h + " минуты: " + min + " секунды:" + sec + " миллисекунды: " + msec;
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.form24.ShowDialog();
        }
    }
}
