using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Decorator
{
    /// <summary>
    /// Concrete Component
    /// </summary>
    public class DataSet : DatasetBase
    {
        public override void Write()
        {
            Console.WriteLine("Método DataSet.Write() invocado");
        }
    }
}
