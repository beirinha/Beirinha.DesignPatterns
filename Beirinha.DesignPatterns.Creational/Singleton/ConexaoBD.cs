using System;

namespace Beirinha.DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class ConexaoBD
    {
        // Guarda internamente a instancia
        private static ConexaoBD _instance;

        //esconde construtor
        protected ConexaoBD()
        {

        }

        // método que retorna sigleton
        public static ConexaoBD Instance()
        {
            if (_instance == null)
                _instance = new ConexaoBD();

            return _instance;           
        }

        public string stringConexao { get; set; }
        public void Open()
        {
            Console.WriteLine($"Abrindo Conexão: {stringConexao}");
        }
    }
}
