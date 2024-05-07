using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace 期末0507
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(pictureBox2);
            pictureBox2.Hide();
            this.Controls.Add(pictureBox3);
            pictureBox3.Hide();

            pictureBox1.Paint += (sender, e) =>
            {
                using (var brush = new SolidBrush(SystemColors.ControlText))
                {
                    if (pictureBox1.Image == null)
                    {
                        string hintText = "點擊此處選擇照片";
                        Font Font = new Font("Arial", 13);
                        SizeF textSize = e.Graphics.MeasureString(hintText, Font);
                        float x = (pictureBox1.Width - textSize.Width) / 2;
                        float y = (pictureBox1.Height - textSize.Height) / 2;
                        e.Graphics.DrawString("點擊此處選擇照片", Font, brush, x, y);
                    }
                    else
                    {
                        pictureBox2.Show();
                        pictureBox2.Paint += (sender, e) =>
                        {
                            using (var brush = new SolidBrush(SystemColors.ControlText))
                            {
                                if (pictureBox2.Image == null)
                                {
                                    string hintText = "點擊此處選擇照片";
                                    Font Font = new Font("Arial", 13);
                                    SizeF textSize = e.Graphics.MeasureString(hintText, Font);
                                    float x = (pictureBox1.Width - textSize.Width) / 2;
                                    float y = (pictureBox1.Height - textSize.Height) / 2;
                                    e.Graphics.DrawString("點擊此處選擇照片", Font, brush, x, y);
                                }
                                else if (pictureBox1.Image != null && pictureBox2.Image != null)
                                {
                                    pictureBox3.Show();
                                }


                            }
                        };
                    }


                }
            };
        }

        private void moodcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox moodComboBox = new ComboBox();
            moodComboBox.Items.AddRange(new string[] { "😊", "😔", "😡", "😄", "😢" });
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        private void weathercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox weathercomboBox = new ComboBox();
            weathercomboBox.Items.AddRange(new string[] { "☀️", "☁️", "🌧️", "❄️", "🌈" });
        }
        private void DrawTextOnPictureBox(string text)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法家仔照片: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                try
                {
                    pictureBox2.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法家仔照片: " + ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                try
                {
                    pictureBox3.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法家仔照片: " + ex.Message);
                }
            }
        }
    }
}
