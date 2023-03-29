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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        string username;
        string password;
        
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Aquamarine;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox4.Text;
            password = textBox3.Text;
            string path = @"D:\123.txt";
            if (username == null || password == null)
            {
                MessageBox.Show("Логин или пароль не могут быть пустыми");
                return;
            }

            if (password.Length == 0)
            {
                MessageBox.Show("Пароль не может быть пустым.");
                return;
            }
            if (username.Length == 0)
            {
                MessageBox.Show("Логин не может быть пустым.");
                return;
            }
            if (username == password)
            {
                MessageBox.Show("Логин и пароль не должны совпадать.");
                return;
            }

            string[] liness = File.ReadAllLines(path);
            foreach (string line in liness)
            {
                string[] parts = line.Split('_');
                string username1 = parts[0];
                string password1 = parts[0];
            }

            if (liness.Any(line => line.Split('_')[0] == username)&& liness.Any(line => line.Split('_')[1] == password))
            {
                MessageBox.Show("Вы успешно вошли");
                Program.form28.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль. Попробуйте снова");
                return;
            }

        }
        Point lastpoint;
        private void Form17_MouseMove(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Form17_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Введите логин")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите логин";
                textBox4.ForeColor = Color.Gray;
            }
        }
    }

}

