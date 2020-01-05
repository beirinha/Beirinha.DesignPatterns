using System;
using Beirinha.DesignPatterns.Creational.Bridge;
using Beirinha.DesignPatterns.Creational.Composite;
using Beirinha.DesignPatterns.Creational.Decorator;
using Beirinha.DesignPatterns.Creational.Facade;
using Beirinha.DesignPatterns.Structural.Adapter;
using Beirinha.DesignPatterns.Structural.Flyweight;
using Beirinha.DesignPatterns.Structural.Proxy;


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
            #region Adapter

            Console.WriteLine("Adapter initialize ");

            Target target = new Target();
            Target target2 = new Adaptee(); 

            Target target3 = new Adapter.Adapter();
            target.Request();
            Console.ReadKey();

            Console.WriteLine("Adapter Finalize " + Environment.NewLine);

            #endregion

            #region Bridge

            Console.WriteLine("Bridge initialize ");

            //Step 1
            ExportationBridge exp = new ExportationDOC();
            exp.Export();

            //Apply Brige Pattern
            Exportation exportacao = new ExportationEx();

            //Inject object
            exportacao.Implementor = new ExportationPDF();
            exportacao.Export();

            Console.WriteLine("Bridge finalize" + Environment.NewLine);
            Console.ReadKey();

            #endregion

            #region Composite

            Console.WriteLine("Composite initialize");

            var form = new Form("Cadastro Clientes");
            form.Add(new Button("Incluir"));
            form.Add(new Button("Consultar"));
            form.Add(new TextBox("Nome"));
            form.Add(new TextBox("Fone"));
            form.Display();

            Console.WriteLine("Composite finalize" + Environment.NewLine);
            Console.ReadKey();

            #endregion

            #region Decorator 

            Console.WriteLine("Decorator initialize");

            //Step 1
            var dec = new DataSet();
            dec.Write();

            //Apply Decorator
            DataSet c = new DataSet();            
            DataSetConcreteDecorator d = new DataSetConcreteDecorator();

            //Setando objeto a ser decorado
            d.setDatasetbase(c);
            d.Write();
            d.WriteXML();

            Console.WriteLine("Decorator finalize" + Environment.NewLine);
            Console.ReadKey();

            #endregion

            #region Facade 

            Console.WriteLine("Facade initialize");

            //Step 1
            var email = new Mail(new SMTPSettings());
            var msg = new MailMessage(new MailFormatTXT());
            msg.Message = "Hello world";
            email.Send(msg);
            Console.ReadKey();

            //Apply Facade pattern
            var emailFachada = new Email();
            emailFachada.Send("Hello world");

            Console.WriteLine("Facade finalize");
            Console.ReadKey();

            #endregion

            #region Flyweight

            Console.WriteLine("Flyweight initialize");

            int ext = 10;

            FlyweightFactory factory = new FlyweightFactory();
            FlyweightAbstract f1 = factory.GetFlyweight("A");
            f1.Operation(ext++);
            FlyweightAbstract f2 = factory.GetFlyweight("B");
            f2.Operation(ext++);
            FlyweightAbstract f3 = factory.GetFlyweight("C");
            f3.Operation(ext++);
            FlyweightAbstract f4 = new UnsharedConcreteFlyweight();
            f4.Operation(ext++);

            Console.WriteLine("Flyweight finalize" + Environment.NewLine);
            Console.ReadKey();

            #endregion

            #region Proxy

            Console.WriteLine("Proxy initialize");

            //Step 1
            var calc = new Calc();
            var r = calc.Somar(3, 5);
            Console.WriteLine(r.ToString());
            Console.ReadLine();

            //Aplly Proxy Pattern
            var calcProxy = new CalcProxy();
            var r2 = calcProxy.Somar(3, 5);
            Console.WriteLine(r2.ToString());

            Console.WriteLine("Proxy finalize" + Environment.NewLine);
            Console.ReadLine();

            #endregion
                       
        }
    }
}
