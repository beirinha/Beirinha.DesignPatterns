namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class GoogleCreator : Creator
    {
        public override Auth CreateInstance()
        {
            return new AuthGoogle();
        }
    }
}
