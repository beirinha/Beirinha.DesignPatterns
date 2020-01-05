using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public abstract class Mediador
    {
        public abstract void Send(string message, Colleague colleage);

    }
}
