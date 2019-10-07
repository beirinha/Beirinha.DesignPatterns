using Beirinha.DesignPatterns.Creational.Abstract_Factory;
using Beirinha.DesignPatterns.Creational.Bridge;
using Beirinha.DesignPatterns.Creational.Builder;
using Beirinha.DesignPatterns.Creational.Composite;
using Beirinha.DesignPatterns.Creational.Decorator;
using Beirinha.DesignPatterns.Creational.Facade;
using Beirinha.DesignPatterns.Creational.FactoryMethod;
using Beirinha.DesignPatterns.Creational.Prototype;
using Beirinha.DesignPatterns.Creational.Singleton;
using System;

namespace Beirinha.DesignPatterns.Creational
{
    public class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //#region Abstract Factory
            //Console.WriteLine("Abstract Factory initialize");

            ////Maneira incorreta
            ////SqlCommand cmd = new SqlCommand();
            ////SqlConection cnn = new SqlConection();
            ////cmd.Execute();

            ////Maneira melhorada
            //DbFactory db = new OracleFactory();
            //var con = db.createConnection();
            //con.Open();
            //var cmd = db.createCommand();
            //cmd.Execute();

            //Console.WriteLine("Abstract Factory finalize");
            //#endregion

            //#region Builder
            //Console.WriteLine("Builder initialize");

            ////Maneira incorreta, implementando diretamente na classe concreta.
            ////var carro = new Veiculo("Carro Passeio");
            ////carro["motor"] = "127c";
            ////carro["portas"] = "4";
            ////carro["pneus"] = "4";
            ////carro.Mostrar();
            ////Console.ReadLine();

            ////var moto = new Veiculo("Motocicleta");
            ////moto["motor"] = "50c";
            ////moto["portas"] = "0";
            ////moto["pneus"] = "2";
            ////moto.Mostrar();
            ////Console.ReadLine();

            ////Maneira correta
            //VeiculoBuilder builder;
            //var director = new Director();

            ////Cria produto Carro
            //builder = new CarroBuilder();
            //director.Construct(builder);
            //builder.Veiculo.Mostrar();

            ////Cria produto moto
            //builder = new MotoBuilder();
            //director.Construct(builder);
            //builder.Veiculo.Mostrar();

            //Console.WriteLine("Builder finalize");
            //#endregion

            //#region Factory
            //Console.WriteLine("Factory Method");

            ////Maneira incorreta, implementando diretamente na classe concreta.
            ////var login = new AutenticacaoGoogle();
            ////login.Autenticar();
            ////Console.ReadLine();

            ////Maneira Melhorada
            //Creator[] creators = new Creator[2];
            //creators[0] = new FacebookCreator();
            //creators[1] = new GoogleCreator();

            //foreach (Creator c in creators)
            //{
            //    Autenticacao aut = c.CriarInstancia(); //Factory Method
            //    aut.Autenticar();
            //}
            //Console.ReadLine();

            //Console.WriteLine("Factory Finalize");
            //#endregion

            //#region Prototype
            //Console.WriteLine("Prototype initialize");
            //Livro p1 = new Livro(1, "Design Patterns - Livro", 20.00);
            //Livro c1 = (Livro)p1.Clone();
            //Console.WriteLine(c1.Descricao);

            //DVD p2 = new DVD(2, "Design Patterns - DVD", 25.00);
            //DVD c2 = (DVD)p2.Clone();
            //Console.WriteLine(c2.Descricao);
            //Console.WriteLine("Prototype Finalize");
            //Console.ReadKey();
            //#endregion

            //#region Singleton
            //Console.WriteLine("Singleton");
            //var con1 = ConexaoBD.Instance();
            //con1.stringConexao = "SQLServer";
            //con1.Open();
            //var con2 = ConexaoBD.Instance();
            //con2.stringConexao = "Oracle";
            //con2.Open();

            //if (con1.Equals(con2)) 
            //    Console.WriteLine("Instancias Iguais");

            //Console.WriteLine("Singleton Finalize");
            //Console.ReadKey();
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

            //////Maneira incorreta
            ////var dec = new DataSet();
            ////dec.Write();

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

            #region Facade 

            Console.WriteLine("Facade initialize ");

            //Sem fachada
            var email = new Mail(new SMTPSettings());
            var msg = new MailMessage(new MailFormatTXT());
            msg.Message = "Olá mundo";
            email.Send(msg);
            Console.ReadKey();

            //Com Fachada
            var emailFachada = new Email();
            emailFachada.Enviar("Ola Mundo");

            Console.WriteLine("Facade finalize");
            Console.ReadKey();

            #endregion

        }
    }
}
