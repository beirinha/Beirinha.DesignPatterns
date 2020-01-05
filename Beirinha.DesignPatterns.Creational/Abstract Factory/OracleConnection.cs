using System;

namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    public class OracleConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Executando Oracle Open()");
        }
    }
}
