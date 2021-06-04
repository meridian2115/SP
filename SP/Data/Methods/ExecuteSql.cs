using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Methods
{
    class ExecuteSql
    {
        public static NpgsqlDataReader selectSql(string sql)
        {
            string connectionString = $"Server={Properties.Settings.Default.serverName};Port={Properties.Settings.Default.serverPort};User Id={Properties.Settings.Default.dbUser};Password={Properties.Settings.Default.dbPassword};Database={Properties.Settings.Default.dbName};";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            try
            {
                npgSqlConnection.Open();
                //MessageBox.Show("Соединение с БД установлено");
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(sql, npgSqlConnection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
                return npgSqlDataReader;
            }
            catch (Exception ex)
            {
                NpgsqlDataReader npgSqlDataReader = null;
                return npgSqlDataReader;
                //Заглушка
            }
        }
    }
}
