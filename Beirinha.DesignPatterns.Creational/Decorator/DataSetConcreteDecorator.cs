using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Decorator
{
    public class DataSetConcreteDecorator : DataSetDecorator
    {
        public override void Write()
        {
            Console.WriteLine("Método DataSetDecorator.Write() invocado");
            this._datasetbase.Write();
        }

        //Decorando com novas funcionalidades
        public void WriteXML()
        {
            Console.WriteLine("Método DataSetDecorator.WriteXML() invocado");
        }
    }
}
