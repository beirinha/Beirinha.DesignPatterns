using System;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Concrete Bridge
    /// </summary>
    public class ExportacaoPDF : ExportacaoBridge
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando PDF...");
        }
    }
}
