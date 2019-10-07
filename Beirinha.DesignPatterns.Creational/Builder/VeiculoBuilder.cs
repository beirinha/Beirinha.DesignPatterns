using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Builder
{
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;

        public Veiculo Veiculo
        {
            get { return _veiculo; }            
        }

        //Processo de construção (abstrato)
        public abstract void BuildMotor();
        public abstract void BuildPortas();
        public abstract void BuildPneus();
    }
}
