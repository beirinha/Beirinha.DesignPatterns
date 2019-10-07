namespace Beirinha.DesignPatterns.Creational.Facade
{
    public class MailMessage
    {
        private string _message;
        private MailFormatHTML _format;

        public string Message { get => _message; set => _message = value; }
            
        public MailMessage(MailFormat format)
        {
            //Formatar mensagem aqui...
            this._message = Message;
        }
    }
}
