using System;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Refine Abstration
    /// </summary>
    public class ExportationEx : Exportation
    {
        public override void Export()
        {
            Console.WriteLine("Prepara ex before export");
            base.Export();
        }
    }
}
