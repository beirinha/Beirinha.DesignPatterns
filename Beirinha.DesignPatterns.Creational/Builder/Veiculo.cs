using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
                
        public Veiculo(string tipo)
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

        public void Mostrar()
        {
            Console.WriteLine($"Tipo: {_tipo}");
            Console.WriteLine($"Motor: {_parts["motor"]}");
            Console.WriteLine($"Pneus: {_parts["pneus"]}");
            Console.WriteLine($"Portas: {_parts["portas"]}");
        }

    }
}
