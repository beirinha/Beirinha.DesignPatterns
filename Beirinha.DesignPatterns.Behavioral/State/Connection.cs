using System;

namespace Beirinha.DesignPatterns.Behavioral.State
{
    /// <summary>
    /// Context
    /// </summary>
    public class Connection
    {
        private ConnectionState _state;

        public Connection(ConnectionState connectionState)
        {
            this._state = connectionState;
        }

        public ConnectionState State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Open()
        {
            _state.Open(this);
        }

        public void Close()
        {
            _state.Close(this);
        }
    }
}
