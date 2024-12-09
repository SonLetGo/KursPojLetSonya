using Npgsql;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static KursPojLetSonya.Avt;

namespace KursPojLetSonya
{
    public partial class ExcersiceForm : Form
    {
        private string username;
        public int extimation = 0;
        readonly ClassPodcluchenieBD classPodcluchenieBD = new ClassPodcluchenieBD();

        public ExcersiceForm(string username)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(MainForm_Resize);

            label3.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;

            DoingTimer = new Timer
            {
                Interval = 1000
            };
            DoingTimer.Tick += timer1_Tick;
            counter = 5400;
            DoingTimer.Start();
        }

        public void MainForm_Resize(object sender, EventArgs e)
        {
            float labelPosFactor = 0.1f;

            float flowLayoutPanelMainPosFactor = 0.2f;

            float doneButtonPosFactor = 0.9f;
            float buttonExapePosFactor = 0.1f;
            int controlWidth = this.ClientSize.Width / 2;
            int controlHeight = this.ClientSize.Height / 10;
            int buttonWidth = this.ClientSize.Width / 5;

            int flowLayoutPaneWidth = this.ClientSize.Width / 1;
            int flowLayoutPaneHeight = this.ClientSize.Height / 1;

            labelText.Width = controlWidth;
            labelText.Height = controlHeight;
            labelText.Location = new Point((this.ClientSize.Width - labelText.Width) / 2, (int)(this.ClientSize.Height * labelPosFactor));

            timerLabel.Width = controlWidth;
            timerLabel.Height = controlHeight;
            timerLabel.Location = new Point((this.ClientSize.Width - timerLabel.Width + 400) / 2, (int)(this.ClientSize.Height * labelPosFactor));

            flowLayoutPanelMain.Width = flowLayoutPaneWidth;
            flowLayoutPanelMain.Height = flowLayoutPaneHeight;
            flowLayoutPanelMain.Location = new Point((this.ClientSize.Width - flowLayoutPanelMain.Width) / 2, (int)(this.ClientSize.Height * flowLayoutPanelMainPosFactor));

            doneButton.Width = buttonWidth;
            doneButton.Height = controlHeight;
            doneButton.Location = new Point((this.ClientSize.Width - doneButton.Width) / 1, (int)(this.ClientSize.Height * doneButtonPosFactor));

            label12.Location = new Point(1350, 600);

            buttonExape.Width = buttonWidth;
            buttonExape.Height = controlHeight;
            buttonExape.Location = new Point((this.ClientSize.Width - buttonExape.Width) / 200, (int)(this.ClientSize.Height * buttonExapePosFactor));

            flowLayoutPanelFirstEx.Location = new Point(450, 120);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            DoingTimer.Stop();
            //1
            if (ex1TextBox.Text == "cosa")
            {
                label3.Visible = true;
                label3.ForeColor = Color.Green;
                label3.Text = "Правильно!Молодец!";
                extimation++;
            }
            else
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Неверно, правильный ответ: cosa";
            }

            //2
            if (textBox2.Text == "2sina")
            {
                label5.Visible = true;
                label5.ForeColor = Color.Green;
                label5.Text = "Правильно!Молодец!";
                extimation++;
            }
            else
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Неверно, правильный ответ: 2sina";
            }

            //3
            if (ex3TextBox.Text == "-1/2")
            {
                label7.Visible = true;
                label7.ForeColor = Color.Green;
                label7.Text = "Правильно!Молодец!";
                extimation++;
            }
            else
            {
                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "Неверно, правильный ответ: -1/2";
            }

            //4


            if (radioButton1.Checked)
            {
                label9.Visible = true;
                label9.ForeColor = Color.Green;
                label9.Text = "Правильно!Молодец!";
                extimation++;
            }
            else
            {
                label9.Visible = true;
                label9.ForeColor = Color.Red;
                label9.Text = "Неверно, правильный ответ: 1";
            }


            //5

            if (radioButton5.Checked)
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
                label11.Text = "Неверно, правильный ответ: 2";
            }


            if (extimation >= 5) { extimation = 5; }
            if (extimation <= 2) { extimation = 2; }

            label12.Visible = true;
            label12.Text = $"Ваша оценка {extimation}";

            SaveEstimation(extimation);
        }

        private void SaveEstimation(int extimation)
        {
            string getUserIdQuery = @"SELECT avt_id FROM avtorization WHERE avt_name = @Username";
            string username = UserSession.Username;

            using (var connection = new NpgsqlConnection(classPodcluchenieBD.sql))
            {
                try
                {
                    connection.Open();
                    int userId;
                    using (var cmd = new NpgsqlCommand(getUserIdQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        userId = Convert.ToInt32(result);
                    }

                    string insertEstimationQuery =
                        @"INSERT INTO extimations (exti_name, exti_extimation, ex_date) 
                        VALUES (@UserId, @Extimation, CURRENT_DATE)";
                    using (var cmd = new NpgsqlCommand(insertEstimationQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Extimation", extimation);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Оценка добавлена");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить оценку");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при добавлении оценки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int counter;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            int minutes = counter / 60;
            int seconds = counter % 60;
            timerLabel.Text = $"{minutes:D2}:{seconds:D2} ";
            if (counter == 0)
            {
                DoingTimer.Stop();
            }
        }
    }
}
