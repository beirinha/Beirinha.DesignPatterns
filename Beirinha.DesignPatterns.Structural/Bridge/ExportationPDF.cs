using System;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Concrete Bridge
    /// </summary>
    public class ExportationPDF : ExportationBridge
    {
        public override void Export()
        {
            Console.WriteLine("Export PDF...");
        }
    }
}
