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
        private bool _isConnected = false;
        public SettingsForm()
        {
            InitializeComponent();
            textBox_Password.PasswordChar = '•';
            textBox_Username.PasswordChar = '•';
            //LoadConfiguration();
            button_Config_Connect.BackColor = Color.FromArgb(0, 154, 82);
            this.TopMost = true;


        }

        private async void button_Config_Connect_Click(object sender, EventArgs e)
        {
            //SaveConfiguration();
            if (_isConnected)
            {
                button_Config_Connect.Text = "Connect";
                return;
            }

            string cameraUrl = GetCameraUrl();
            if (string.IsNullOrEmpty(cameraUrl))
                return;

            //bool connected = await LoadCamera(cameraUrl);
            //if (!connected)
            //    return;

            this.Text = $"{textBox_Ip.Text.Trim()}:{textBox_Port.Text.Trim()}";
            _isConnected = true;
            button_Config_Connect.Text = "Disconnect";
        }
        private string GetCameraUrl()
        {
            string username = textBox_Username.Text.Trim();
            string password = textBox_Password.Text.Trim();
            string ip = textBox_Ip.Text.Trim();
            string port = textBox_Port.Text.Trim();

            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Введите IP-адрес камеры.");
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("Введите порт камеры.");
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Введите username");
                return string.Empty;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите password.");
                return string.Empty;
            }

            //string pattern = comboBox_Protocol.Text;
            string result = $"rtsp://{username}:{password}@{ip}:{port}";
            return result;
        }
        //private void SaveConfiguration()
        //{
        //    var config = new
        //    {
        //        Ip = textBox_Ip.Text,
        //        Login = textBox_Username.Text,
        //        Password = textBox_Password.Text,
        //        Port = textBox_Port.Text
        //    };
        //    string json = JsonConvert.SerializeObject(config, Formatting.Indented);
        //    System.IO.File.WriteAllText("config.json", json);
        //}

        //private void LoadConfiguration()
        //{
        //    if (System.IO.File.Exists("config.json"))
        //    {
        //        string json = System.IO.File.ReadAllText("config.json");
        //        var config = JsonConvert.DeserializeObject<dynamic>(json);
        //        textBox_Ip.Text = config.Ip;
        //        textBox_Username.Text = config.Login;
        //        textBox_Password.Text = config.Password;
        //        textBox_Port.Text = config.Port;
        //    }
        //}

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


            textBox_Ip.Text = Properties.Settings.Default.IP;
            textBox_Port.Text = Properties.Settings.Default.Port;
            textBox_Username.Text = Properties.Settings.Default.Username;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IP = textBox_Ip.Text;
            Properties.Settings.Default.Port = textBox_Port.Text;
            Properties.Settings.Default.Username = textBox_Username.Text;
            Properties.Settings.Default.Save();
        }

       
    }
}
