using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    public class AutenticacaoFacebook : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Facebook");
        }
    }
}
