using System;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    public class AuthGoogle : Auth
    {
        public override void Authorize()
        {
            Console.WriteLine("Authorize by Google");
        }
    }
}
