using System;

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
