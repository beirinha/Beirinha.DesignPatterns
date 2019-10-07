namespace Beirinha.DesignPatterns.Behavioral.Strategy
{
    public abstract class BaseSort
    {
        public abstract void Sort(long[] inputArray);

        protected void Swap(ref long valOne, ref long valTwo)
        {
            valOne = valOne + valTwo;
            valTwo = valOne - valTwo;
            valOne = valOne - valTwo;
        }

        protected void SwapWithTemp(ref long valOne, ref long valTwo)
        {
            long temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
    }
}
