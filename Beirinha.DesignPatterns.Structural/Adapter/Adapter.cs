namespace Beirinha.DesignPatterns.Structural.Adapter
{
    ///Transform Adaptee in Target
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
