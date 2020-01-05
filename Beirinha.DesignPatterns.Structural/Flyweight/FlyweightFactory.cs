using System.Collections;

namespace Beirinha.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _flyweights.Add("A", new ConcreteFlyweight());
            _flyweights.Add("B", new ConcreteFlyweight());
            _flyweights.Add("C", new ConcreteFlyweight());
        }

        public FlyweightAbstract GetFlyweight(string key)
        {
            return (FlyweightAbstract)_flyweights[key];
        }
    }
}
