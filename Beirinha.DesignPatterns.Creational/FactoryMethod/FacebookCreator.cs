using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class FacebookCreator : Creator
    {
        public override Autenticacao CriarInstancia()
        {
            return new AutenticacaoFacebook();
        }
    }
}
