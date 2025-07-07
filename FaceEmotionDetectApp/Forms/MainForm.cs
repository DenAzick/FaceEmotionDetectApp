using FaceEmotionDetectApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceEmotionDetectApp
{

    public partial class MainForm : BaseForm
    {
        private UserInfoForm _openUserInfoForm;
        private List<Panel> panels = new List<Panel>();
        private PictureBox pictureBoxTopRight;
        private PictureBox pictureBoxBottomRight;

        private readonly Size originalFormSize = new Size(1920, 1080);




        private Dictionary<string, Rectangle> originalControlsLayout = new Dictionary<string, Rectangle>();

        public MainForm()
        {
            InitializeComponent();
            MainFormSettings();
            this.TopMost = true;
            // this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < 12; i++)
            {
                var labelName = $"label_{i}";
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

                label.Font = new Font("Fonts\\Inter-Regular.ttf", 24, FontStyle.Regular);

                label.ForeColor = ColorTranslator.FromHtml("#009A52");
            }


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AddClickHandlersToAllPanels();
            StoreOriginalLayout();

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string panelName = $"panel_{row}_{col}";
                    var panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;

                    if (panel != null)
                    {
                        ApplyRoundedCornersAndPaint(panel, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);

                    }
                   
                }
            }

            ApplyRoundedCornersAndPaint(panel_PTZ_Camera, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
            ApplyRoundedCornersAndPaint(panel_Panorama_Camera, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
        }

        //

        private void ApplyRoundedCornersAndPaint(Control control, int radius, Color borderColor, int borderWidth)
        {
            control.Resize += (s, e) => control.Invalidate(); // Перерисовка при изменении размера

            control.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = control.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                Rectangle insetRect = new Rectangle(
                    rect.X + borderWidth / 2,
                    rect.Y + borderWidth / 2,
                    rect.Width - borderWidth,
                    rect.Height - borderWidth
                );

                using (GraphicsPath path = GetRoundedRectanglePath(insetRect, radius))
                {
                    // Заливка фона
                    using (SolidBrush brush = new SolidBrush(control.BackColor))
                        e.Graphics.FillPath(brush, path);

                    // Граница
                    using (Pen pen = new Pen(borderColor, borderWidth))
                        e.Graphics.DrawPath(pen, path);

                    // Установка формы (скруглённой области)
                    control.Region = new Region(path);
                }
            };
        }



        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();

            // Верхняя левая
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Верхняя правая
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Нижняя правая
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Нижняя левая
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        //
        //



        private void MainFormSettings()
        {
            pictureBox_PTZ_Live.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Panorama_Live.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Load += MainForm_Load;
            this.Resize += MainForm_Resize;


            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string panelName = $"panel_{row}_{col}";
                    var panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;

                    if (panel != null)
                    {
                        foreach (var pictureBox in panel.Controls.OfType<PictureBox>())
                        {
                            pictureBox.AutoSize = true;
                            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                            
                        }

                    }
                    else
                    {
                        panel.Padding = new Padding(
                            (panel.Width - panel.ClientSize.Width) / 2,
                            (panel.Height - panel.ClientSize.Height) / 2,
                            0, 0);

                    }
                }
            }

            

        }

        private void StoreOriginalLayout()
        {
            originalControlsLayout.Clear(); 

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string panelName = $"panel_{row}_{col}";
                    var panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
                    if (panel != null && !originalControlsLayout.ContainsKey(panelName))
                    {
                        originalControlsLayout.Add(panelName, new Rectangle(panel.Location, panel.Size));
                    }
                }
            }

            var ptzLive = this.Controls.Find("pictureBox_PTZ_Live", true).FirstOrDefault() as PictureBox;
            var panorama = this.Controls.Find("pictureBox_Panorama_Live", true).FirstOrDefault() as PictureBox;

            if (ptzLive != null && !originalControlsLayout.ContainsKey("pictureBox_PTZ_Live"))
            {
                originalControlsLayout.Add("pictureBox_PTZ_Live", new Rectangle(ptzLive.Location, ptzLive.Size));
            }

            if (panorama != null && !originalControlsLayout.ContainsKey("pictureBox_Panorama_Live"))
            {
                originalControlsLayout.Add("pictureBox_Panorama_Live", new Rectangle(panorama.Location, panorama.Size));
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (originalControlsLayout.Count == 0) return;

            float scaleX = (float)this.ClientSize.Width / originalFormSize.Width;
            float scaleY = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (var entry in originalControlsLayout)
            {
                var control = this.Controls.Find(entry.Key, true).FirstOrDefault();
                if (control != null)
                {
                    control.Width = (int)(entry.Value.Width * scaleX);
                    control.Height = (int)(entry.Value.Height * scaleY);
                    control.Left = (int)(entry.Value.X * scaleX);
                    control.Top = (int)(entry.Value.Y * scaleY);
                }
            }
        }

        private Image GenerateRandomImage(int width, int height, string label)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                g.Clear(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));

                using (Font font = new Font("Fonts\\Inter-Regular.ttf", 10))
                {
                    g.DrawString(label, font, Brushes.Black, 5, 5);
                }
            }
            return bmp;
        }

        private List<Panel> GetOrderedPanels()
        {
            var result = new List<Panel>();

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string name = $"panel_{row}_{col}";
                    var panel = this.Controls.Find(name, true).FirstOrDefault() as Panel;
                    if (panel != null)
                        result.Add(panel);

                }
            }

            return result;
        }

        private void ShiftPanelImagesDown()
        {
            var panels = GetOrderedPanels();

            for (int i = panels.Count - 1; i > 0; i--)
            {
                var current = panels[i];
                var previous = panels[i - 1];

                var currentPBs = current.Controls.OfType<PictureBox>().ToList();
                var previousPBs = previous.Controls.OfType<PictureBox>().ToList();

                if (currentPBs.Count == 2 && previousPBs.Count == 2)
                {
                    currentPBs[0].Image = previousPBs[0].Image != null ? (Image)previousPBs[0].Image.Clone() : null;
                    currentPBs[1].Image = previousPBs[1].Image != null ? (Image)previousPBs[1].Image.Clone() : null;
                }
            }

            var firstPanelPBs = panels[0].Controls.OfType<PictureBox>().ToList();
            if (firstPanelPBs.Count == 2)
            {
                firstPanelPBs[1].Image = pictureBox_PTZ_Live.Image != null ? (Image)pictureBox_PTZ_Live.Image.Clone() : null;
                firstPanelPBs[0].Image = pictureBox_Panorama_Live.Image != null ? (Image)pictureBox_Panorama_Live.Image.Clone() : null;
            }
        }

        private void shiftButton_Click(object sender, EventArgs e)
        {
            pictureBox_Panorama_Live.Image = GenerateRandomImage(
                pictureBox_Panorama_Live.Width,
                pictureBox_Panorama_Live.Height, "");

            pictureBox_PTZ_Live.Image = GenerateRandomImage(
                pictureBox_PTZ_Live.Width,
                pictureBox_PTZ_Live.Height, "");

            ShiftPanelImagesDown();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void AddClickHandlersToAllPanels()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string panelName = $"panel_{row}_{col}";
                    var panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;


                    panel.Click += Panel_Click;

                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (_openUserInfoForm != null && !_openUserInfoForm.IsDisposed)
                return;

            Panel panel = sender as Panel ?? (sender as Control)?.Parent as Panel;
            if (panel == null) return;

            var pictureBoxes = panel.Controls.OfType<PictureBox>().ToList();
            if (pictureBoxes.Count < 2) return;

            _openUserInfoForm = new UserInfoForm(
                (Image)pictureBoxes[1].Image?.Clone(),
                (Image)pictureBoxes[0].Image?.Clone());

            _openUserInfoForm.Show();
        }

       
    }
}
