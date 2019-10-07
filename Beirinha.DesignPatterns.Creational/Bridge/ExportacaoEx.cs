using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Refine Abstration
    /// </summary>
    public class ExportacaoEx : Exportacao
    {
        public override void Exportar()
        {
            Console.WriteLine("Preparei Ex antes de exportar");
            base.Exportar();
        }
    }
}
