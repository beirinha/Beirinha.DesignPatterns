namespace Beirinha.DesignPatterns.Behavioral.Strategy
{
    public class SelectionSort : BaseSort
    {
        public override void Sort(long[] inputArray)
        {
            long index_of_min = 0;

            for (int iterator = 0; iterator < inputArray.Length; iterator++)
            {
                index_of_min = iterator;
                for (int index = iterator + 1; index < inputArray.Length; index++)
                {
                    if (inputArray[index] < inputArray[index_of_min])
                        index_of_min = index;
                }
                Swap(ref inputArray[iterator], ref inputArray[index_of_min]);
            }
        }

        // Pull Members UP para classe abstrata
        //private void Swap(ref long valOne, ref long valTwo)
        //{
        //    valOne = valOne + valTwo;
        //    valTwo = valOne - valTwo;
        //    valOne = valOne - valTwo;
        //}
    }
}
