using System;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{

    /// <summary>
    /// Concrete Colleage
    /// </summary>
    public class User : Colleague
    {
        public User(Mediador mediador) : base(mediador)
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
