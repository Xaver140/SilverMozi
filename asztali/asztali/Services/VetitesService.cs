using System.Collections.Generic;
using asztali.Models;
using MySql.Data.MySqlClient;

namespace asztali.Services
{
    public class VetitesService
    {
        private readonly Database _database;

        public VetitesService()
        {
            _database = new Database();
        }

        public List<Vetites> GetAllVetitesek()
        {
            List<Vetites> lista = new List<Vetites>();

            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"SELECT vetites_id, film_id, terem_id, start_time, end_time, base_price
                                 FROM vetites
                                 ORDER BY start_time";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Vetites
                            {
                                VetitesId = reader.GetInt32("vetites_id"),
                                FilmId = reader.GetInt32("film_id"),
                                TeremId = reader.GetInt32("terem_id"),
                                StartTime = reader.GetDateTime("start_time"),
                                EndTime = reader.IsDBNull(reader.GetOrdinal("end_time"))
                                    ? null
                                    : reader.GetDateTime("end_time"),
                                BasePrice = reader.GetDecimal("base_price")
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public bool AddVetites(Vetites vetites)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"INSERT INTO vetites (film_id, terem_id, start_time, end_time, base_price)
                                 VALUES (@filmId, @teremId, @startTime, @endTime, @basePrice)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@filmId", vetites.FilmId);
                    cmd.Parameters.AddWithValue("@teremId", vetites.TeremId);
                    cmd.Parameters.AddWithValue("@startTime", vetites.StartTime);
                    cmd.Parameters.AddWithValue("@endTime", vetites.EndTime.HasValue ? vetites.EndTime.Value : (object)System.DBNull.Value);
                    cmd.Parameters.AddWithValue("@basePrice", vetites.BasePrice);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateVetites(Vetites vetites)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"UPDATE vetites
                                 SET film_id = @filmId,
                                     terem_id = @teremId,
                                     start_time = @startTime,
                                     end_time = @endTime,
                                     base_price = @basePrice
                                 WHERE vetites_id = @vetitesId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@filmId", vetites.FilmId);
                    cmd.Parameters.AddWithValue("@teremId", vetites.TeremId);
                    cmd.Parameters.AddWithValue("@startTime", vetites.StartTime);
                    cmd.Parameters.AddWithValue("@endTime", vetites.EndTime.HasValue ? vetites.EndTime.Value : (object)System.DBNull.Value);
                    cmd.Parameters.AddWithValue("@basePrice", vetites.BasePrice);
                    cmd.Parameters.AddWithValue("@vetitesId", vetites.VetitesId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteVetites(int vetitesId)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"DELETE FROM vetites WHERE vetites_id = @vetitesId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vetitesId", vetitesId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}