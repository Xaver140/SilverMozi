using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asztali
{
    public partial class MainForm : Form
    {
        private readonly ApiClient _api;

        private FilmEditorForm filmForm;
        private VetitesForm vetitesForm;
        private FormTerem teremForm;

        public MainForm() : this(new ApiClient("http://localhost:3000"))
        {
        }

        public MainForm(ApiClient api)
        {
            InitializeComponent();
            _api = api;
        }

        private void btnLoadFilmek_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();  // NEM Close!

            var login = new LoginForm();

            // ha a login bezáródik, a main visszajön
            login.FormClosed += (s, args) =>
            {
                this.Show();
            };

            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var f = new DatabaseForm())
            {
                f.ShowDialog();
            }

            this.Show();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFilmEditor_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var f = new FilmEditorForm())
            {
                f.ShowDialog();
            }

            this.Show();
        }

        private void btnVetites_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var f = new VetitesForm())
            {
                f.ShowDialog();
            }

            this.Show();
        }

        private void termekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTerem terem = new FormTerem();
            terem.ShowDialog();
            this.Show();
        }

        private void vetítésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vetitesForm == null || vetitesForm.IsDisposed)
            {
                this.Hide();
                vetitesForm = new VetitesForm();
                vetitesForm.ShowDialog();
                this.Show();
            }
            else
            {
                vetitesForm.Focus();
            }
        }

        private void filmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filmForm == null || filmForm.IsDisposed)
            {
                this.Hide();
                filmForm = new FilmEditorForm();
                filmForm.ShowDialog();
                this.Show();
            }
            else
            {
                filmForm.Focus();
            }
        }
    }

}
