using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    public class AutenticacaoGoogle : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google");
        }
    }
}
