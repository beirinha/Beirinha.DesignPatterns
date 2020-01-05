namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public abstract class Mediador
    {
        public abstract void Send(string message, Colleague colleage);

    }
}
