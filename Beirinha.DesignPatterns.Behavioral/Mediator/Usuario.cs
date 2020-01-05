using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{

    /// <summary>
    /// Concrete Colleage
    /// </summary>
    public class Usuario : Colleague
    {
        public Usuario(Mediador mediador) : base(mediador)
        {

        }

        public void Send(string mensagem)
        {
            _mediador.Send(mensagem, this);
        }

        public void Notify(string mensagem)
        {
            Console.WriteLine("Usuario recebeu a mensagem: " + mensagem);
        }
    }
}
