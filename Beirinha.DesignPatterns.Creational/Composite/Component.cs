﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Composite
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            this._name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display();
    }
}
