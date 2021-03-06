﻿using System;

namespace Beirinha.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class BD : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = false;
            ret = (name == password);
            Console.WriteLine("Validação feita pelo BD" + ret);

            //Encadeia a chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);

            return ret;
        }
    }
}
