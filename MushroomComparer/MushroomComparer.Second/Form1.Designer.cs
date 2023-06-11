namespace MushroomComparer.Second
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(771, 502);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1034, 502);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(771, 30);
            button1.Name = "button1";
            button1.Size = new Size(342, 35);
            button1.TabIndex = 2;
            button1.Text = "Load image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(771, 71);
            button2.Name = "button2";
            button2.Size = new Size(342, 35);
            button2.TabIndex = 3;
            button2.Text = "Compare image";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(27, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(711, 565);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1034, 535);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(771, 535);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1034, 568);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(79, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(771, 568);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(257, 27);
            textBox6.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(771, 470);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 628);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Mushroom Comparer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
    }
}