﻿namespace 期末0507
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
            dateTimePicker1 = new DateTimePicker();
            moodcomboBox = new ComboBox();
            savebutton = new Button();
            context = new RichTextBox();
            weathercomboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // moodcomboBox
            // 
            moodcomboBox.FormattingEnabled = true;
            moodcomboBox.Items.AddRange(new object[] { "😊", "😔", "😡", "😄", "😢" });
            moodcomboBox.Location = new Point(318, 37);
            moodcomboBox.Name = "moodcomboBox";
            moodcomboBox.Size = new Size(151, 27);
            moodcomboBox.TabIndex = 1;
            moodcomboBox.Text = "心情";
            moodcomboBox.SelectedIndexChanged += moodcomboBox_SelectedIndexChanged;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(697, 37);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(94, 29);
            savebutton.TabIndex = 4;
            savebutton.Text = "儲存";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // context
            // 
            context.EnableAutoDragDrop = true;
            context.Location = new Point(24, 80);
            context.Name = "context";
            context.Size = new Size(781, 547);
            context.TabIndex = 5;
            context.Text = "";
            context.TextChanged += richTextBox1_TextChanged;
            // 
            // weathercomboBox
            // 
            weathercomboBox.FormattingEnabled = true;
            weathercomboBox.Items.AddRange(new object[] { "☀️", "☁️", "🌧️", "❄️", "🌈" });
            weathercomboBox.Location = new Point(498, 37);
            weathercomboBox.Name = "weathercomboBox";
            weathercomboBox.Size = new Size(151, 27);
            weathercomboBox.TabIndex = 6;
            weathercomboBox.Text = "天氣";
            weathercomboBox.SelectedIndexChanged += weathercomboBox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(834, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(1054, 47);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 12;
            label1.Text = "照片";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(1106, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLight;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(834, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(238, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLight;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(1106, 312);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(238, 176);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(837, 117);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1110, 118);
            button2.Name = "button2";
            button2.Size = new Size(28, 29);
            button2.TabIndex = 17;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(838, 315);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 18;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1110, 315);
            button4.Name = "button4";
            button4.Size = new Size(28, 29);
            button4.TabIndex = 19;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1374, 638);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(weathercomboBox);
            Controls.Add(context);
            Controls.Add(savebutton);
            Controls.Add(moodcomboBox);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Diary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox moodcomboBox;
        private Button savebutton;
        private RichTextBox context;
        private ComboBox weathercomboBox;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}