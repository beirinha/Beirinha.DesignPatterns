using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Creator define o Factory Method Abstrato
    /// </summary>
    public abstract class Creator
    {
        public abstract Autenticacao CriarInstancia();
    }
}
