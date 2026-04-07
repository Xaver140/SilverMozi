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
            groupBox1 = new GroupBox();
            listBoxVetitesek = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbFilm = new ComboBox();
            cmbTerem = new ComboBox();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            txtPrice = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnLoad = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxVetitesek);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(465, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vetítések";
            // 
            // listBoxVetitesek
            // 
            listBoxVetitesek.FormattingEnabled = true;
            listBoxVetitesek.Location = new Point(9, 23);
            listBoxVetitesek.Margin = new Padding(3, 4, 3, 4);
            listBoxVetitesek.Name = "listBoxVetitesek";
            listBoxVetitesek.Size = new Size(450, 224);
            listBoxVetitesek.TabIndex = 0;
            listBoxVetitesek.SelectedIndexChanged += listBoxVetitesek_SelectedIndexChanged_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbFilm, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbTerem, 1, 2);
            tableLayoutPanel1.Controls.Add(dtStart, 1, 3);
            tableLayoutPanel1.Controls.Add(dtEnd, 1, 4);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(flowButtons, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.86577F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1342278F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Size = new Size(943, 635);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 279);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "Film:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 349);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Terem:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 404);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Kezdés:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 460);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Befejezés:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 505);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 5;
            label5.Text = "Ár:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbFilm
            // 
            cmbFilm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbFilm.FormattingEnabled = true;
            cmbFilm.Location = new Point(477, 300);
            cmbFilm.Margin = new Padding(6, 7, 6, 7);
            cmbFilm.Name = "cmbFilm";
            cmbFilm.Size = new Size(460, 28);
            cmbFilm.TabIndex = 6;
            // 
            // cmbTerem
            // 
            cmbTerem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTerem.FormattingEnabled = true;
            cmbTerem.Location = new Point(477, 362);
            cmbTerem.Margin = new Padding(6, 7, 6, 7);
            cmbTerem.Name = "cmbTerem";
            cmbTerem.Size = new Size(460, 28);
            cmbTerem.TabIndex = 7;
            // 
            // dtStart
            // 
            dtStart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtStart.Location = new Point(477, 418);
            dtStart.Margin = new Padding(6, 7, 6, 7);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(460, 27);
            dtStart.TabIndex = 8;
            // 
            // dtEnd
            // 
            dtEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtEnd.Location = new Point(477, 469);
            dtEnd.Margin = new Padding(6, 7, 6, 7);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(460, 27);
            dtEnd.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(477, 513);
            txtPrice.Margin = new Padding(6, 7, 6, 7);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(460, 27);
            txtPrice.TabIndex = 10;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnLoad);
            flowButtons.Controls.Add(btnNew);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Controls.Add(btnBack);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.Location = new Point(474, 552);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(466, 80);
            flowButtons.TabIndex = 11;
            flowButtons.WrapContents = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(3, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(80, 39);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Betöltés";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += VetitesForm_Load;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(89, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(98, 39);
            btnNew.TabIndex = 1;
            btnNew.Text = "Új";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(193, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(367, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 39);
            btnBack.TabIndex = 0;
            btnBack.Text = "Vissza";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // VetitesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 635);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VetitesForm";
            Text = "VetitesForm";
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