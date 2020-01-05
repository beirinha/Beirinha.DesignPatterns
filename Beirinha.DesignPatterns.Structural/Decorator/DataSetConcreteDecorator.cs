using System;

namespace Beirinha.DesignPatterns.Creational.Decorator
{
    public class DataSetConcreteDecorator : DataSetDecorator
    {
        public override void Write()
        {
            Console.WriteLine("Method DataSetDecorator.Write() call");
            this._datasetbase.Write();
        }

        //Decorando com novas funcionalidades
        public void WriteXML()
        {
            Console.WriteLine("Method DataSetDecorator.WriteXML() call");
        }
    }
}
