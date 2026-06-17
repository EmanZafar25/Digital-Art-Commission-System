namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_05_15_110609;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 644);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 31);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(492, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 31);
            textBox2.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(492, 315);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(139, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Purple;
            linkLabel1.Location = new Point(683, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 46);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 5;
            label1.Text = "Welcome back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(492, 91);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 6;
            label2.Text = "login to continue";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(492, 398);
            button1.Name = "button1";
            button1.Size = new Size(345, 47);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 483);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Purple;
            linkLabel2.Location = new Point(683, 483);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 25);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register Here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Vladimir Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 36);
            label4.Name = "label4";
            label4.Size = new Size(228, 87);
            label4.TabIndex = 10;
            label4.Text = "Artify ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 113);
            label5.Name = "label5";
            label5.Size = new Size(102, 38);
            label5.TabIndex = 11;
            label5.Text = "Studio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(492, 155);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 12;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(492, 235);
            label7.Name = "label7";
            label7.Size = new Size(101, 28);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(899, 628);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
