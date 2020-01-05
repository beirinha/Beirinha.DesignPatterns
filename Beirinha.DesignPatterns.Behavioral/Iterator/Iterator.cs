using System;

namespace Beirinha.DesignPatterns.Behavioral.Iterator
{
    /// <summary>
    /// Iterator
    /// </summary>
    public abstract class Iterator
    {
        public abstract Object First();
        public abstract Object Next();
        public abstract bool IsDone();
        public abstract Object CurrentItem();

    }
}
