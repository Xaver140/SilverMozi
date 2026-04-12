namespace asztali
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            splitMain = new SplitContainer();
            dgvUsers = new DataGridView();
            flowButtons = new FlowLayoutPanel();
            btnBack = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            tblEditor = new TableLayoutPanel();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            flowButtons.SuspendLayout();
            tblEditor.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(dgvUsers);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(flowButtons);
            splitMain.Panel2.Controls.Add(tblEditor);
            splitMain.Size = new Size(982, 553);
            splitMain.SplitterDistance = 600;
            splitMain.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(600, 553);
            dgvUsers.TabIndex = 0;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnBack);
            flowButtons.Controls.Add(btnLoad);
            flowButtons.Controls.Add(btnNew);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Location = new Point(20, 220);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(346, 100);
            flowButtons.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.left;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 97);
            btnBack.TabIndex = 0;
            btnBack.Text = "Vissza";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(70, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(71, 97);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Betöltés";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(147, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(50, 97);
            btnNew.TabIndex = 0;
            btnNew.Text = "Új";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(203, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 97);
            btnSave.TabIndex = 0;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 97);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblEditor
            // 
            tblEditor.ColumnCount = 2;
            tblEditor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.81503F));
            tblEditor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.1849747F));
            tblEditor.Controls.Add(lblFullName, 0, 0);
            tblEditor.Controls.Add(lblEmail, 0, 1);
            tblEditor.Controls.Add(lblPhone, 0, 2);
            tblEditor.Controls.Add(txtFullName, 1, 0);
            tblEditor.Controls.Add(txtEmail, 1, 1);
            tblEditor.Controls.Add(txtPhone, 1, 2);
            tblEditor.Location = new Point(20, 20);
            tblEditor.Name = "tblEditor";
            tblEditor.RowCount = 3;
            tblEditor.RowStyles.Add(new RowStyle(SizeType.Percent, 60.82474F));
            tblEditor.RowStyles.Add(new RowStyle(SizeType.Percent, 39.17526F));
            tblEditor.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblEditor.Size = new Size(346, 170);
            tblEditor.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(3, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(38, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Név:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 97);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(95, 20);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Telefonszám:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(219, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(219, 27);
            txtPhone.TabIndex = 1;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(splitMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Felhasználókezelés";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            flowButtons.ResumeLayout(false);
            tblEditor.ResumeLayout(false);
            tblEditor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private DataGridView dgvUsers;
        private TableLayoutPanel tblEditor;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private FlowLayoutPanel flowButtons;
        private Button btnBack;
        private Button btnLoad;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
    }
}