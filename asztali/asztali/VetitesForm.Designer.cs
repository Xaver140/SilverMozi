namespace asztali
{
    partial class VetitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetitesForm));
            groupBox1 = new GroupBox();
            listBoxVetitesek = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbFilm = new ComboBox();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            txtPrice = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnBack = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            cmbTerem = new ComboBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(listBoxVetitesek);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBoxVetitesek
            // 
            listBoxVetitesek.Dock = DockStyle.Fill;
            listBoxVetitesek.FormattingEnabled = true;
            listBoxVetitesek.Location = new Point(3, 23);
            listBoxVetitesek.Name = "listBoxVetitesek";
            listBoxVetitesek.Size = new Size(788, 114);
            listBoxVetitesek.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbFilm, 1, 1);
            tableLayoutPanel1.Controls.Add(dtStart, 1, 3);
            tableLayoutPanel1.Controls.Add(dtEnd, 1, 4);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(flowButtons, 1, 6);
            tableLayoutPanel1.Controls.Add(cmbTerem, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.9424438F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.0575542F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 146);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 202);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 244);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 289);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 333);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "label1";
            // 
            // cmbFilm
            // 
            cmbFilm.FormattingEnabled = true;
            cmbFilm.Location = new Point(403, 149);
            cmbFilm.Name = "cmbFilm";
            cmbFilm.Size = new Size(205, 28);
            cmbFilm.TabIndex = 2;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(403, 247);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(250, 27);
            dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(403, 292);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(250, 27);
            dtEnd.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(403, 336);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 4;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnBack);
            flowButtons.Controls.Add(btnNew);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Controls.Add(btnLoad);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.Location = new Point(403, 387);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(394, 60);
            flowButtons.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.left;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 57);
            btnBack.TabIndex = 0;
            btnBack.Text = "Vissza";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(91, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(67, 57);
            btnNew.TabIndex = 0;
            btnNew.Text = "Új";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(244, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 57);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(312, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(73, 57);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Betöltés";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbTerem
            // 
            cmbTerem.FormattingEnabled = true;
            cmbTerem.Location = new Point(403, 205);
            cmbTerem.Name = "cmbTerem";
            cmbTerem.Size = new Size(205, 28);
            cmbTerem.TabIndex = 2;
            // 
            // VetitesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VetitesForm";
            Text = "Vetítések";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxVetitesek;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbFilm;
        private ComboBox cmbTerem;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private TextBox txtPrice;
        private FlowLayoutPanel flowButtons;
        private Button btnLoad;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
    }
}