namespace Beirinha.DesignPatterns.Behavioral.Strategy
{
    /// <summary>    
    /// Mediator of classe client and strategy
    /// </summary>
    public class Context
    {
        BaseSort _strategy;

        public Context(BaseSort strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface(long[] inputArray)
        {
            _strategy.Sort(inputArray);
        }

    }
}
