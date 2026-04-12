using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using asztali.Models;
using asztali.Services;

namespace asztali
{
    public partial class DatabaseForm : Form
    {
        private readonly UserService _userService;
        private BindingList<UserItem> _bindingUsers;
        private List<UserItem> _users;
        private UserItem _selectedUser;

        public DatabaseForm()
        {
            InitializeComponent();

            _userService = new UserService();
            _bindingUsers = new BindingList<UserItem>();
            _users = new List<UserItem>();

            PrepareGrid();
            WireUpEvents();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void WireUpEvents()
        {
            this.Load += DatabaseForm_Load;

            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;

            btnLoad.Click += btnLoad_Click;
            btnNew.Click += btnNew_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;
        }

        private void PrepareGrid()
        {
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.GridColor = Color.LightGray;
            dgvUsers.EnableHeadersVisualStyles = false;

            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvUsers.ColumnHeadersHeight = 36;
            dgvUsers.RowTemplate.Height = 32;
        }

        private void LoadUsers()
        {
            try
            {
                _users = _userService.GetAllUsers();
                _bindingUsers = new BindingList<UserItem>(_users);

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _bindingUsers;

                if (dgvUsers.Columns["UserId"] != null)
                {
                    dgvUsers.Columns["UserId"].HeaderText = "ID";
                    dgvUsers.Columns["UserId"].FillWeight = 20;
                }

                if (dgvUsers.Columns["FullName"] != null)
                {
                    dgvUsers.Columns["FullName"].HeaderText = "Név";
                    dgvUsers.Columns["FullName"].FillWeight = 40;
                }

                if (dgvUsers.Columns["Email"] != null)
                {
                    dgvUsers.Columns["Email"].HeaderText = "Email";
                    dgvUsers.Columns["Email"].FillWeight = 40;
                }

                if (dgvUsers.Columns["PhoneNumber"] != null)
                {
                    dgvUsers.Columns["PhoneNumber"].HeaderText = "Telefonszám";
                    dgvUsers.Columns["PhoneNumber"].FillWeight = 30;
                }

                if (dgvUsers.Rows.Count > 0)
                {
                    dgvUsers.Rows[0].Selected = true;
                    LoadSelectedUserFromGrid();
                }
                else
                {
                    ClearEditor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a felhasználók betöltésekor:\n" + ex.Message,
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedUserFromGrid();
        }

        private void LoadSelectedUserFromGrid()
        {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.DataBoundItem == null)
            {
                _selectedUser = null;
                return;
            }

            _selectedUser = dgvUsers.CurrentRow.DataBoundItem as UserItem;
            if (_selectedUser == null)
                return;

            txtFullName.Text = _selectedUser.FullName;
            txtEmail.Text = _selectedUser.Email;
            txtPhone.Text = _selectedUser.PhoneNumber;
        }

        private void ClearEditor()
        {
            _selectedUser = null;
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("A név megadása kötelező.");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Az email megadása kötelező.");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvUsers.ClearSelection();
            ClearEditor();
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                if (_selectedUser == null)
                {
                    UserItem newUser = new UserItem
                    {
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        PhoneNumber = txtPhone.Text.Trim()
                    };

                    bool added = _userService.AddUser(newUser);

                    if (added)
                    {
                        MessageBox.Show("Új felhasználó sikeresen mentve.");
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("A mentés nem sikerült.");
                    }
                }
                else
                {
                    _selectedUser.FullName = txtFullName.Text.Trim();
                    _selectedUser.Email = txtEmail.Text.Trim();
                    _selectedUser.PhoneNumber = txtPhone.Text.Trim();

                    bool updated = _userService.UpdateUser(_selectedUser);

                    if (updated)
                    {
                        MessageBox.Show("Felhasználó sikeresen frissítve.");
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("A frissítés nem sikerült.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba mentés közben:\n" + ex.Message,
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Előbb válassz ki egy felhasználót.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Biztosan törlöd a kiválasztott felhasználót?",
                "Megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool deleted = _userService.DeleteUser(_selectedUser.UserId);

                if (deleted)
                {
                    MessageBox.Show("Felhasználó sikeresen törölve.");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("A törlés nem sikerült.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba törlés közben:\n" + ex.Message,
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}