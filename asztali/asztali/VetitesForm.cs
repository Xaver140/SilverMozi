using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace asztali
{
    public partial class VetitesForm : Form
    {
        private string cs = "server=localhost;uid=root;database=mozi_adat;port=3306;pwd=;";
        private int? selectedVetitesId = null;

        public VetitesForm()
        {
            InitializeComponent();

            listBoxVetitesek.SelectedIndexChanged += listBoxVetitesek_SelectedIndexChanged;
            btnLoad.Click += btnLoad_Click;
            btnNew.Click += btnNew_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dtStart.ShowUpDown = true;

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            dtEnd.ShowUpDown = true;
        }

        private void VetitesForm_Load(object sender, EventArgs e)
        {
            LoadFilms();
            LoadTermek();
            ClearForm();
        }

        private void LoadFilms()
        {
            cmbFilm.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = "SELECT film_id, title FROM filmek WHERE is_active = 1 ORDER BY title";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFilm.Items.Add(new ComboItem(
                                Convert.ToInt32(reader["film_id"]),
                                reader["title"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filmek betöltése hiba: " + ex.Message);
            }
        }

        private void LoadTermek()
        {
            cmbTerem.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = "SELECT terem_id FROM terem ORDER BY terem_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTerem.Items.Add(new ComboItem(
                                Convert.ToInt32(reader["terem_id"]),
                                "Terem " + reader["terem_id"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Termek betöltése hiba: " + ex.Message);
            }
        }

        private void LoadVetitesek()
        {
            listBoxVetitesek.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                        SELECT v.vetites_id, v.film_id, f.title, v.terem_id, v.start_time, v.end_time, v.base_price
                        FROM vetites v
                        INNER JOIN filmek f ON v.film_id = f.film_id
                        ORDER BY v.start_time";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int vetitesId = Convert.ToInt32(reader["vetites_id"]);
                            string title = reader["title"].ToString();
                            int teremId = Convert.ToInt32(reader["terem_id"]);
                            DateTime start = Convert.ToDateTime(reader["start_time"]);

                            listBoxVetitesek.Items.Add(
                                new VetitesListItem(
                                    vetitesId,
                                    $"{title} | Terem {teremId} | {start:yyyy-MM-dd HH:mm}"
                                )
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vetítések betöltése hiba: " + ex.Message);
            }
        }

        private void listBoxVetitesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVetitesek.SelectedItem == null)
                return;

            VetitesListItem item = listBoxVetitesek.SelectedItem as VetitesListItem;
            if (item == null)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                        SELECT vetites_id, film_id, terem_id, start_time, end_time, base_price
                        FROM vetites
                        WHERE vetites_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", item.Id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                selectedVetitesId = Convert.ToInt32(reader["vetites_id"]);
                                int filmId = Convert.ToInt32(reader["film_id"]);
                                int teremId = Convert.ToInt32(reader["terem_id"]);

                                SelectComboItemByValue(cmbFilm, filmId);
                                SelectComboItemByValue(cmbTerem, teremId);

                                dtStart.Value = Convert.ToDateTime(reader["start_time"]);
                                dtEnd.Value = Convert.ToDateTime(reader["end_time"]);
                                txtPrice.Text = Convert.ToDecimal(reader["base_price"]).ToString("0.##");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vetítés betöltése hiba: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadVetitesek();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFilm.SelectedItem == null)
                {
                    MessageBox.Show("Válassz filmet!");
                    return;
                }

                if (cmbTerem.SelectedItem == null)
                {
                    MessageBox.Show("Válassz termet!");
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price) &&
                    !decimal.TryParse(txtPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Az ár szám legyen!");
                    return;
                }

                DateTime start = dtStart.Value;
                DateTime end = dtEnd.Value;

                if (start >= end)
                {
                    MessageBox.Show("A kezdési idő nem lehet későbbi vagy egyenlő a befejezéssel.");
                    return;
                }

                ComboItem filmItem = cmbFilm.SelectedItem as ComboItem;
                ComboItem teremItem = cmbTerem.SelectedItem as ComboItem;

                int filmId = filmItem.Value;
                int teremId = teremItem.Value;

                if (HasRoomConflict(teremId, start, end, selectedVetitesId))
                {
                    MessageBox.Show("Ebben a teremben már van másik vetítés ebben az időszakban.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    MySqlCommand cmd;

                    if (selectedVetitesId == null)
                    {
                        string insertSql = @"
                            INSERT INTO vetites(film_id, terem_id, start_time, end_time, base_price)
                            VALUES(@film, @terem, @start, @end, @price)";

                        cmd = new MySqlCommand(insertSql, conn);
                    }
                    else
                    {
                        string updateSql = @"
                            UPDATE vetites
                            SET film_id = @film,
                                terem_id = @terem,
                                start_time = @start,
                                end_time = @end,
                                base_price = @price
                            WHERE vetites_id = @id";

                        cmd = new MySqlCommand(updateSql, conn);
                        cmd.Parameters.AddWithValue("@id", selectedVetitesId.Value);
                    }

                    cmd.Parameters.AddWithValue("@film", filmId);
                    cmd.Parameters.AddWithValue("@terem", teremId);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@price", price);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Mentés kész! Érintett sorok: " + rows);
                }

                ClearForm();
                LoadVetitesek();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mentési hiba: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedVetitesId == null)
            {
                MessageBox.Show("Nincs kiválasztott vetítés!");
                return;
            }

            var ok = MessageBox.Show("Biztosan törlöd ezt a vetítést?", "Törlés", MessageBoxButtons.YesNo);
            if (ok != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = "DELETE FROM vetites WHERE vetites_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedVetitesId.Value);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show("Törölt sorok: " + rows);
                    }
                }

                ClearForm();
                LoadVetitesek();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Törlés hiba: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            selectedVetitesId = null;

            listBoxVetitesek.ClearSelected();
            cmbFilm.SelectedIndex = -1;
            cmbTerem.SelectedIndex = -1;
            txtPrice.Text = "";

            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now.AddHours(2);
        }

        private bool HasRoomConflict(int teremId, DateTime start, DateTime end, int? currentVetitesId)
        {
            using (MySqlConnection conn = new MySqlConnection(cs))
            {
                conn.Open();

                string sql = @"
                    SELECT COUNT(*)
                    FROM vetites
                    WHERE terem_id = @terem
                      AND (@currentId IS NULL OR vetites_id <> @currentId)
                      AND (
                            (@start < end_time AND @end > start_time)
                          )";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@terem", teremId);
                    cmd.Parameters.AddWithValue("@currentId", currentVetitesId.HasValue ? (object)currentVetitesId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void SelectComboItemByValue(ComboBox comboBox, int value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                ComboItem item = comboBox.Items[i] as ComboItem;
                if (item != null && item.Value == value)
                {
                    comboBox.SelectedIndex = i;
                    return;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxVetitesek_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    public class ComboItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ComboItem(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    public class VetitesListItem
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public VetitesListItem(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
