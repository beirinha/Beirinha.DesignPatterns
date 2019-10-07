namespace Beirinha.DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// O meio de campo entre a classe cliente e a estrategia
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
