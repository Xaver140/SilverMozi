namespace asztali
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnBack = new Button();
            Adatbázis = new Button();
            termekToolStripMenuItem = new ToolStripMenuItem();
            filmekToolStripMenuItem = new ToolStripMenuItem();
            vetítésekToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.log_in__2_;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(634, 32);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 69);
            btnBack.TabIndex = 3;
            btnBack.Text = "Bejelentkezés";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Adatbázis
            // 
            Adatbázis.BackgroundImage = Properties.Resources.user;
            Adatbázis.BackgroundImageLayout = ImageLayout.Zoom;
            Adatbázis.Location = new Point(784, 32);
            Adatbázis.Margin = new Padding(3, 4, 3, 4);
            Adatbázis.Name = "Adatbázis";
            Adatbázis.Size = new Size(118, 69);
            Adatbázis.TabIndex = 4;
            Adatbázis.Text = "Felhasználók";
            Adatbázis.UseVisualStyleBackColor = true;
            Adatbázis.Click += button1_Click;
            // 
            // termekToolStripMenuItem
            // 
            termekToolStripMenuItem.Name = "termekToolStripMenuItem";
            termekToolStripMenuItem.Size = new Size(71, 24);
            termekToolStripMenuItem.Text = "Termek";
            termekToolStripMenuItem.Click += termekToolStripMenuItem_Click;
            // 
            // filmekToolStripMenuItem
            // 
            filmekToolStripMenuItem.Name = "filmekToolStripMenuItem";
            filmekToolStripMenuItem.Size = new Size(66, 24);
            filmekToolStripMenuItem.Text = "Filmek";
            filmekToolStripMenuItem.Click += filmekToolStripMenuItem_Click;
            // 
            // vetítésekToolStripMenuItem
            // 
            vetítésekToolStripMenuItem.Name = "vetítésekToolStripMenuItem";
            vetítésekToolStripMenuItem.Size = new Size(82, 24);
            vetítésekToolStripMenuItem.Text = "Vetítések";
            vetítésekToolStripMenuItem.Click += vetítésekToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { termekToolStripMenuItem, filmekToolStripMenuItem, vetítésekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mozihero__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 600);
            Controls.Add(Adatbázis);
            Controls.Add(menuStrip1);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Fő oldal";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Button Adatbázis;
        private ToolStripMenuItem termekToolStripMenuItem;
        private ToolStripMenuItem filmekToolStripMenuItem;
        private ToolStripMenuItem vetítésekToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}