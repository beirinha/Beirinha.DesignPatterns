using System;

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
            Console.WriteLine("Method DataSetDecorator.Write() call");
            this._datasetbase.Write();
        }
    }
}
