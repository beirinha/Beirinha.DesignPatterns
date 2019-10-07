using Beirinha.DesignPatterns.Behavioral.Strategy;
using System;

namespace Beirinha.DesignPatterns.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            Console.WriteLine("Initialize Strategy");

            long[] inputArray = new long[20];
            Random radom = new Random();

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = radom.Next(100);
            }

            foreach (long number in inputArray)
                Console.WriteLine(number);
            Console.ReadKey();

            //Maneira incorreta
            //Ordenação 1 
            //var alg = new BubbleSort();
            //alg.Sort(inputArray);
            //Console.WriteLine("Números ordenados");

            //foreach (long number in inputArray)            
            //    Console.WriteLine(number);

            //Console.ReadKey();

            ////Ordenação 2
            //var alg2 = new SelectionSort();
            //alg2.Sort(inputArray);
            //Console.WriteLine("Números ordenados");
            //foreach (long number in inputArray)            
            //    Console.WriteLine(number);

            //Console.ReadKey();


            //Maneira refatorada
            Context ctx = new Context(new SelectionSort());
            ctx.ContextInterface(inputArray);
            Console.WriteLine("Números ordenados");

            foreach (long number in inputArray)
                Console.WriteLine(number);

            Console.ReadKey();

            Console.WriteLine("Finalize Strategy");

            #endregion
        }
    }
}
