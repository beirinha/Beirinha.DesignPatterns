using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Concrete Prototype
    /// </summary>
    public class Livro : Item
    {
        public Livro(int id, string descricao, double preco)
            : base(id, descricao, preco)
        {

        }

        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
