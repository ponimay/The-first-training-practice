﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double x,y;

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form6.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == ""|| maskedTextBox2.Text == "")
            {
                MessageBox.Show("Напиши что-нибудь уже наконец");
                return;
            }
            else
            {
                x = Convert.ToInt32(maskedTextBox1.Text);
                y = Convert.ToInt32(maskedTextBox2.Text);
            }

            
            
            if (x < 0 & y < 0)
            { 
                textBox1.Text = Math.Abs(x).ToString(); 
            }
            if (((x < 0) && (y >= 0)) | ((x >= 0) && (y < 0)))
            {
                textBox2.Text = (y+0.5).ToString();
            }
            if (x > 0 && y > 0)
            {
                textBox1.Text = (x*10).ToString();
            }
        }
    }
}
