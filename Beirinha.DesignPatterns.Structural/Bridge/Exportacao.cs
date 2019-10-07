using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Exportacao
    {

        //Composite
        protected ExportacaoBridge _implementor;

        public ExportacaoBridge Implementor
        {
            set { this._implementor = value; }
        }

        public virtual void Exportar()
        {
            //implementation by delegation
            _implementor.Exportar();
        }
    }
}
