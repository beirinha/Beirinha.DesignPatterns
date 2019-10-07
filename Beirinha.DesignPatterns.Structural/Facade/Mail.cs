using System;

namespace Beirinha.DesignPatterns.Creational.Facade
{
    public class Mail
    {
        private SMTPSettings _conf;

        public void Send(MailMessage message)
        {
            //Usando configuração SMTP
            Console.WriteLine("Enviando Mensagem...");
            Console.WriteLine(message.Message);
        }

        public Mail(SMTPSettings conf)
        {

        }
    }
}
