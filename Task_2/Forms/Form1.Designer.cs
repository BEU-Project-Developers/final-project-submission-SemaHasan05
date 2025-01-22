using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // label1
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold);
            label1.Location = new Point(89, 93);
            label1.Name = "label1";
            label1.Size = new Size(150, 65);
            label1.Text = "Login";
            // label2
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(97, 173);
            label2.Name = "label2";
            label2.Size = new Size(194, 37);
            label2.Text = "Welcome back";
            // label3
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Yu Gothic UI Semibold", 10.875F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(98, 321);
            label3.Name = "label3";
            label3.Size = new Size(202, 40);
            label3.Text = "Email Address";
            // label4
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Yu Gothic UI Semibold", 10.875F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(98, 490);
            label4.Name = "label4";
            label4.Size = new Size(141, 40);
            label4.Text = "Password";
            // textBox1
            textBox1.Location = new Point(98, 398);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(553, 39);
            // textBox2
            textBox2.Location = new Point(98, 564);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(553, 39);
            // label5
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Yu Gothic UI", 7.875F);
            label5.Location = new Point(477, 522);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.Text = "Forgot Password?";
            label5.Click += Label5_Click;
            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Lavender;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Yu Gothic UI", 10.125F);
            checkBox1.Location = new Point(98, 668);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(268, 41);
            checkBox1.Text = "Keep me signed in";
            // button1
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(98, 750);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // button2
            button2.Location = new Point(350, 750);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.Text = "Create an account";
            button2.UseVisualStyleBackColor = true;
            // panel1
            panel1.BackColor = Color.Lavender;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 1434);
            // Form1
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 1434);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password reset link sent to your email!");
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
