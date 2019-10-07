using System;

namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    public class SqlConection : DbConnection
    {
        /// <summary>
        /// Concrete Product
        /// </summary>
        public override void Open()
        {
            Console.WriteLine($"Sql Open()");
        }
    }
}
