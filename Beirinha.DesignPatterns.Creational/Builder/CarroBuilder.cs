using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Builder
{
    public class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro Paseeio");
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "4";
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "127c";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4";
        }
    }
}
