using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Structural.Proxy
{
    public class CalcProxy : ICalc
    {
        //Realsubject
        private Calc _calc;

        public int Somar(int x, int y)
        {
            //Instancia por Demanda (Lazy)
            if(_calc == null)
            {
                _calc = new Calc();
            }

            //Repassando chamada ao real Subject
            return _calc.Somar(x, y);
        }
    }
}
