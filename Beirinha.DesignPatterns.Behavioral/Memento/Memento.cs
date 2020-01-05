using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            this._state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }
}
