using System.Collections.Generic;
using asztali.Models;
using MySql.Data.MySqlClient;

namespace asztali.Services
{
    public class TeremService
    {
        private readonly Database _database;

        public TeremService()
        {
            _database = new Database();
        }

        public List<Terem> GetAllTermek()
        {
            List<Terem> lista = new List<Terem>();

            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = "SELECT terem_id, name, total_rows, seats_per_row FROM terem ORDER BY terem_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Terem
                            {
                                TeremId = reader.GetInt32("terem_id"),
                                Name = reader.GetString("name"),
                                TotalRows = reader.GetInt32("total_rows"),
                                SeatsPerRow = reader.GetInt32("seats_per_row")
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}