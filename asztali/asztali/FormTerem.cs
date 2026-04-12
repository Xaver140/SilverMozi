using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using asztali.Models;
using asztali.Services;

namespace asztali
{
    public class FormTerem : Form
    {
        private ListBox lst;
        private Label lbl;
        private PictureBox pbTerem;

        private TeremService service;
        private List<Terem> data;

        public FormTerem()
        {
            Text = "Termek";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(700, 450);
            MinimumSize = new Size(700, 450);
            MaximumSize = new Size(700, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            service = new TeremService();
            data = new List<Terem>();

            BuildLayout();
            LoadData();
        }

        private void BuildLayout()
        {
            SplitContainer mainSplit = new SplitContainer();
            mainSplit.Dock = DockStyle.Fill;
            mainSplit.Orientation = Orientation.Vertical;
            mainSplit.IsSplitterFixed = true;
            mainSplit.FixedPanel = FixedPanel.None;
            mainSplit.SplitterWidth = 6;
            mainSplit.SplitterDistance = 250;
            mainSplit.Panel1MinSize = 100;
            mainSplit.Panel2MinSize = 100;

            SplitContainer leftSplit = new SplitContainer();
            leftSplit.Dock = DockStyle.Fill;
            leftSplit.Orientation = Orientation.Horizontal;
            leftSplit.IsSplitterFixed = true;
            leftSplit.FixedPanel = FixedPanel.Panel1;
            leftSplit.SplitterWidth = 6;
            leftSplit.SplitterDistance = 210;

            lst = new ListBox();
            lst.Dock = DockStyle.Fill;
            lst.Font = new Font("Segoe UI", 11F);
            lst.SelectedIndexChanged += Lst_SelectedIndexChanged;

            pbTerem = new PictureBox();
            pbTerem.Dock = DockStyle.Fill;
            pbTerem.SizeMode = PictureBoxSizeMode.Zoom;
            pbTerem.BorderStyle = BorderStyle.FixedSingle;
            pbTerem.BackColor = Color.White;

            lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Segoe UI", 14F);
            lbl.Padding = new Padding(20);
            lbl.TextAlign = ContentAlignment.TopLeft;

            leftSplit.Panel1.Controls.Add(lst);
            leftSplit.Panel2.Controls.Add(pbTerem);

            mainSplit.Panel1.Controls.Add(leftSplit);
            mainSplit.Panel2.Controls.Add(lbl);

            Controls.Add(mainSplit);
        }

        private void LoadData()
        {
            try
            {
                data = service.GetAllTermek();
                lst.Items.Clear();

                foreach (var t in data)
                {
                    lst.Items.Add(t);
                }

                if (lst.Items.Count > 0)
                {
                    lst.SelectedIndex = 0;
                }
                else
                {
                    lbl.Text = "Nincs terem.";
                    pbTerem.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a termek betöltésekor:\n" + ex.Message);
            }
        }

        private void Lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedIndex < 0)
                return;

            var t = data[lst.SelectedIndex];

            lbl.Text =
                $"Terem ID: {t.TeremId}\n\n" +
                $"Név: {t.Name}\n\n" +
                $"Sorok: {t.TotalRows}\n" +
                $"Szék/sor: {t.SeatsPerRow}\n\n" +
                $"Férőhely: {t.Capacity} fő";

            LoadTeremImage(t.TeremId);
        }

        private void InitializeComponent()
        {

        }

        private void LoadTeremImage(int teremId)
        {
            try
            {
                pbTerem.Image = null;

                string fileName = $"terem_{teremId}.png";
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", fileName);

                if (!File.Exists(imagePath))
                    return;

                using (Image tempImage = Image.FromFile(imagePath))
                {
                    pbTerem.Image = new Bitmap(tempImage);
                }
            }
            catch
            {
                pbTerem.Image = null;
            }
        }
    }
}