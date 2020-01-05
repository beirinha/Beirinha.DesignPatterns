namespace Beirinha.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class FacebookCreator : Creator
    {
        public override Auth CreateInstance()
        {
            return new AuthFacebook();
        }
    }
}
