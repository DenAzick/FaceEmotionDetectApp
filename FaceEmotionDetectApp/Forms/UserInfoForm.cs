using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceEmotionDetectApp.Forms
{
    public partial class UserInfoForm : BaseForm
    {
        public UserInfoForm(Image ptz, Image panorama)
        {
            InitializeComponent();
            this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;

            pictureBox_PTZ_Live_Info.Image = ptz != null ? (Image)ptz.Clone() : null;
            pictureBox_Panorama_Live_Info.Image = panorama != null ? (Image)panorama.Clone() : null;

            pictureBox_PTZ.Image =  ptz != null ? (Image)ptz.Clone() : null;

            pictureBox_Panorama.Image = panorama != null ? (Image)panorama.Clone() : null;

            pictureBox_PTZ_Live_Info.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Panorama_Live_Info.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_PTZ.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Panorama.SizeMode = PictureBoxSizeMode.CenterImage;
        }




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

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersAndPaint(panel_PTZ, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
            ApplyRoundedCornersAndPaint(panel_Panorama, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
            ApplyRoundedCornersAndPaint(panel_PTZ_Live, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
            ApplyRoundedCornersAndPaint(panel_Panorama_Live, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);
            ApplyRoundedCornersAndPaint(panel_UserInfo, 10, ColorTranslator.FromHtml("#DBE5F3"), 2);

        }
    }
}
