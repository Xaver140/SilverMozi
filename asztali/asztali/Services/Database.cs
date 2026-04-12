using MySql.Data.MySqlClient;

namespace asztali.Services
{
    public class Database
    {
        private readonly string _connectionString;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                UserID = "root",
                Password = "",
                Database = "mozi_adat",
                CharacterSet = "utf8mb4"
            };

            _connectionString = builder.ConnectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}