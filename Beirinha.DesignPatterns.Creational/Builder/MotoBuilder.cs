using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Builder
{
    public class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Carro Paseeio");
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "0";
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "50c";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";
        }
    }
}
