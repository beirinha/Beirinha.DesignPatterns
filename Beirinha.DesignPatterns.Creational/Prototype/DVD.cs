using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Prototype
{
    public class DVD : Item
    {

        public DVD(int id, string descricao, double preco)
            :base(id, descricao,preco)
        {

        }
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
