using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Decorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    public class DataSetDecorator : DatasetBase
    {
        protected DatasetBase _datasetbase;

        public void setDatasetbase(DatasetBase datasetbase)
        {
            this._datasetbase = datasetbase;
        }

        public override void Write()
        {
            Console.WriteLine("Método DataSetDecorator.Write() invocado");
            this._datasetbase.Write();
        }
    }
}
