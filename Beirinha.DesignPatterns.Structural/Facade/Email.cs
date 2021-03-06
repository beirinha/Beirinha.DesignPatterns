﻿namespace Beirinha.DesignPatterns.Creational.Facade
{
    //Facade
    public class Email
    {
        private Mail _mail;
        private MailFormat _format;
        private SMTPSettings _conf;
        private MailMessage _maiMessage;

        public Email()
        {
            
            this._format = new MailFormatTXT();
            this._conf = new SMTPSettings()
            {
                ServerName = "smtp.gmail.com",
                Password = "123",
                UserName = "luiz"
            };
            this._mail = new Mail(_conf);
            this._maiMessage = new MailMessage(_format);


        }

        public void Send(string mensagem)
        {
            _maiMessage.Message = mensagem;
            _mail.Send(_maiMessage);
        }
    }
}
