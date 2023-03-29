using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp38
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

      

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Кухня_ сцены с ножом.mp4";
        }
    }
}
