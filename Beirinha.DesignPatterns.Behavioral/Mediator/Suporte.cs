using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public class Suporte : Colleague
    {
        public Suporte(Mediador mediador) : base(mediador)
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
