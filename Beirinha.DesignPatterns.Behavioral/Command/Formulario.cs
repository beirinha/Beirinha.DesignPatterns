using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Formulario
    {

        private CommandAbstract _command;

        public void SetCommand(CommandAbstract command)
        {
            this._command = command;
        }

        public void ClickValidate()
        {
            Console.WriteLine("Invoker Atuando");
            _command.Execute();
        }
    }
}
