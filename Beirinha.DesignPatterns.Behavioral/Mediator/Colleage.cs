namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Colleage abstract
    /// </summary>
    public abstract class Colleague
    {
        protected Mediador _mediador;

        public Colleague(Mediador mediador)
        {
            _mediador = mediador;
        }
    }
}