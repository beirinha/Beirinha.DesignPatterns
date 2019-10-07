using System;

namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine($"Sql Execute()");
        }
    }
}
