namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    public class OracleFactory : DbFactory
    {
        public override DbCommand createCommand()
        {
            return new OracleCommand();
        }

        public override DbConnection createConnection()
        {
            return new OracleConnection();
        }
    }
}
