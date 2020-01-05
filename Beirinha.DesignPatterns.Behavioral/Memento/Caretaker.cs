namespace Beirinha.DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// Caretaker 
    /// </summary>
    public class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
