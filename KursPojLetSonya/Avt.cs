using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KursPojLetSonya
{
    public partial class Avt : Form
    {
        readonly ClassPodcluchenieBD classPodcluchenieBD = new ClassPodcluchenieBD();
        public bool guestAvt { get; private set; }
        public Avt()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Avt_Resize);
        }
        private void Avt_Resize(object sender, EventArgs e)
        {
            // Коэффициенты относительно высоты окна для размещения элементов
            float label1PosFactor = 0.1f;
            float textBoxNamePosFactor = 0.3f;
            float textBoxPwdPosFactor = 0.4f;
            float buttonToMainPosFactor = 0.5f;
            float linkLabelPosFactor = 0.65f;
            float buttonToMainGuestPosFactor = 0.7f;
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

            // AvtNameTextBox
            AvtNameTextBox.Width = controlWidth;
            AvtNameTextBox.Height = controlHeight;
            AvtNameTextBox.Location = new Point((this.ClientSize.Width - AvtNameTextBox.Width) / 2, (int)(this.ClientSize.Height * textBoxNamePosFactor));

            //PasswordLabel
            PasswordLabel.Width = controlWidth;
            PasswordLabel.Height = controlHeight;
            PasswordLabel.Location = new Point((this.ClientSize.Width - PasswordLabel.Width) / 3, (int)(this.ClientSize.Height * passwordLabelPosFactor));

            // AvtPasswordTextBox
            AvtPasswordTextBox.Width = controlWidth;
            AvtPasswordTextBox.Height = controlHeight;
            AvtPasswordTextBox.Location = new Point((this.ClientSize.Width - AvtPasswordTextBox.Width) / 2, (int)(this.ClientSize.Height * textBoxPwdPosFactor));

            // ToMainButton
            ToMainButton.Width = buttonWidth;
            ToMainButton.Height = controlHeight;
            ToMainButton.Location = new Point((this.ClientSize.Width - ToMainButton.Width) / 2, (int)(this.ClientSize.Height * buttonToMainPosFactor));

            // ToNewAvtLinkLabel
            ToNewAvtLinkLabel.Width = controlWidth;
            ToNewAvtLinkLabel.Height = controlHeight;
            ToNewAvtLinkLabel.Location = new Point((this.ClientSize.Width - ToNewAvtLinkLabel.Width) / 2, (int)(this.ClientSize.Height * linkLabelPosFactor));

            // ToMainAsGuestButton
            ToMainAsGuestButton.Width = buttonWidth;
            ToMainAsGuestButton.Height = controlHeight;
            ToMainAsGuestButton.Location = new Point((this.ClientSize.Width - ToMainAsGuestButton.Width) / 2, (int)(this.ClientSize.Height * buttonToMainGuestPosFactor));
        }

        public void LoadData(string query)
        {
            DataTable data = new DataTable();
            using (var connection = classPodcluchenieBD.GetSqlConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            data.Load(dataReader);
                        }
                    }
                }
            }
        }

        private void ToMainButton_Click(object sender, EventArgs e)
        {
            string zapros = "SELECT avt_name FROM avtorization WHERE avt_name = @AvtNameTextBox AND avt_password = @AvtPasswordTextBox";
            using (var connection = new NpgsqlConnection(classPodcluchenieBD.sql))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(zapros, connection))
                    {
                        cmd.Parameters.AddWithValue("@AvtNameTextBox", AvtNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@AvtPasswordTextBox", AvtPasswordTextBox.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.Username = AvtNameTextBox.Text;
                                MainForm frm = new MainForm(guestAvt);
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Неправильное имя пользователя или пароль. Если вы не зарегистрированы, пожалуйста, зарегистрируйтесь.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ToNewAvtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAvt newAvt = new NewAvt();
            newAvt.ShowDialog();
        }

        private void ToMainAsGuestButton_Click(object sender, EventArgs e)
        {
            guestAvt = true;
            MainForm frm = new MainForm(guestAvt);
            frm.ShowDialog();
            this.Close();
        }
        public static class UserSession
        {
            public static string Username { get; set; }
        }
    }
}
