namespace Beirinha.DesignPatterns.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementA);
    }
}
