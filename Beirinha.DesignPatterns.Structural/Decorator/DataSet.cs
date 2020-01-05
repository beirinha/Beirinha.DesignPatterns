using System;

namespace Beirinha.DesignPatterns.Creational.Decorator
{
    /// <summary>
    /// Concrete Component
    /// </summary>
    public class DataSet : DatasetBase
    {
        public override void Write()
        {
            Console.WriteLine("Method DataSet.Write() called");
        }
    }
}
