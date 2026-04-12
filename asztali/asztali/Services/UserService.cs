using System.Collections.Generic;
using asztali.Models;
using MySql.Data.MySqlClient;

namespace asztali.Services
{
    public class UserService
    {
        private readonly Database _database;

        public UserService()
        {
            _database = new Database();
        }

        public List<UserItem> GetAllUsers()
        {
            List<UserItem> users = new List<UserItem>();

            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"SELECT user_id, full_name, email, phone_number
                                 FROM users
                                 ORDER BY user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new UserItem
                            {
                                UserId = reader.GetInt32("user_id"),
                                FullName = reader.GetString("full_name"),
                                Email = reader.GetString("email"),
                                PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phone_number"))
                                    ? ""
                                    : reader.GetString("phone_number")
                            });
                        }
                    }
                }
            }

            return users;
        }

        public bool AddUser(UserItem user)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"INSERT INTO users (full_name, email, phone_number, password_hash, is_admin)
                                 VALUES (@full_name, @email, @phone_number, @password_hash, @is_admin)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full_name", user.FullName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone_number",
                        string.IsNullOrWhiteSpace(user.PhoneNumber) ? (object)System.DBNull.Value : user.PhoneNumber);

                    cmd.Parameters.AddWithValue("@password_hash", "temporary_hash");
                    cmd.Parameters.AddWithValue("@is_admin", 0);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateUser(UserItem user)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"UPDATE users
                                 SET full_name = @full_name,
                                     email = @email,
                                     phone_number = @phone_number
                                 WHERE user_id = @user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", user.UserId);
                    cmd.Parameters.AddWithValue("@full_name", user.FullName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone_number",
                        string.IsNullOrWhiteSpace(user.PhoneNumber) ? (object)System.DBNull.Value : user.PhoneNumber);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteUser(int userId)
        {
            using (MySqlConnection conn = _database.GetConnection())
            {
                string query = @"DELETE FROM users WHERE user_id = @user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}