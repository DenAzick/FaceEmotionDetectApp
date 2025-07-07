using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace FaceEmotionDetectApp.Forms
{
    
    public partial class SettingsForm : Form
    {
        private PrivateFontCollection _fonts = new PrivateFontCollection();

        public SettingsForm()
        {
            InitializeComponent();
            textBox_Password.PasswordChar = '•'; 
            LoadConfiguration();
            button_Config_Connect.BackColor = Color.FromArgb(0, 154, 82);
            this.TopMost = true;


        }

        private void button_Config_Connect_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void SaveConfiguration()
        {
            var config = new
            {
                Ip = textBox_Ip.Text,
                Login = textBox_Login.Text,
                Password = textBox_Password.Text, 
                Port = textBox1.Text
            };
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            System.IO.File.WriteAllText("config.json", json);
        }

        private void LoadConfiguration()
        {
            if (System.IO.File.Exists("config.json"))
            {
                string json = System.IO.File.ReadAllText("config.json");
                var config = JsonConvert.DeserializeObject<dynamic>(json);
                textBox_Ip.Text = config.Ip;
                textBox_Login.Text = config.Login;
                textBox_Password.Text = config.Password;
                textBox1.Text = config.Port;
            }
        }

        private void LoadPoppinsFontForLabelsPreserveSize()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "Poppins", "Poppins-SemiBold.ttf");

            if (!File.Exists(fontPath))
            {
                MessageBox.Show("Шрифт не найден: " + fontPath);
                return;
            }

            _fonts.AddFontFile(fontPath);

            FontFamily poppinsFamily = _fonts.Families[0];

            ApplyFontToLabelsPreserveSize(this, poppinsFamily);
        }

        private void ApplyFontToLabelsPreserveSize(Control parent, FontFamily fontFamily)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label label)
                {
                    float currentSize = label.Font.Size;
                    FontStyle currentStyle = label.Font.Style;

                    label.Font = new Font(fontFamily, currentSize, currentStyle);
                }

                if (control.HasChildren)
                {
                    ApplyFontToLabelsPreserveSize(control, fontFamily);
                }
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadPoppinsFontForLabelsPreserveSize();
        }
    }
}
