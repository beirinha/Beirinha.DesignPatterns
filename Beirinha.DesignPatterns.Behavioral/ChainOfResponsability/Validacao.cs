using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Validacao : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            return (name.Equals(password));
        }
    }
}
