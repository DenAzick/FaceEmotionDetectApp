using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace FaceEmotionDetectApp.Forms
{
    
    public partial class SettingsForm : Form
    {
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
    }
}
