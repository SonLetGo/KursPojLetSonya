using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace KursPojLetSonya
{
    internal class ClassPodcluchenieBD
    {
        public readonly string sql = "Host=localhost;Username=postgres;Password=12345;Database=KursDBLetSon";

        public NpgsqlConnection GetSqlConnection()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sql);
            sqlConnection.Open();
            return sqlConnection;
        }

        public void SqlConnection(string query)
        {
            using (var connection = GetSqlConnection())
            {
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(datareader);
                        
                    }
                }
            }
        }

        public void Command(string zapros)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sql);
            sqlConnection.Open();
            using (var cmd = new NpgsqlCommand(zapros, sqlConnection))
            {
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

    }
}
