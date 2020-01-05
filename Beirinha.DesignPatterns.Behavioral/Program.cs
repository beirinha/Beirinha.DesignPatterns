using Beirinha.DesignPatterns.Behavioral.ChainOfResponsability;
using Beirinha.DesignPatterns.Behavioral.Command;
using Beirinha.DesignPatterns.Behavioral.Iterator;
using Beirinha.DesignPatterns.Behavioral.Mediator;
using Beirinha.DesignPatterns.Behavioral.Strategy;
using System;

namespace Beirinha.DesignPatterns.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Strategy

            //Console.WriteLine("Initialize Strategy");

            //long[] inputArray = new long[20];
            //Random radom = new Random();

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    inputArray[i] = radom.Next(100);
            //}

            //foreach (long number in inputArray)
            //    Console.WriteLine(number);
            //Console.ReadKey();

            ////Maneira incorreta
            ////Ordenação 1 
            ////var alg = new BubbleSort();
            ////alg.Sort(inputArray);
            ////Console.WriteLine("Números ordenados");

            ////foreach (long number in inputArray)            
            ////    Console.WriteLine(number);

            ////Console.ReadKey();

            //////Ordenação 2
            ////var alg2 = new SelectionSort();
            ////alg2.Sort(inputArray);
            ////Console.WriteLine("Números ordenados");
            ////foreach (long number in inputArray)            
            ////    Console.WriteLine(number);

            ////Console.ReadKey();


            ////Maneira refatorada
            //Context ctx = new Context(new SelectionSort());
            //ctx.ContextInterface(inputArray);
            //Console.WriteLine("Números ordenados");

            //foreach (long number in inputArray)
            //    Console.WriteLine(number);

            //Console.ReadKey();

            //Console.WriteLine("Finalize Strategy");

            //#endregion

            //#region ChainOfResponsability

            /////Chamando classe concreta
            ////Validacao validar = new Validacao();
            ////Console.WriteLine(validar.ValidateUser("Teste", "Teste").ToString());

            /////Chamando encadeamento
            //ChainOfResponsability.Formulario valform = new ChainOfResponsability.Formulario();
            //ChainOfResponsability.Server valserver = new ChainOfResponsability.Server();
            //BD valBD = new BD();

            //valform.setSucessor(valserver);
            //valserver.setSucessor(valBD);            

            //Console.WriteLine(valform.ValidateUser("Teste", "Teste").ToString());

            //#endregion

            //#region Command

            ////Configura Receiver
            //Command.Server server = new Command.Server();

            ////Cria comando configurando o receiver.
            //CommandAbstract cmd = new ServerCommand(server);
            ////Configura o Invoker
            //Command.Formulario form = new Command.Formulario();

            //form.SetCommand(cmd);
            //form.ClickValidate();
            //Console.ReadLine();

            //#endregion

            //#region Iterator

            ////Cria Concrete Aggregate
            //Equipe equipe = new Equipe();
            //equipe[0] = "Luiz";
            //equipe[0] = "Alex";
            //equipe[0] = "Rodrigo";
            //equipe[0] = "Renan";

            ////Cria Iterator
            //ConcreteIterator i = new ConcreteIterator(equipe);

            ////Iterar pela coleção
            //Console.WriteLine("Listando membros da Equipe");

            //Object item = i.First();

            //while(item != null)
            //{
            //    Console.WriteLine(item);
            //    item = i.Next();
            //}

            //Console.ReadLine();

            //#endregion

            //#region Mediator

            //ConcreteMediator concreteMediator = new ConcreteMediator();
            //Suporte suporte = new Suporte(concreteMediator);
            //Usuario usuario = new Usuario(concreteMediator);

            //concreteMediator.Suporte = suporte;
            //concreteMediator.Usuario = usuario;

            //suporte.Send("Oi Usuario");
            //usuario.Send("Formata a máquina");

            //Console.ReadLine();

            //#endregion


        }
    }
}
