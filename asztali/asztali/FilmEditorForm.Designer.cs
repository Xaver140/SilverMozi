namespace asztali
{
    partial class FilmEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxFilmek = new ListBox();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtDuration = new TextBox();
            label4 = new Label();
            txtReleaseYear = new TextBox();
            label6 = new Label();
            label8 = new Label();
            cmbGenre = new ComboBox();
            chkActive = new CheckBox();
            btnLoadFilms = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // listBoxFilmek
            // 
            listBoxFilmek.FormattingEnabled = true;
            listBoxFilmek.Location = new Point(12, 12);
            listBoxFilmek.Name = "listBoxFilmek";
            listBoxFilmek.Size = new Size(327, 424);
            listBoxFilmek.TabIndex = 0;
            listBoxFilmek.Click += listBoxFilmek_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Film címe";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(508, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(111, 27);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 55);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Leírás";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(508, 55);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(84, 35);
            txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 153);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Játékidő (perc)";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(508, 150);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(49, 27);
            txtDuration.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 189);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 7;
            label4.Text = "Megjelenési év";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(508, 186);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(53, 27);
            txtReleaseYear.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 278);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 7;
            label6.Text = "Műfaj";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 340);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "Aktív";
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(508, 278);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(151, 28);
            cmbGenre.TabIndex = 10;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(508, 340);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(37, 24);
            chkActive.TabIndex = 9;
            chkActive.Text = "-";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnLoadFilms
            // 
            btnLoadFilms.Location = new Point(366, 407);
            btnLoadFilms.Name = "btnLoadFilms";
            btnLoadFilms.Size = new Size(80, 29);
            btnLoadFilms.TabIndex = 11;
            btnLoadFilms.Text = "Betöltés";
            btnLoadFilms.UseVisualStyleBackColor = true;
            btnLoadFilms.Click += btnLoadFilms_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(452, 407);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "Új film";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(625, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(536, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(694, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Vissza";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FilmEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnBack);
            Controls.Add(btnLoadFilms);
            Controls.Add(cmbGenre);
            Controls.Add(chkActive);
            Controls.Add(txtReleaseYear);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtDuration);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(listBoxFilmek);
            Name = "FilmEditorForm";
            Text = "FilmEditorForm";
            Load += FilmEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxFilmek;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtDuration;
        private Label label4;
        private TextBox txtReleaseYear;
        private Label label6;
        private Label label8;
        private ComboBox cmbGenre;
        private CheckBox chkActive;
        private Button btnLoadFilms;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Button btnBack;
    }
}