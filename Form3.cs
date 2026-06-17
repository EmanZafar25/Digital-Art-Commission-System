using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("001", "Anime Portrait", "Pending", "$20");

            dataGridView1.Rows.Add("002", "Landscape Art", "Completed", "$35");

            dataGridView1.Rows.Add("003", "Sketch", "In Progress", "$15");


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string status = row.Cells[2].Value.ToString();

                    if (status == "Pending")
                    {
                        row.Cells[2].Style.ForeColor = Color.Orange;
                    }

                    else if (status == "Completed")
                    {
                        row.Cells[2].Style.ForeColor = Color.Green;
                    }

                    else if (status == "In Progress")
                    {
                        row.Cells[2].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkViolet;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Dashboard");
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form4 placeOrder = new Form4();
            placeOrder.Show();
            this.Hide();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkViolet;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form5 myOrders = new Form5();
            myOrders.Show();
            this.Hide();
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkViolet;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Hide();
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkViolet;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }
    }
}
