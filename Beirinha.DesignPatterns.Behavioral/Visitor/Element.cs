﻿namespace Beirinha.DesignPatterns.Behavioral.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
