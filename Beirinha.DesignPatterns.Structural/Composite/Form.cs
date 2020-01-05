using System;
using System.Collections.Generic;

namespace Beirinha.DesignPatterns.Creational.Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class Form : Component
    {
        private List<Component> _children = new List<Component>();

        public Form(string name ) : base(name)
        {

        }

        public override void Add(Component c)
        {
            this._children.Add(c);
        }

        public override void Display()
        {
            Console.WriteLine(_name);
            foreach (var c in this._children)
                c.Display();
        }

        public override void Remove(Component c)
        {
            this._children.Remove(c);              
        }
    }
}
