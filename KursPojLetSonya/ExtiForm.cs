using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static KursPojLetSonya.Avt;

namespace KursPojLetSonya
{
    public partial class ExtiForm : Form
    {
        private string username;
        readonly ClassPodcluchenieBD classPodcluchenieBD = new ClassPodcluchenieBD();

        public ExtiForm(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(MainForm_Resize);
            DataView();
        }

        public void MainForm_Resize(object sender, EventArgs e)
        {
            float labelPosFactor = 0.1f;
            float TableNamePosFactor = 0.2f;
            float ButtontPosFactor = 0.75f;

            int controlWidth = this.ClientSize.Width / 2;
            int controlHeight = this.ClientSize.Height / 10;
            int tableHeight = this.ClientSize.Height / 2;
            int buttonWidth = this.ClientSize.Width / 5;

            label1.Width = controlWidth;
            label1.Height = controlHeight;
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (int)(this.ClientSize.Height * labelPosFactor));

            dataGridView1.Width = controlWidth;
            dataGridView1.Height = tableHeight;
            dataGridView1.Location = new Point((this.ClientSize.Width - dataGridView1.Width) / 2, (int)(this.ClientSize.Height * TableNamePosFactor));


            button1.Width = buttonWidth;
            button1.Height = controlHeight;
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, (int)(this.ClientSize.Height * ButtontPosFactor));
        }

            private void DataView()
        {
            string getUserIdQuery = @"SELECT avt_id FROM avtorization WHERE avt_name = @Username";
            string username = UserSession.Username;

            using (var connection = new NpgsqlConnection(classPodcluchenieBD.sql))
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

                string zapros = @"SELECT avt_name, exti_extimation, ex_date 
                          FROM extimations, avtorization where exti_name = avt_id 
                          and avt_id = @UserId";

                using (var cmd = new NpgsqlCommand(zapros, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (NpgsqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(dataReader);
                        dataGridView1.DataSource = data;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
