using System;

namespace Beirinha.DesignPatterns.Structural.Adapter
{
    public class Adaptee : Target
    {
        public void SpecificRequest()
        {
            Console.WriteLine("call SpecificRequest");
        }
    }
}
