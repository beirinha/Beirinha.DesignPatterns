using System;

namespace Beirinha.DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class Server
    {
        public bool ValidateUser()
        {
            Console.WriteLine("Receiver Atuando");
            return true;
        }
    }
}
