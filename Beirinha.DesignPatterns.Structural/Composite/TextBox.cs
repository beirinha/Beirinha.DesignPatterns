using System;

namespace Beirinha.DesignPatterns.Creational.Composite
{
    public class TextBox : Component
    {
        public TextBox(string name) 
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("It's not possible add this component");
        }

        public override void Display()
        {
            Console.WriteLine(_name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("It's not possible remove elements of this component");            
        }
    }
}
