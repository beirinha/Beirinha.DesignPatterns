using System;

namespace Beirinha.DesignPatterns.Creational.Facade
{
    public class Mail
    {
        private SMTPSettings _conf;

        public void Send(MailMessage message)
        {
            Console.WriteLine("Sending Message...");
            Console.WriteLine(message.Message);
        }

        public Mail(SMTPSettings conf)
        {

        }
    }
}
