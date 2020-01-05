using System;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public class Support : Colleague
    {
        public Support(Mediador mediador) : base(mediador)
        {

        }

        public void Send(string menssagem)
        {
            _mediador.Send(menssagem, this);
        }

        public void Notify(string menssagem)
        {
            Console.WriteLine("Suporte recebeu a mensagem: " + menssagem);
        }
    }
}
