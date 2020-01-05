namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Exportation
    {

        //Composite
        protected ExportationBridge _implementor;

        public ExportationBridge Implementor
        {
            set { this._implementor = value; }
        }

        public virtual void Export()
        {
            //implementation by delegation
            _implementor.Export();
        }
    }
}
