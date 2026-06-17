using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Rounded Register Button
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button1.Width - radius, button1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button1.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            button1.Region = new Region(path);

            // Button Design
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = Color.White;

            // Password Hide
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;

            // Transparent Labels
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Empty Fields Check
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // Password Match Check
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Registration Success
            MessageBox.Show("Registration Successful!");

            // Open Login Form
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumPurple;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
