namespace Beirinha.DesignPatterns.Creational.Abstract_Factory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class DbFactory
    {
        public abstract DbConnection createConnection();
        public abstract DbCommand createCommand();
    }
}
