namespace FaceEmotionDetectApp.Models
{
    public class Configuration
    {
        public string Ip { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Port { get; set; } = 80;
        public int Timeout { get; set; } = 5000;
        public bool UseHttps { get; set; } = false;
        public Configuration(string ip, string login, string password, int port = 80, int timeout = 5000, bool useHttps = false)
        {
            Ip = ip;
            Login = login;
            Password = password;
            Port = port;
            Timeout = timeout;
            UseHttps = useHttps;
        }
    }
}
