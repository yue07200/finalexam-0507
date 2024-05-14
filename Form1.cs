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
        int currentImageIndex = 0;
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(pictureBox2);
            pictureBox2.Hide();
            button2.Hide();
            this.Controls.Add(pictureBox3);
            pictureBox3.Hide();
            button3.Hide();
            this.Controls.Add(pictureBox4);
            pictureBox4.Hide();
            button4.Hide();

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
                        button2.Show();
                        pictureBox2.Paint += (sender, e) =>
                        {
                            using (var brush = new SolidBrush(SystemColors.ControlText))
                            {
                                if (pictureBox2.Image == null)
                                {
                                    string hintText = "點擊此處選擇照片";
                                    Font Font = new Font("Arial", 13);
                                    SizeF textSize = e.Graphics.MeasureString(hintText, Font);
                                    float x = (pictureBox2.Width - textSize.Width) / 2;
                                    float y = (pictureBox2.Height - textSize.Height) / 2;
                                    e.Graphics.DrawString("點擊此處選擇照片", Font, brush, x, y);
                                }
                                else
                                {
                                    pictureBox3.Show();
                                    button3.Show();
                                    pictureBox3.Paint += (sender, e) =>
                                    {
                                        using (var brush = new SolidBrush(SystemColors.ControlText))
                                        {
                                            if (pictureBox3.Image == null)
                                            {
                                                string hintText = "點擊此處選擇照片";
                                                Font Font = new Font("Arial", 13);
                                                SizeF textSize = e.Graphics.MeasureString(hintText, Font);
                                                float x = (pictureBox3.Width - textSize.Width) / 2;
                                                float y = (pictureBox3.Height - textSize.Height) / 2;
                                                e.Graphics.DrawString("點擊此處選擇照片", Font, brush, x, y);
                                            }
                                            else
                                            {
                                                pictureBox4.Show();
                                                button4.Show();
                                                pictureBox4.Paint += (sender, e) =>
                                                {
                                                    using (var brush = new SolidBrush(SystemColors.ControlText))
                                                    {
                                                        if (pictureBox4.Image == null)
                                                        {
                                                            string hintText = "點擊此處選擇照片";
                                                            Font Font = new Font("Arial", 13);
                                                            SizeF textSize = e.Graphics.MeasureString(hintText, Font);
                                                            float x = (pictureBox4.Width - textSize.Width) / 2;
                                                            float y = (pictureBox4.Height - textSize.Height) / 2;
                                                            e.Graphics.DrawString("點擊此處選擇照片", Font, brush, x, y);
                                                        }
                                                    }
                                                };
                                            }


                                        }
                                    };
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
                currentImageIndex++;
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
                currentImageIndex++;
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
                currentImageIndex++;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentImageIndex++;
                string selectedImagePath = openFileDialog.FileName;
                try
                {
                    pictureBox4.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法家仔照片: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要移除照片嗎？", "移除照片", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = null;
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image = null;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = null;
                pictureBox2.Hide();
                button2.Hide();
                
                if (pictureBox3 != null)
                {
                    pictureBox2.Show();
                    button2.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要移除照片嗎？", "移除照片", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                if (currentImageIndex < 3)
                {
                    // 將後續的照片向前移動一位
                    pictureBox2.Image = pictureBox3.Image;
                    pictureBox3.Image = pictureBox4.Image;
                    pictureBox4.Image = null;

                    // 更新當前顯示的照片索引
                    currentImageIndex++;
                }
                else
                {
                    // 隱藏 PictureBox4
                    pictureBox4.Hide();
                }
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要移除照片嗎？", "移除照片", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pictureBox3.Image = null;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = null;
                pictureBox4.Hide();
                button4.Hide();
                if (pictureBox4 != null)
                {
                    pictureBox4.Show();
                    button4.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要移除照片嗎？", "移除照片", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pictureBox4.Image = null;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = null;
            }
        }
    }
}
