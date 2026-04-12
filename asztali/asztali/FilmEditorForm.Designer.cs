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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEditorForm));
            pbFilmImage = new PictureBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblGenre = new Label();
            lblDuration = new Label();
            lblReleaseYear = new Label();
            lblAgeLimit = new Label();
            lblDirector = new Label();
            lblProducer = new Label();
            txtDirector = new TextBox();
            txtProducer = new TextBox();
            lblIsActive = new Label();
            cmbGenre = new ComboBox();
            numDuration = new NumericUpDown();
            numReleaseYear = new NumericUpDown();
            cmbAgeLimit = new ComboBox();
            lblActors = new Label();
            chkIsActive = new CheckBox();
            rtbActors = new RichTextBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lstFilmek = new ListBox();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFilmImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).BeginInit();
            SuspendLayout();
            // 
            // pbFilmImage
            // 
            pbFilmImage.BorderStyle = BorderStyle.FixedSingle;
            pbFilmImage.Location = new Point(417, 20);
            pbFilmImage.Name = "pbFilmImage";
            pbFilmImage.Size = new Size(371, 184);
            pbFilmImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbFilmImage.TabIndex = 1;
            pbFilmImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 215);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Cím:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(99, 212);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(135, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(12, 262);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(50, 20);
            lblGenre.TabIndex = 4;
            lblGenre.Text = "Műfaj:";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(12, 311);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Játékidő:";
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(12, 360);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(83, 20);
            lblReleaseYear.TabIndex = 4;
            lblReleaseYear.Text = "Kiadás éve:";
            // 
            // lblAgeLimit
            // 
            lblAgeLimit.AutoSize = true;
            lblAgeLimit.Location = new Point(296, 215);
            lblAgeLimit.Name = "lblAgeLimit";
            lblAgeLimit.Size = new Size(69, 20);
            lblAgeLimit.TabIndex = 2;
            lblAgeLimit.Text = "Korhatár:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(296, 262);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(70, 20);
            lblDirector.TabIndex = 2;
            lblDirector.Text = "Rendező:";
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Location = new Point(296, 311);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(71, 20);
            lblProducer.TabIndex = 2;
            lblProducer.Text = "Producer:";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(386, 259);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(137, 27);
            txtDirector.TabIndex = 3;
            // 
            // txtProducer
            // 
            txtProducer.Location = new Point(386, 308);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new Size(137, 27);
            txtProducer.TabIndex = 3;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(296, 360);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(45, 20);
            lblIsActive.TabIndex = 2;
            lblIsActive.Text = "Aktív:";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(99, 259);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(135, 28);
            cmbGenre.TabIndex = 5;
            // 
            // numDuration
            // 
            numDuration.Location = new Point(99, 309);
            numDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(135, 27);
            numDuration.TabIndex = 6;
            numDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numReleaseYear
            // 
            numReleaseYear.Location = new Point(99, 358);
            numReleaseYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numReleaseYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numReleaseYear.Name = "numReleaseYear";
            numReleaseYear.Size = new Size(135, 27);
            numReleaseYear.TabIndex = 6;
            numReleaseYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // cmbAgeLimit
            // 
            cmbAgeLimit.FormattingEnabled = true;
            cmbAgeLimit.Location = new Point(386, 211);
            cmbAgeLimit.Name = "cmbAgeLimit";
            cmbAgeLimit.Size = new Size(137, 28);
            cmbAgeLimit.TabIndex = 7;
            // 
            // lblActors
            // 
            lblActors.AutoSize = true;
            lblActors.Location = new Point(571, 215);
            lblActors.Name = "lblActors";
            lblActors.Size = new Size(75, 20);
            lblActors.TabIndex = 2;
            lblActors.Text = "Színészek:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(386, 359);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(37, 24);
            chkIsActive.TabIndex = 8;
            chkIsActive.Text = "-";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // rtbActors
            // 
            rtbActors.Location = new Point(652, 212);
            rtbActors.Name = "rtbActors";
            rtbActors.Size = new Size(136, 75);
            rtbActors.TabIndex = 9;
            rtbActors.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(571, 311);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Leírás:";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(652, 308);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbDescription.Size = new Size(136, 77);
            rtbDescription.TabIndex = 9;
            rtbDescription.Text = "";
            // 
            // lstFilmek
            // 
            lstFilmek.FormattingEnabled = true;
            lstFilmek.Location = new Point(12, 20);
            lstFilmek.Name = "lstFilmek";
            lstFilmek.Size = new Size(399, 184);
            lstFilmek.TabIndex = 10;
            lstFilmek.Click += lstFilmek_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(434, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 57);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(619, 391);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(133, 57);
            btnNew.TabIndex = 11;
            btnNew.Text = "Új film";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(243, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 57);
            btnSave.TabIndex = 11;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.left;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(48, 391);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 57);
            btnClose.TabIndex = 11;
            btnClose.Text = "Vissza";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FilmEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(lstFilmek);
            Controls.Add(rtbDescription);
            Controls.Add(rtbActors);
            Controls.Add(chkIsActive);
            Controls.Add(cmbAgeLimit);
            Controls.Add(numReleaseYear);
            Controls.Add(numDuration);
            Controls.Add(cmbGenre);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblDuration);
            Controls.Add(lblGenre);
            Controls.Add(txtProducer);
            Controls.Add(txtDirector);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblActors);
            Controls.Add(lblIsActive);
            Controls.Add(lblProducer);
            Controls.Add(lblDirector);
            Controls.Add(lblAgeLimit);
            Controls.Add(lblTitle);
            Controls.Add(pbFilmImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilmEditorForm";
            Text = "Filmek";
            ((System.ComponentModel.ISupportInitialize)pbFilmImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pbFilmImage;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblGenre;
        private Label lblDuration;
        private Label lblReleaseYear;
        private Label lblAgeLimit;
        private Label lblDirector;
        private Label lblProducer;
        private TextBox txtDirector;
        private TextBox txtProducer;
        private Label lblIsActive;
        private ComboBox cmbGenre;
        private NumericUpDown numDuration;
        private NumericUpDown numReleaseYear;
        private ComboBox cmbAgeLimit;
        private Label lblActors;
        private CheckBox chkIsActive;
        private RichTextBox rtbActors;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private ListBox lstFilmek;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private Button btnClose;
    }
}