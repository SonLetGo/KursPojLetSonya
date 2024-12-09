using KursPojLetSonya.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursPojLetSonya
{
    public partial class VariantiForm : Form
    {
        private int variant;
        public VariantiForm(int variant)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.Resize += new EventHandler(MainForm_Resize);

            this.variant = variant;
            VariantEx();
            label2.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label11.Visible = false;
        }

        public void MainForm_Resize(object sender, EventArgs e)
        {
            float label1PosFactor = 0.1f;
            float flowLayoutPanelMainPosFactor = 0.3f;

            float doneButtonPosFactor = 0.9f;
            float buttonExapePosFactor = 0.15f;

            int controlHeight = this.ClientSize.Height / 10;
            int buttonWidth = this.ClientSize.Width / 5;
            int controlWidth = this.ClientSize.Width / 2;

            int flowLayoutPaneWidth = this.ClientSize.Width / 1;
            int flowLayoutPaneHeight = this.ClientSize.Height / 2;

            label14.Width = controlWidth;
            label14.Height = controlHeight;
            label14.Location = new Point((this.ClientSize.Width - label14.Width) / 2, (int)(this.ClientSize.Height * label1PosFactor));

            flowLayoutPanel1.Width = flowLayoutPaneWidth;
            flowLayoutPanel1.Height = flowLayoutPaneHeight;
            flowLayoutPanel1.Location = new Point((this.ClientSize.Width - flowLayoutPanel1.Width) / 2, (int)(this.ClientSize.Height * flowLayoutPanelMainPosFactor));

            doneButton.Width = buttonWidth;
            doneButton.Height = controlHeight;
            doneButton.Location = new Point((this.ClientSize.Width - doneButton.Width) / 1, (int)(this.ClientSize.Height * doneButtonPosFactor));

            buttonExape.Width = buttonWidth;
            buttonExape.Height = controlHeight;
            buttonExape.Location = new Point((this.ClientSize.Width - buttonExape.Width) / 200, (int)(this.ClientSize.Height * buttonExapePosFactor));

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void VariantEx()
        {
            switch (variant)
            {
                case 1:
                    //ex1
                    pictureBoxEx1.Image = ByteArrayToImage(Properties.Resources.aex1);
                    pictureBoxAns1_1.Image = ByteArrayToImage(Properties.Resources.aex1_otv1);
                    pictureBoxAns1_2.Image = ByteArrayToImage(Properties.Resources.aex1_otv2);
                    pictureBoxAns1_3.Image = ByteArrayToImage(Properties.Resources.aex1_otv3);
                   //ex2
                    pictureBoxEx2.Image = ByteArrayToImage(Properties.Resources.aex2);
                    pictureBoxAns2_1.Image = ByteArrayToImage(Properties.Resources.aex2_otv1);
                    pictureBoxAns2_2.Image = ByteArrayToImage(Properties.Resources.aex2_otv2);
                    //ex3
                    pictureBoxEx3.Image = ByteArrayToImage(Properties.Resources.aex3);
                    pictureBoxAns3_1.Image = ByteArrayToImage(Properties.Resources.aex3_otv1);
                    pictureBoxAns3_2.Image = ByteArrayToImage(Properties.Resources.aex3_otv2);
                    //ex4
                    pictureBoxEx4.Image = ByteArrayToImage(Properties.Resources.aex4);
                    return;

                case 2:
                    //ex1
                    pictureBoxEx1.Image = ByteArrayToImage(Properties.Resources.bex1);
                    pictureBoxAns1_1.Image = ByteArrayToImage(Properties.Resources.bex1_otv1);
                    pictureBoxAns1_2.Image = ByteArrayToImage(Properties.Resources.bex1_otv2);
                    pictureBoxAns1_3.Image = ByteArrayToImage(Properties.Resources.bex1_otv3);
                    //ex2
                    pictureBoxEx2.Image = ByteArrayToImage(Properties.Resources.bex2);
                    pictureBoxAns2_1.Image = ByteArrayToImage(Properties.Resources.bex2_otv1);
                    pictureBoxAns2_2.Image = ByteArrayToImage(Properties.Resources.bex3_otv2);
                    //ex3
                    pictureBoxEx3.Image = ByteArrayToImage(Properties.Resources.bex3);
                    pictureBoxAns3_1.Image = ByteArrayToImage(Properties.Resources.bex3_otv1);
                    pictureBoxAns3_2.Image = ByteArrayToImage(Properties.Resources.bex3_otv2);
                    //ex4
                    pictureBoxEx4.Image = ByteArrayToImage(Properties.Resources.bex4);
                    return;

                case 3:
                    //ex1
                    pictureBoxEx1.Image = ByteArrayToImage(Properties.Resources.cex1);
                    pictureBoxAns1_1.Image = ByteArrayToImage(Properties.Resources.cex1_otv1);
                    pictureBoxAns1_2.Image = ByteArrayToImage(Properties.Resources.cex1_otv2);
                    pictureBoxAns1_3.Image = ByteArrayToImage(Properties.Resources.cex1_otv3);
                    //ex2
                    pictureBoxEx2.Image = ByteArrayToImage(Properties.Resources.cex2);
                    pictureBoxAns2_1.Image = ByteArrayToImage(Properties.Resources.cex2_otv1);
                    pictureBoxAns2_2.Image = ByteArrayToImage(Properties.Resources.cex2_otv2);
                    //ex3
                    pictureBoxEx3.Image = ByteArrayToImage(Properties.Resources.cex3);
                    pictureBoxAns3_1.Image = ByteArrayToImage(Properties.Resources.cex3_otv1);
                    pictureBoxAns3_2.Image = ByteArrayToImage(Properties.Resources.cex3_otv2);
                    //ex4
                    pictureBoxEx4.Image = ByteArrayToImage(Properties.Resources.cex4);
                    return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int extimation = 0;

            switch (variant)
            {
                case 1:
                    //1
                    if (ex1TextBox.Text == "32")
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Green;
                        label2.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Red;
                        label2.Text = "Неверно, правильный ответ: 32";
                    }
                    //2
                    if (radioButton1.Checked)
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Green;
                        label12.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Red;
                        label12.Text = "Неверно, правильный ответ: 1";
                    }
                    //3
                    if (radioButton3.Checked)
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Green;
                        label13.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Red;
                        label13.Text = "Неверно, правильный ответ: 1";
                    }
                    //4
                    if (ex4TextBox.Text == "0")
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Green;
                        label11.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Red;
                        label11.Text = "Неверно, правильный ответ: 0";
                    }
                    return;
                case 2:
                    //1
                    if (ex1TextBox.Text == "12")
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Green;
                        label2.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Red;
                        label2.Text = "Неверно, правильный ответ: 12";
                    }
                    //2
                    if (radioButton1.Checked)
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Green;
                        label12.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Red;
                        label12.Text = "Неверно, правильный ответ: 1";
                    }
                    //3
                    if (radioButton4.Checked)
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Green;
                        label13.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Red;
                        label13.Text = "Неверно, правильный ответ: 2";
                    }
                    //4
                    if (ex4TextBox.Text == "1")
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Green;
                        label11.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Red;
                        label11.Text = "Неверно, правильный ответ: 1";
                    }
                    return;
                case 3:
                    //1
                    if (ex1TextBox.Text == "12")
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Green;
                        label2.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Red;
                        label2.Text = "Неверно, правильный ответ: 12";
                    }
                    //2
                    if (radioButton1.Checked)
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Green;
                        label12.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label12.Visible = true;
                        label12.ForeColor = Color.Red;
                        label12.Text = "Неверно, правильный ответ: 1";
                    }
                    //3
                    if (radioButton4.Checked)
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Green;
                        label13.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label13.Visible = true;
                        label13.ForeColor = Color.Red;
                        label13.Text = "Неверно, правильный ответ: 2";
                    }
                    //4
                    if (ex4TextBox.Text == "0")
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Green;
                        label11.Text = "Правильно!Молодец!";
                        extimation++;
                    }
                    else
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Red;
                        label11.Text = "Неверно, правильный ответ: 0";
                    }
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
