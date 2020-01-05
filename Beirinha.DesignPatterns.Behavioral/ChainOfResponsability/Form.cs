using System;

namespace Beirinha.DesignPatterns.Behavioral.ChainOfResponsability
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class Form : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = false;
            if (name != null)
                if (password != null)
                    ret = true;

            Console.Write("Validação Form: " + ret);

            //Encadeia a chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);

            return ret;
        }
    }
}
