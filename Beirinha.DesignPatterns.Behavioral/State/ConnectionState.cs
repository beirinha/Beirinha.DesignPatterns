namespace Beirinha.DesignPatterns.Behavioral.State
{
    /// <summary>
    /// State
    /// </summary>
    public abstract class ConnectionState
    {
        public abstract void Open(Connection context);
        public abstract void Close(Connection context);
    }
}
