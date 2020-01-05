using System;

namespace Beirinha.DesignPatterns.Structural.Flyweight
{
    public class ConcreteFlyweight : FlyweightAbstract
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("Concrete Flyweight " + ext);
        }
    }
}
