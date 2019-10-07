using Beirinha.DesignPatterns.Creational.Bridge;
using Beirinha.DesignPatterns.Creational.Composite;
using Beirinha.DesignPatterns.Creational.Decorator;
using Beirinha.DesignPatterns.Creational.Facade;
using Beirinha.DesignPatterns.Structural.Adapter;
using Beirinha.DesignPatterns.Structural.Flyweight;
using Beirinha.DesignPatterns.Structural.Proxy;
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
            //#region Adapter

            ////Target target = new Target();
            ////Target target = new Adaptee(); //Não consigo usar o Adaptee
            //Target target = new Adapter.Adapter();
            //target.Request();
            //Console.Read();

            //#endregion

            //#region Bridge

            //Console.WriteLine("Bridge initialize ");

            ////Maneira incorreta
            ////Exportacao exp = new ExportacaoDOC();
            ////exp.Exportar();

            ////Maneira melhorada, usando a Exportacao refinada
            //Exportacao exportacao = new ExportacaoEx();

            ////Injetando o objeto de implementação
            //exportacao.Implementor = new ExportacaoPDF();
            //exportacao.Exportar();

            //Console.WriteLine("Bridge finalize");
            //Console.ReadKey();

            //#endregion

            //#region Composite

            //Console.WriteLine("Composite initialize ");

            //var form = new Formulario("Cadastro Clientes");
            //form.Add(new Button("Incluir"));
            //form.Add(new Button("Consultar"));
            //form.Add(new TextBox("Nome"));
            //form.Add(new TextBox("Fone"));
            //form.Display();

            //Console.WriteLine("Composite finalize");
            //Console.ReadKey();

            //#endregion

            //#region Decorator 

            //Console.WriteLine("Decorator initialize ");

            ////Maneira incorreta
            //var dec = new DataSet();
            //dec.Write();

            //DataSet c = new DataSet();
            ////Cria decorator.
            //DataSetConcreteDecorator d = new DataSetConcreteDecorator();

            ////Setando objeto a ser decorado
            //d.setDatasetbase(c);
            //d.Write();
            //d.WriteXML();

            //Console.WriteLine("Decorator finalize");
            //Console.ReadKey();

            //#endregion

            //#region Facade 

            //Console.WriteLine("Facade initialize ");

            ////Sem fachada
            //var email = new Mail(new SMTPSettings());
            //var msg = new MailMessage(new MailFormatTXT());
            //msg.Message = "Olá mundo";
            //email.Send(msg);
            //Console.ReadKey();

            ////Com Fachada
            //var emailFachada = new Email();
            //emailFachada.Enviar("Ola Mundo");

            //Console.WriteLine("Facade finalize");
            //Console.ReadKey();

            //#endregion

            //#region Flyweight

            //int ext = 10;

            //FlyweightFactory factory = new FlyweightFactory();
            //FlyweightAbstract f1 = factory.GetFlyweight("A");
            //f1.Operation(ext++);
            //FlyweightAbstract f2 = factory.GetFlyweight("B");
            //f2.Operation(ext++);
            //FlyweightAbstract f3 = factory.GetFlyweight("C");
            //f3.Operation(ext++);
            //FlyweightAbstract f4 = new UnsharedConcreteFlyweight();
            //f4.Operation(ext++);

            //Console.ReadKey();

            //#endregion

            #region Proxy

            //Maneira chamando classe Concreta.
            var calc = new Calc();
            var r = calc.Somar(3, 5);
            Console.WriteLine(r.ToString());
            Console.ReadLine();

            //Maneira com Proxy
            var calcProxy = new CalcProxy();
            var r2 = calcProxy.Somar(3, 5);
            Console.WriteLine(r2.ToString());
            Console.ReadLine();

            #endregion
                       
        }
    }
}
