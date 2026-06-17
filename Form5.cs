using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();

            comboBox1.Items.Add("All View");
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Completed");
            comboBox1.Items.Add("In Progress");

            comboBox1.SelectedIndex = 0;

            dataGridView1.Rows.Add("001", "Portrait", "Medium", "Pending", "$20", "12/06/2026");

            dataGridView1.Rows.Add("002", "Anime Art", "Large", "Completed", "$35", "10/06/2026");

            dataGridView1.Rows.Add("003", "Sketch", "Small", "In Progress", "$15", "11/06/2026");


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value != null)
                    {
                        string status = row.Cells[3].Value.ToString();
    
                        if (status == "Pending")
                        {
                            row.Cells[3].Style.ForeColor = Color.Orange;
                        }
    
                        else if (status == "Completed")
                        {
                            row.Cells[3].Style.ForeColor = Color.Green;
                        }
    
                        else if (status == "In Progress")
                        {
                            row.Cells[3].Style.ForeColor = Color.Blue;
                        }
                    }
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text =
        DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 placeOrder = new Form4();
            placeOrder.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on My Orders.");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string status = row.Cells[3].Value.ToString();

                if (selectedStatus == "All View")
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = (status == selectedStatus);
                }
            }
        }
    }
}
