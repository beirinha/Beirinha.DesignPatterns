using System;

namespace Beirinha.DesignPatterns.Creational.Bridge
{
    /// <summary>
    /// Concrete Bridge
    /// </summary>
    public class ExportacaoDOC : ExportacaoBridge
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando DOC...");
        }
    }
}
