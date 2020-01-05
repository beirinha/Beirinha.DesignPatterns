namespace Beirinha.DesignPatterns.Structural.Proxy
{
    public class CalcProxy : ICalc
    {
        //Realsubject
        private Calc _calc;

        public int Somar(int x, int y)
        {
            if(_calc == null)
            {
                _calc = new Calc();
            }
            
            return _calc.Somar(x, y);
        }
    }
}
