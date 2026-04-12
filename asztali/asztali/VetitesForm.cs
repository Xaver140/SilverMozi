using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using asztali.Models;
using asztali.Services;

namespace asztali
{
    public partial class VetitesForm : Form
    {
        private readonly VetitesService _vetitesService;
        private readonly FilmService _filmService;
        private readonly TeremService _teremService;

        private List<Vetites> _vetitesek;
        private List<Film> _filmek;
        private List<Terem> _termek;

        private bool _isLoadingFormData;

        public VetitesForm()
        {
            InitializeComponent();

            _vetitesService = new VetitesService();
            _filmService = new FilmService();
            _teremService = new TeremService();

            _vetitesek = new List<Vetites>();
            _filmek = new List<Film>();
            _termek = new List<Terem>();

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "yyyy.MM.dd HH:mm";

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "yyyy.MM.dd HH:mm";
            dtEnd.Enabled = false;

            WireUpEvents();
            ImproveExistingLayout();
        }

        private void VetitesForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void WireUpEvents()
        {
            Load += VetitesForm_Load;

            listBoxVetitesek.SelectedIndexChanged += listBoxVetitesek_SelectedIndexChanged;

            btnLoad.Click += btnLoad_Click;
            btnNew.Click += btnNew_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;

            cmbFilm.SelectedIndexChanged += cmbFilm_SelectedIndexChanged;
            dtStart.ValueChanged += dtStart_ValueChanged;
        }

        private void ImproveExistingLayout()
        {
            Text = "Vetítések";
            StartPosition = FormStartPosition.CenterScreen;

            groupBox1.Text = "Vetítések kezelése";
            groupBox1.Padding = new Padding(10);

            listBoxVetitesek.Font = new System.Drawing.Font("Segoe UI", 10F);
            listBoxVetitesek.IntegralHeight = false;

            label1.Text = "Film:";
            label2.Text = "Terem:";
            label3.Text = "Kezdés:";
            label4.Text = "Befejezés:";
            label5.Text = "Alapár:";

            cmbFilm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTerem.DropDownStyle = ComboBoxStyle.DropDownList;

            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "yyyy.MM.dd HH:mm";

            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.CustomFormat = "yyyy.MM.dd HH:mm";
        }

        private void LoadAllData()
        {
            try
            {
                _isLoadingFormData = true;

                _filmek = _filmService.GetAllFilmek();
                _termek = _teremService.GetAllTermek();
                _vetitesek = _vetitesService.GetAllVetitesek();
                
                FillFilmCombo();
                FillTeremCombo();
                FillVetitesList();

                if (listBoxVetitesek.Items.Count > 0)
                {
                    listBoxVetitesek.SelectedIndex = 0;
                }
                else
                {
                    PrepareNewRecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a vetítések betöltésekor:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isLoadingFormData = false;
            }
        }

        private void FillFilmCombo()
        {
            cmbFilm.DataSource = null;

            var items = _filmek
                .OrderBy(f => f.Title)
                .Select(f => new ComboItem
                {
                    Id = f.FilmId,
                    Name = f.Title
                })
                .ToList();

            cmbFilm.DataSource = items;
            cmbFilm.DisplayMember = "Name";
            cmbFilm.ValueMember = "Id";
        }

        private void FillTeremCombo()
        {
            cmbTerem.DataSource = null;

            var items = _termek
                .OrderBy(t => t.Name)
                .Select(t => new ComboItem
                {
                    Id = t.TeremId,
                    Name = t.Name
                })
                .ToList();

            cmbTerem.DataSource = items;
            cmbTerem.DisplayMember = "Name";
            cmbTerem.ValueMember = "Id";
        }

        private void FillVetitesList()
        {
            listBoxVetitesek.Items.Clear();

            foreach (var vetites in _vetitesek.OrderBy(v => v.StartTime))
            {
                Film film = _filmek.FirstOrDefault(f => f.FilmId == vetites.FilmId);
                Terem terem = _termek.FirstOrDefault(t => t.TeremId == vetites.TeremId);

                string filmTitle = film != null ? film.Title : $"Film #{vetites.FilmId}";
                string teremName = terem != null ? terem.Name : $"Terem #{vetites.TeremId}";

                listBoxVetitesek.Items.Add(new VetitesListItemDisplay
                {
                    VetitesId = vetites.VetitesId,
                    DisplayText = $"{vetites.StartTime:MM.dd HH:mm} | {filmTitle} | {teremName}"
                });
            }
        }

        private void listBoxVetitesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingFormData)
                return;

            if (listBoxVetitesek.SelectedItem is not VetitesListItemDisplay selected)
                return;

            Vetites vetites = _vetitesek.FirstOrDefault(v => v.VetitesId == selected.VetitesId);
            if (vetites == null)
                return;

            LoadVetitesIntoForm(vetites);
        }

        private void LoadVetitesIntoForm(Vetites vetites)
        {
            _isLoadingFormData = true;

            try
            {
                cmbFilm.SelectedValue = vetites.FilmId;
                cmbTerem.SelectedValue = vetites.TeremId;
                dtStart.Value = vetites.StartTime;
                dtEnd.Value = vetites.EndTime ?? vetites.StartTime;
                txtPrice.Text = vetites.BasePrice.ToString("0.##", CultureInfo.CurrentCulture);
            }
            finally
            {
                _isLoadingFormData = false;
            }
        }

        private void PrepareNewRecord()
        {
            _isLoadingFormData = true;

            try
            {
                listBoxVetitesek.ClearSelected();

                if (cmbFilm.Items.Count > 0)
                    cmbFilm.SelectedIndex = 0;

                if (cmbTerem.Items.Count > 0)
                    cmbTerem.SelectedIndex = 0;

                dtStart.Value = DateTime.Now.AddMinutes(30);


                txtPrice.Text = "2500";

                CalculateEndTime();
            }
            finally
            {
                _isLoadingFormData = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PrepareNewRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFilm.SelectedValue == null)
                {
                    MessageBox.Show("Válassz filmet.");
                    return;
                }

                if (cmbTerem.SelectedValue == null)
                {
                    MessageBox.Show("Válassz termet.");
                    return;
                }

                if (!TryParsePrice(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Az alapár nem megfelelő.");
                    return;
                }

                Vetites vetites = new Vetites
                {
                    FilmId = Convert.ToInt32(cmbFilm.SelectedValue),
                    TeremId = Convert.ToInt32(cmbTerem.SelectedValue),
                    StartTime = dtStart.Value,
                    EndTime = dtEnd.Value,
                    BasePrice = price
                };

                bool success;

                if (listBoxVetitesek.SelectedItem is VetitesListItemDisplay selected)
                {
                    vetites.VetitesId = selected.VetitesId;
                    success = _vetitesService.UpdateVetites(vetites);
                }
                else
                {
                    success = _vetitesService.AddVetites(vetites);
                }

                if (success)
                {
                    MessageBox.Show("Mentés sikeres.");
                    LoadAllData();
                }
                else
                {
                    MessageBox.Show("A mentés nem sikerült.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba mentés közben:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVetitesek.SelectedItem is not VetitesListItemDisplay selected)
                {
                    MessageBox.Show("Nincs kiválasztott vetítés.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Biztosan törlöd a kiválasztott vetítést?",
                    "Megerősítés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                bool success = _vetitesService.DeleteVetites(selected.VetitesId);

                if (success)
                {
                    MessageBox.Show("Törlés sikeres.");
                    LoadAllData();
                }
                else
                {
                    MessageBox.Show("A törlés nem sikerült.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba törlés közben:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingFormData)
                return;

            CalculateEndTime();
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            if (_isLoadingFormData)
                return;

            CalculateEndTime();
        }



        private void CalculateEndTime()
        {
            if (cmbFilm.SelectedValue == null)
                return;

            int filmId = Convert.ToInt32(cmbFilm.SelectedValue);

            Film selectedFilm = _filmek.FirstOrDefault(f => f.FilmId == filmId);
            if (selectedFilm == null)
                return;

            dtEnd.Value = dtStart.Value.AddMinutes(selectedFilm.DurationMinutes);
        }

        private Film GetSelectedFilm()
        {
            if (cmbFilm.SelectedValue == null)
                return null;

            int filmId = Convert.ToInt32(cmbFilm.SelectedValue);
            return _filmek.FirstOrDefault(f => f.FilmId == filmId);
        }

        private bool TryParsePrice(string text, out decimal price)
        {
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out price))
                return true;

            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out price))
                return true;

            text = text.Replace("Ft", "", StringComparison.OrdinalIgnoreCase).Trim();

            return decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out price)
                   || decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out price);
        }

        private class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private class VetitesListItemDisplay
        {
            public int VetitesId { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}