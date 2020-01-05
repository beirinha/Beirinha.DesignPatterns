using System;

namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    public class AuthFacebook : Auth
    {
        public override void Authorize()
        {
            Console.WriteLine("Authorize by Facebook");
        }
    }
}
