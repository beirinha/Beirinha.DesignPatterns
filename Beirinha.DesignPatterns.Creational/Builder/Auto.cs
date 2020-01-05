using System;
using System.Collections.Generic;

namespace Beirinha.DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Auto
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
                
        public Auto(string tipo)
        {
            this._tipo = tipo;
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine($"Type: {_tipo}");
            Console.WriteLine($"Gear: {_parts["gear"]}");
            Console.WriteLine($"Tires: {_parts["tires"]}");
            Console.WriteLine($"Doors: {_parts["doors"]}");
        }

    }
}
