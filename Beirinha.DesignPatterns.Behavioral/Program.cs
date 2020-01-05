using System;
using System.Collections.Generic;
using Beirinha.DesignPatterns.Behavioral.ChainOfResponsability;
using Beirinha.DesignPatterns.Behavioral.Command;
using Beirinha.DesignPatterns.Behavioral.Interpreter;
using Beirinha.DesignPatterns.Behavioral.Iterator;
using Beirinha.DesignPatterns.Behavioral.Mediator;
using Beirinha.DesignPatterns.Behavioral.Memento;
using Beirinha.DesignPatterns.Behavioral.Observer;
using Beirinha.DesignPatterns.Behavioral.State;
using Beirinha.DesignPatterns.Behavioral.Strategy;
using Beirinha.DesignPatterns.Behavioral.Template_Method;
using Beirinha.DesignPatterns.Behavioral.Visitor;

namespace Beirinha.DesignPatterns.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            //First Step
            Console.WriteLine("Initialize Strategy");

            long[] inputArray = new long[20];
            Random radom = new Random();

            for (int strategy = 0; strategy < inputArray.Length; strategy++)
            {
                inputArray[strategy] = radom.Next(100);
            }

            foreach (long number in inputArray)
                Console.WriteLine(number);
            Console.ReadKey();

            //Second Step
            //Strategy 1
            var alg = new BubbleSort();
            alg.Sort(inputArray);
            Console.WriteLine("sort numbers");

            foreach (long number in inputArray)
                Console.WriteLine(number);

            Console.ReadKey();

            //Strategy 2
            var alg2 = new SelectionSort();
            alg2.Sort(inputArray);
            Console.WriteLine("sort numbers");
            foreach (long number in inputArray)
                Console.WriteLine(number);

            Console.ReadKey();

            //Apply Strategy Patterns
            Strategy.Context ctx = new Strategy.Context(new SelectionSort());
            ctx.ContextInterface(inputArray);
            Console.WriteLine("sort numbers");

            foreach (long number in inputArray)
                Console.WriteLine(number);

            Console.ReadKey();
            Console.WriteLine("Finalize Strategy" + Environment.NewLine);

            #endregion

            #region ChainOfResponsability

            Console.WriteLine("ChainOfResponsability Initialize");

            // First Step
            Validate validate = new Validate();
            Console.WriteLine(validate.ValidateUser("Test", "Test").ToString());

            ///Apply ChainOfResponsability pattern
            ChainOfResponsability.Form valform = new ChainOfResponsability.Form();
            ChainOfResponsability.Server valserver = new ChainOfResponsability.Server();
            BD valBD = new BD();

            valform.setSucessor(valserver);
            valserver.setSucessor(valBD);

            Console.WriteLine(valform.ValidateUser("Teste", "Teste").ToString());

            Console.WriteLine("ChainOfResponsability Finalize" + Environment.NewLine);

            #endregion

            #region Command

            Console.WriteLine("Command Initialize");

            //Configure Receiver
            Command.Server server = new Command.Server();

            //Create command and configure receiver.
            CommandAbstract cmd = new ServerCommand(server);

            //Configure invoker
            Command.Formulario form = new Command.Formulario();

            form.SetCommand(cmd);
            form.ClickValidate();
            Console.WriteLine("Command Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Iterator

            Console.WriteLine("Iterator Initialize");

            //Create concrete aggregate
            Team team = new Team();
            team[0] = "Luiz";
            team[0] = "Alex";
            team[0] = "Rodrigo";
            team[0] = "Renan";

            ConcreteIterator i = new ConcreteIterator(team);

            Console.WriteLine("Show team's members");

            Object item = i.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.WriteLine("Iterator Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Mediator

            Console.WriteLine("Mediator Initialize");

            ConcreteMediator concreteMediator = new ConcreteMediator();
            Support support = new Support(concreteMediator);
            User user = new User(concreteMediator);

            concreteMediator.Suporte = support;
            concreteMediator.Usuario = user;

            support.Send("Hello user");
            user.Send("Hello support");

            Console.WriteLine("Mediator Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Memento

            Console.WriteLine("Memento Initialize");

            //Create originator
            Originator people = new Originator();
            people.State = "Bored";

            //Create caretaker
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = people.CreateMemento();

            people.State = "Happy";
            Console.WriteLine("Actual State:" + people.State);

            people.setMemento(caretaker.Memento);
            Console.WriteLine("Restore State: " + people.State);

            Console.WriteLine("Memento Finalize" + Environment.NewLine);

            #endregion

            #region Observer

            Console.WriteLine("Observer Initialize");

            Balance balanco = new Balance();
            Sale venda = new Sale(balanco);

            balanco.Attach(venda);

            balanco.Iniciar();
            balanco.Notify();

            balanco.Finalizar();
            balanco.Notify();

            venda.Iniciar();

            //After remove observer
            balanco.Detach(venda);

            balanco.Iniciar();
            balanco.Notify();

            venda.Iniciar();

            Console.WriteLine("Observer Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region State

            Console.WriteLine("State Initialize");

            Connection connection = new Connection(new ConnectionOpened());

            connection.Open();
            connection.Close();

            Console.WriteLine("State Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Template Method

            Console.WriteLine("Template Method Initialize");

            Correction proofCorrecion = new ProofCorrection();
            proofCorrecion.Process();

            Correction writingCorrection = new WritingCorrection();
            writingCorrection.Process();

            Console.WriteLine("Template Method Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Visitor

            Console.WriteLine("Visitor Initialize");

            //Config structure
            ObjectStructure objectStructure = new ObjectStructure();

            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            //Create Visitors
            ConcreteVisitor1 concreteVisitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 concreteVisitor2 = new ConcreteVisitor2();

            objectStructure.Accept(concreteVisitor1);
            objectStructure.Accept(concreteVisitor2);

            Console.WriteLine("Visitor Finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion

            #region Interpreter

            Console.WriteLine("Interpreter Initialize");

            string roman = "MCMXXVIII";
            Interpreter.Context context = new Interpreter.Context(roman);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            Console.WriteLine("Interpreter Finalize" + Environment.NewLine);
            Console.ReadKey();

            #endregion
        }
    }
}
