using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Structural.Flyweight
{
    public class UnsharedConcreteFlyweight : FlyweightAbstract
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("UnsharedConcrete " + ext);
        }
    }
}
