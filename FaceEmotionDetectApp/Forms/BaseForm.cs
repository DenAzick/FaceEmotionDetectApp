using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceEmotionDetectApp.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            ApplyFontToAllControls(this, "Fonts\\Inter-Regular.ttf");
        }

        private void ApplyFontToAllControls(Control parent, string fontName)
        {
            parent.Font = new Font(fontName, parent.Font.Size, parent.Font.Style);

            foreach (Control control in parent.Controls)
            {
                ApplyFontToAllControls(control, fontName);
            }
        }

    }
}
