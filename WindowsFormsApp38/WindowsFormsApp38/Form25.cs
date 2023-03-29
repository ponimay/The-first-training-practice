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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }
       
        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(100), random.Next(100), random.Next(100));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Form25 form25 = new Form25();
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 100, 100, 90, 90);
            
            double q = DateTime.Now.TimeOfDay.TotalSeconds * Math.PI / 5;
            double cx = pictureBox1.Width / 2;
            double cy = pictureBox1.Height / 2;
            double px = 135 + 45 * Math.Cos(q);
            double py = 140 + 45 * Math.Sin(q);
            g.FillEllipse(new SolidBrush(GetRandomColor()), new Rectangle((int)px, (int)py, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form26.ShowDialog();
        }
    }
}
