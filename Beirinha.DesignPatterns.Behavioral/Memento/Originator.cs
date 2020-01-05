using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Memento
{
    
    public class Originator
    {
        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void setMemento(Memento memento)
        {
            Console.WriteLine("restaurando o estado...");
            State = memento.State;
        }
    }
}
