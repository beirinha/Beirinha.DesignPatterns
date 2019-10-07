using Beirinha.DesignPatterns.Structural.Adapter;
using System;

namespace Beirinha.DesignPatterns.Structural
{
    class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Target target = new Target();
            //Target target = new Adaptee(); //Não consigo usar o Adaptee
            Target target = new Adapter.Adapter();
            target.Request();
            Console.Read();
        }
    }
}
