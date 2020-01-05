using System;
using System.Collections.Generic;

namespace Beirinha.DesignPatterns.Behavioral.Iterator
{
    //Concrete Aggregate
    public class Team : Aggregate
    {
        private List<string> _items = new List<string>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        //indexer
        public Object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, (string)value); }
        }

    }
}
