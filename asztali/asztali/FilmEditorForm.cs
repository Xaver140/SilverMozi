using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using asztali.Models;
using asztali.Services;

namespace asztali
{
    public partial class FilmEditorForm : Form
    {
        private readonly FilmService _filmService;
        private List<Film> _filmek;
        private Film _selectedFilm;

        public FilmEditorForm()
        {
            InitializeComponent();

            _filmService = new FilmService();
            _filmek = new List<Film>();

            PrepareControls();

            this.Load += FilmEditorForm_Load;
        }

        private void FilmEditorForm_Load(object sender, EventArgs e)
        {
            LoadGenreCombo();
            LoadAgeLimitCombo();
            LoadFilmek();
        }

        private void PrepareControls()
        {
            pbFilmImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbFilmImage.BorderStyle = BorderStyle.FixedSingle;

            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgeLimit.DropDownStyle = ComboBoxStyle.DropDownList;

            numDuration.Minimum = 1;
            numDuration.Maximum = 500;

            numReleaseYear.Minimum = 1900;
            numReleaseYear.Maximum = 2100;

            rtbActors.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
        }

        private void LoadGenreCombo()
        {
            cmbGenre.Items.Clear();
            cmbGenre.Items.AddRange(new object[]
            {
                "Akció",
                "Dráma",
                "Fantasy",
                "Sci-Fi",
                "Romantikus",
                "Történelmi",
                "Vígjáték",
                "Thriller",
                "Animációs",
                "Horror",
                "Kaland"
            });
        }

        private void LoadAgeLimitCombo()
        {
            cmbAgeLimit.Items.Clear();
            cmbAgeLimit.Items.Add("");
            cmbAgeLimit.Items.Add("0+");
            cmbAgeLimit.Items.Add("6+");
            cmbAgeLimit.Items.Add("12+");
            cmbAgeLimit.Items.Add("16+");
            cmbAgeLimit.Items.Add("18+");
        }

        private void LoadFilmek()
        {
            try
            {
                lstFilmek.Items.Clear();
                _filmek = _filmService.GetAllFilmek();

                foreach (Film film in _filmek)
                {
                    lstFilmek.Items.Add(film);
                }

                if (lstFilmek.Items.Count > 0)
                {
                    lstFilmek.SelectedIndex = 0;
                }
                else
                {
                    ClearFilmDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a filmek betöltésekor:\n" + ex.Message);
            }
        }

        private void lstFilmek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmek.SelectedItem is Film film)
            {
                _selectedFilm = film;
                ShowFilmDetails(film);
            }
            else
            {
                _selectedFilm = null;
                ClearFilmDetails();
            }
        }

        private void ShowFilmDetails(Film film)
        {
            txtTitle.Text = film.Title ?? "";

            if (!string.IsNullOrWhiteSpace(film.Genre) && cmbGenre.Items.Contains(film.Genre))
                cmbGenre.SelectedItem = film.Genre;
            else
                cmbGenre.Text = film.Genre ?? "";

            numDuration.Value = film.DurationMinutes > 0 ? film.DurationMinutes : 1;

            if (film.ReleaseYear.HasValue && film.ReleaseYear.Value >= numReleaseYear.Minimum && film.ReleaseYear.Value <= numReleaseYear.Maximum)
                numReleaseYear.Value = film.ReleaseYear.Value;
            else
                numReleaseYear.Value = numReleaseYear.Minimum;

            string ageText = film.AgeLimit.HasValue ? film.AgeLimit.Value + "+" : "";
            if (cmbAgeLimit.Items.Contains(ageText))
                cmbAgeLimit.SelectedItem = ageText;
            else
                cmbAgeLimit.SelectedIndex = 0;

            txtDirector.Text = film.Director ?? "";
            txtProducer.Text = film.Producer ?? "";
            chkIsActive.Checked = film.IsActive;

            rtbActors.Text = film.Actors ?? "";
            rtbDescription.Text = film.Description ?? "";

            LoadFilmImage(film.FilmImg);
        }

        private void ClearFilmDetails()
        {
            txtTitle.Text = "";
            cmbGenre.SelectedIndex = -1;
            numDuration.Value = numDuration.Minimum;
            numReleaseYear.Value = numReleaseYear.Minimum;
            cmbAgeLimit.SelectedIndex = 0;
            txtDirector.Text = "";
            txtProducer.Text = "";
            chkIsActive.Checked = false;
            rtbActors.Text = "";
            rtbDescription.Text = "";
            pbFilmImage.Image = null;
        }

        private void LoadFilmImage(string fileName)
        {
            try
            {
                pbFilmImage.Image = null;

                if (string.IsNullOrWhiteSpace(fileName))
                    return;

                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", fileName);

                if (!File.Exists(imagePath))
                    return;

                using (Image tempImage = Image.FromFile(imagePath))
                {
                    pbFilmImage.Image = new Bitmap(tempImage);
                }
            }
            catch
            {
                pbFilmImage.Image = null;
            }
        }

        private int? GetSelectedAgeLimit()
        {
            if (cmbAgeLimit.SelectedItem == null)
                return null;

            string text = cmbAgeLimit.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(text))
                return null;

            text = text.Replace("+", "");

            if (int.TryParse(text, out int value))
                return value;

            return null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedFilm = null;
            lstFilmek.ClearSelected();
            ClearFilmDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedFilm == null)
            {
                MessageBox.Show("Előbb válassz ki egy filmet a listából.");
                return;
            }

            try
            {
                _selectedFilm.Title = txtTitle.Text.Trim();
                _selectedFilm.Genre = cmbGenre.SelectedItem?.ToString() ?? "";
                _selectedFilm.DurationMinutes = (int)numDuration.Value;
                _selectedFilm.ReleaseYear = (int)numReleaseYear.Value;
                _selectedFilm.AgeLimit = GetSelectedAgeLimit();
                _selectedFilm.Director = txtDirector.Text.Trim();
                _selectedFilm.Producer = txtProducer.Text.Trim();
                _selectedFilm.IsActive = chkIsActive.Checked;
                _selectedFilm.Actors = rtbActors.Text.Trim();
                _selectedFilm.Description = rtbDescription.Text.Trim();

                bool success = _filmService.UpdateFilm(_selectedFilm);

                if (success)
                {
                    MessageBox.Show("Mentés sikeres.");
                    LoadFilmek();
                }
                else
                {
                    MessageBox.Show("A mentés nem sikerült.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba mentés közben:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedFilm == null)
            {
                MessageBox.Show("Előbb válassz ki egy filmet a listából.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Biztosan törlöd a kiválasztott filmet?",
                "Megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool success = _filmService.DeleteFilm(_selectedFilm.FilmId);

                if (success)
                {
                    MessageBox.Show("Törlés sikeres.");
                    _selectedFilm = null;
                    LoadFilmek();
                }
                else
                {
                    MessageBox.Show("A törlés nem sikerült.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba törlés közben:\n" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}