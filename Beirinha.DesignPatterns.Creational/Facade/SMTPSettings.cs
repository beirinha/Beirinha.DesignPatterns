namespace Beirinha.DesignPatterns.Creational.Facade
{
    public class SMTPSettings
    {
        private string serverName;
        private string userName;
        private string password;

        public string ServerName { get => serverName; set => serverName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
