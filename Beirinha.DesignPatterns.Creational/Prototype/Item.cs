using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Protype
    /// </summary>
    public abstract class Item
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Item(int id, string descricao, double preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        //clonar
        public abstract Item Clone();
    }
}
