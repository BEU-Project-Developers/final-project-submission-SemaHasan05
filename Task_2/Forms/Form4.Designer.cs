using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2.Forms
{
  
    partial class Form4
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
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            button2 = new Button();
            label12 = new Label();
            label13 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Indigo;
            label5.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(98, 205);
            label5.Name = "label5";
            label5.Size = new Size(90, 37);
            label5.TabIndex = 14;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Indigo;
            label4.Font = new Font("Yu Gothic UI Semibold", 18.125F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(98, 278);
            label4.Name = "label4";
            label4.Size = new Size(386, 66);
            label4.TabIndex = 13;
            label4.Text = "Design Changes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Yu Gothic UI Semibold", 18.125F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 459);
            label1.Name = "label1";
            label1.Size = new Size(293, 66);
            label1.TabIndex = 15;
            label1.Text = "Dec 10,2024";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 386);
            label2.Name = "label2";
            label2.Size = new Size(74, 37);
            label2.TabIndex = 16;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(102, 638);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 17;
            label3.Text = "Start time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(446, 638);
            label6.Name = "label6";
            label6.Size = new Size(125, 37);
            label6.TabIndex = 18;
            label6.Text = "End time";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(98, 781);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 1);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 580);
            panel2.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Indigo;
            label7.Font = new Font("Yu Gothic UI Semibold", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(273, 60);
            label7.Name = "label7";
            label7.Size = new Size(244, 51);
            label7.TabIndex = 21;
            label7.Text = "Create a task";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = System.Drawing.Image.FromFile("../../../Images/image9.png");
            pictureBox1.Location = new Point(51, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.Font = new Font("Yu Gothic UI Semibold", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(51, 1162);
            button2.Name = "button2";
            button2.Size = new Size(705, 136);
            button2.TabIndex = 25;
            button2.Text = "Create Task";
            button2.UseVisualStyleBackColor = false;
            //button2.Click += (sender, e) => MessageBox.Show("Task created successfully!");
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 1418);
            Controls.Add(button2);
            Name = "Form4";
            Text = "Task Creator";

          
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(panel3);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label13);
           



            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Label label11;
        private Button button2;
        private Label label12;
        private Label label13;
    }
}
