using System;

namespace Beirinha.DesignPatterns.Behavioral.Observer
{
    public class Balance : Subject
    {
        private bool _state = false;

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }



        public void Iniciar()
        {
            _state = true;
            Console.WriteLine("Balance is loading");
        }

        public void Finalizar()
        {
            _state = false;
            Console.WriteLine("Balance is complete");
        }
    }
}
