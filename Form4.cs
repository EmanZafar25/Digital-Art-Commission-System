using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Portrait");
            comboBox1.Items.Add("Anime Art");
            comboBox1.Items.Add("Landscape");
            comboBox1.Items.Add("Sketch");
            comboBox1.Items.Add("Digital Painting");

            comboBox2.Items.Add("Small");
            comboBox2.Items.Add("Medium");
            comboBox2.Items.Add("Large");
            comboBox2.Items.Add("Extra Large");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Place Orders.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 myOrders = new Form5();
            myOrders.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();

                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files|.jpg;.jpeg;.png;.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            richTextBox1.Clear();

            pictureBox1.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            MessageBox.Show(
                "Order Submitted Successfully!\n\n" +
                "Art Type: " + comboBox1.Text +
                "\nSize: " + comboBox2.Text,
                "Success");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            richTextBox1.Clear();
        }


    }
}
