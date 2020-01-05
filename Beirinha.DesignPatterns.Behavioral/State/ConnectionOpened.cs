namespace Beirinha.DesignPatterns.Behavioral.State
{
    public class ConnectionOpened : ConnectionState
    {
        public override void Close(Connection context)
        {
            context.State = new ConnectionClosed();
        }

        public override void Open(Connection context)
        {
            context.State = new ConnectionOpened();
        }
    }
}
