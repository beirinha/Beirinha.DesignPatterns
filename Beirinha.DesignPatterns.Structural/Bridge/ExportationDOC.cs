using System;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Concrete Bridge
    /// </summary>
    public class ExportationDOC : ExportationBridge
    {
        public override void Export()
        {
            Console.WriteLine("Export DOC...");
        }
    }
}
