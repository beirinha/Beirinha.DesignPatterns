using System;

namespace Beirinha.DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class ConnectionBD
    {
        private static ConnectionBD _instance;

        protected ConnectionBD()
        {

        }

        public static ConnectionBD Instance()
        {
            if (_instance == null)
                _instance = new ConnectionBD();

            return _instance;           
        }

        public string stringConexao { get; set; }
        public void Open()
        {
            Console.WriteLine($"Oppened connection: {stringConexao}");
        }
    }
}
