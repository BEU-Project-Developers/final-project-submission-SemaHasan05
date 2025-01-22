namespace Task_2.Forms
{
    partial class Form2 : Form
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox8 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();

            // 
            // pictureBox5
            // 
            pictureBox5.Image = ((Image)(resources.GetObject("pictureBox5.Image")));
            pictureBox5.Location = new Point(50, 50);
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            // 
            // label1
            // 
            label1.Text = "Welcome to Form2";
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.Location = new Point(200, 50);
            label1.AutoSize = true;

            // 
            // label2
            // 
            label2.Text = "Subtitle here";
            label2.Font = new Font("Arial", 12F, FontStyle.Regular);
            label2.Location = new Point(200, 100);
            label2.AutoSize = true;

            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label8);
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(50, 200);
            panel1.Size = new Size(300, 300);

            // Add other components initialization (buttons, labels, etc.)
            button1.Text = "Click Me";
            button1.Location = new Point(400, 500);
            button1.Size = new Size(100, 50);

            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";

            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox6;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox7;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox8;
        private Button button1;
    }
}
