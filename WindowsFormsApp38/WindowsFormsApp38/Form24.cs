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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        int kartinki = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           pictureBox1.Image = imageList1.Images[kartinki];
           kartinki++;
            if (kartinki == 24)
            {
                timer1.Stop();
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form25.ShowDialog();
        }
    }
}
