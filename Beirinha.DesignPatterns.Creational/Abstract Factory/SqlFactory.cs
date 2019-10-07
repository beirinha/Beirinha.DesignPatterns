using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class SqlFactory :DbFactory
    {
        public override DbCommand createCommand()
        {
            return new SqlCommand();
        }

        public override DbConnection createConnection()
        {
            return new SqlConection();
        }
    }
}
