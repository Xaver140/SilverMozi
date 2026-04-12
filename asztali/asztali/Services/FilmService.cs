using System.Collections.Generic;
using asztali.Models;
using MySql.Data.MySqlClient;

namespace asztali.Services
{
    public class FilmService
    {
        private readonly Database _database;

        public FilmService()
        {
            _database = new Database();
        }

        public List<Film> GetAllFilmek()
        {
            List<Film> filmek = new List<Film>();

            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"SELECT film_id, title, description, duration_minutes, release_year,
                                        genre, film_img, is_active, director, actors, producer, age_limit
                                 FROM filmek
                                 ORDER BY film_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filmek.Add(new Film
                            {
                                FilmId = reader.GetInt32("film_id"),
                                Title = reader.GetString("title"),
                                Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description"),
                                DurationMinutes = reader.GetInt32("duration_minutes"),
                                ReleaseYear = reader.IsDBNull(reader.GetOrdinal("release_year")) ? null : reader.GetInt32("release_year"),
                                Genre = reader.IsDBNull(reader.GetOrdinal("genre")) ? "" : reader.GetString("genre"),
                                FilmImg = reader.IsDBNull(reader.GetOrdinal("film_img")) ? "" : reader.GetString("film_img"),
                                IsActive = reader.GetBoolean("is_active"),
                                Director = reader.IsDBNull(reader.GetOrdinal("director")) ? "" : reader.GetString("director"),
                                Actors = reader.IsDBNull(reader.GetOrdinal("actors")) ? "" : reader.GetString("actors"),
                                Producer = reader.IsDBNull(reader.GetOrdinal("producer")) ? "" : reader.GetString("producer"),
                                AgeLimit = reader.IsDBNull(reader.GetOrdinal("age_limit")) ? null : reader.GetInt32("age_limit")
                            });
                        }
                    }
                }
            }

            return filmek;
        }

        public bool UpdateFilm(Film film)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"UPDATE filmek
                                 SET title = @title,
                                     description = @description,
                                     duration_minutes = @duration_minutes,
                                     release_year = @release_year,
                                     genre = @genre,
                                     film_img = @film_img,
                                     is_active = @is_active,
                                     director = @director,
                                     actors = @actors,
                                     producer = @producer,
                                     age_limit = @age_limit
                                 WHERE film_id = @film_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@film_id", film.FilmId);
                    cmd.Parameters.AddWithValue("@title", film.Title);
                    cmd.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(film.Description) ? (object)System.DBNull.Value : film.Description);
                    cmd.Parameters.AddWithValue("@duration_minutes", film.DurationMinutes);
                    cmd.Parameters.AddWithValue("@release_year", film.ReleaseYear.HasValue ? film.ReleaseYear.Value : (object)System.DBNull.Value);
                    cmd.Parameters.AddWithValue("@genre", string.IsNullOrWhiteSpace(film.Genre) ? (object)System.DBNull.Value : film.Genre);
                    cmd.Parameters.AddWithValue("@film_img", string.IsNullOrWhiteSpace(film.FilmImg) ? "" : film.FilmImg);
                    cmd.Parameters.AddWithValue("@is_active", film.IsActive);
                    cmd.Parameters.AddWithValue("@director", string.IsNullOrWhiteSpace(film.Director) ? (object)System.DBNull.Value : film.Director);
                    cmd.Parameters.AddWithValue("@actors", string.IsNullOrWhiteSpace(film.Actors) ? (object)System.DBNull.Value : film.Actors);
                    cmd.Parameters.AddWithValue("@producer", string.IsNullOrWhiteSpace(film.Producer) ? (object)System.DBNull.Value : film.Producer);
                    cmd.Parameters.AddWithValue("@age_limit", film.AgeLimit.HasValue ? film.AgeLimit.Value : (object)System.DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteFilm(int filmId)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = "DELETE FROM filmek WHERE film_id = @film_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@film_id", filmId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}