using System;

namespace Beirinha.DesignPatterns.Creational.Composite
{
    public class Button : Component
    {
        public Button(string name) 
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("It's not possible add this componente");
        }

        public override void Display()
        {
            Console.WriteLine(_name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("It's not possible remove this element");            
        }
    }
}
