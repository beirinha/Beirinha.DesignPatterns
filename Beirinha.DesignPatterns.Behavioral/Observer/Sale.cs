using System;

namespace Beirinha.DesignPatterns.Behavioral.Observer
{
    public class Sale : Observer
    {
        private Balance _balance;
        private bool _state;

        public Sale(Balance balanco)
        {
            this._balance = balanco;
        }

        public void Iniciar()
        {
            if (!_state)
                Console.WriteLine("Sell start");
            else
                Console.WriteLine("Sell can not be initialize, because balance is loading.");
        }

        public override void Update()
        {
            _state = _balance.State;
        }
    }
}
