using System;

namespace Beirinha.DesignPatterns.Structural.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("call Request");
        }
    }
}
