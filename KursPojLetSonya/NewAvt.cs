using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KursPojLetSonya
{
    public partial class NewAvt : Form
    {
        readonly ClassPodcluchenieBD classPodcluchenieBD = new ClassPodcluchenieBD();
        public NewAvt()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(NewAvt_Resize);
        }

        private void NewAvt_Resize(object sender, EventArgs e)
        {
            // Коэффициенты относительно высоты окна для размещения элементов
            float label1PosFactor = 0.1f;
            float newLoginTextBoxPosFactor = 0.3f;
            float newPasswordTextBoxPosFactor = 0.4f;
            float saveButtonPosFactor = 0.5f;
            float toAvtButtonPosFactor = 0.65f;
            float loginLabelPosFactor = 0.25f;
            float passwordLabelPosFactor = 0.35f;

            // Общие параметры
            int controlWidth = this.ClientSize.Width / 2;
            int controlHeight = this.ClientSize.Height / 10;
            int buttonWidth = this.ClientSize.Width / 5;

            // label1
            label1.Width = controlWidth;
            label1.Height = controlHeight;
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (int)(this.ClientSize.Height * label1PosFactor));

            //LoginLabel
            LoginLabel.Width = controlWidth;
            LoginLabel.Height = controlHeight;
            LoginLabel.Location = new Point((this.ClientSize.Width - LoginLabel.Width) / 3, (int)(this.ClientSize.Height * loginLabelPosFactor));

            //NewLoginTextBox
            NewLoginTextBox.Width = controlWidth;
            NewLoginTextBox.Height = controlHeight;
            NewLoginTextBox.Location = new Point((this.ClientSize.Width - NewLoginTextBox.Width) / 2, (int)(this.ClientSize.Height * newLoginTextBoxPosFactor));

            //PasswordLabel
            PasswordLabel.Width = controlWidth;
            PasswordLabel.Height = controlHeight;
            PasswordLabel.Location = new Point((this.ClientSize.Width - PasswordLabel.Width) / 3, (int)(this.ClientSize.Height * passwordLabelPosFactor));

            //NewPasswordTextBox
            NewPasswordTextBox.Width = controlWidth;
            NewPasswordTextBox.Height = controlHeight;
            NewPasswordTextBox.Location = new Point((this.ClientSize.Width - NewPasswordTextBox.Width) / 2, (int)(this.ClientSize.Height * newPasswordTextBoxPosFactor));

            //SaveButton
            SaveButton.Width = buttonWidth;
            SaveButton.Height = controlHeight;
            SaveButton.Location = new Point((this.ClientSize.Width - SaveButton.Width) / 2, (int)(this.ClientSize.Height * saveButtonPosFactor));

            //ToAvtButton
            ToAvtButton.Width = buttonWidth;
            ToAvtButton.Height = controlHeight;
            ToAvtButton.Location = new Point((this.ClientSize.Width - ToAvtButton.Width) / 2, (int)(this.ClientSize.Height * toAvtButtonPosFactor));
        }

        public void LoadData(string query)
        {
            DataTable data = new DataTable();
            using (var connection = classPodcluchenieBD.GetSqlConnection())
            {
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        data.Load(dataReader);
                    }
                }
            }
        }

        private void ToAvtButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = NewLoginTextBox.Text;
            string password = NewPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkPasswordQuery = "SELECT COUNT(*) FROM avtorization WHERE avt_password = @password";

            try
            {
                using (var connection = classPodcluchenieBD.GetSqlConnection())
                {
                    using (var checkCmd = new NpgsqlCommand(checkPasswordQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Этот пароль уже используется. Пожалуйста, выберите другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string insertQuery = "INSERT INTO avtorization (avt_name, avt_password) VALUES (@username, @password)";
                    using (var cmd = new NpgsqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Пользователь успешно зарегистрирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
