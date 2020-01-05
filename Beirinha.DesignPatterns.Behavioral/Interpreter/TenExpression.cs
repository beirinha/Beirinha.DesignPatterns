namespace Beirinha.DesignPatterns.Behavioral.Interpreter
{
    public class TenExpression : Expression
    {
        /// <summary>
        /// A 'TerminalExpression' class
        /// <remarks>
        /// Ten checks for X, XL, L and XC
        /// </remarks>
        /// </summary>
        /// <returns></returns>
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }
}
