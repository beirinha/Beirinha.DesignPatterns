using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : Mediador
    {
        private Suporte _suporte;
        private Usuario _usuario;

        public Suporte Suporte
        {
            set { _suporte = value; }
        }

        public Usuario Usuario
        {
            set { _usuario = value; }
        }

        public override void Send(string message, Colleague colleage)
        {
            if(colleage == _usuario)
            {
                _suporte.Notify(message);
            }
            else
            {
                _usuario.Notify(message);
            }
        }
    }
}
