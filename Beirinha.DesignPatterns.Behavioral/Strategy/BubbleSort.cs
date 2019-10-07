namespace Beirinha.DesignPatterns.Behavioral.Strategy
{
    public class BubbleSort : BaseSort
    {
        public  override void Sort(long[] inputArray)
        {
            for (int iterator = 0; iterator < inputArray.Length; iterator++)
            {
                for (int index = 0; index < inputArray.Length -1; index++)
                {
                    if (inputArray[index] > inputArray[index + 1])
                    {
                        Swap(ref inputArray[index], ref inputArray[index + 1]);
                    }
                }
            }
        }

        // Pull Members UP para classe abstrata
        //private void Swap(ref long valOne, ref long valTwo)
        //{
        //    valOne = valOne + valTwo;
        //    valTwo = valOne - valTwo;
        //    valOne = valOne - valTwo;
        //}

        //private void SwapWithTemp(ref long valOne, ref long valTwo)
        //{
        //    long temp = valOne;
        //    valOne = valTwo;
        //    valTwo = temp;
        //}
    }
}
