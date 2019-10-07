using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    public class OracleCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Oracle Execute()");
        }
    }
}
