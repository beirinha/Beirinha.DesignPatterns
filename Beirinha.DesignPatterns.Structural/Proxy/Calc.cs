namespace Beirinha.DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// RealSubject 
    /// </summary>
    public class Calc : ICalc
    {
        public int Somar(int x, int y)
        {
            return (x + y);
        }
    }
}
