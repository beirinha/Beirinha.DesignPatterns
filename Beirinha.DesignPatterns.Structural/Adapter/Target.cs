using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Structural.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Método Request de Target chamando");
        }
    }
}
