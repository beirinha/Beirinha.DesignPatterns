using Beirinha.DesignPatterns.Creational.Abstract_Factory;
using Beirinha.DesignPatterns.Creational.Builder;
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
            #region Abstract Factory
            Console.WriteLine("Abstract Factory initialize");

            //Maneira incorreta
            //SqlCommand cmd = new SqlCommand();
            //SqlConection cnn = new SqlConection();
            //cmd.Execute();

            //Maneira melhorada
            DbFactory db = new OracleFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();

            Console.WriteLine("Abstract Factory finalize");
            #endregion

            #region Builder
            Console.WriteLine("Builder initialize");

            //Maneira incorreta, implementando diretamente na classe concreta.
            //var carro = new Veiculo("Carro Passeio");
            //carro["motor"] = "127c";
            //carro["portas"] = "4";
            //carro["pneus"] = "4";
            //carro.Mostrar();
            //Console.ReadLine();

            //var moto = new Veiculo("Motocicleta");
            //moto["motor"] = "50c";
            //moto["portas"] = "0";
            //moto["pneus"] = "2";
            //moto.Mostrar();
            //Console.ReadLine();

            //Maneira correta
            VeiculoBuilder builder;
            var director = new Director();

            //Cria produto Carro
            builder = new CarroBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            //Cria produto moto
            builder = new MotoBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            Console.WriteLine("Builder finalize");
            #endregion

            #region Factory
            Console.WriteLine("Factory Method");

            //Maneira incorreta, implementando diretamente na classe concreta.
            //var login = new AutenticacaoGoogle();
            //login.Autenticar();
            //Console.ReadLine();

            //Maneira Melhorada
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Autenticacao aut = c.CriarInstancia(); //Factory Method
                aut.Autenticar();
            }
            Console.ReadLine();

            Console.WriteLine("Factory Finalize");
            #endregion

            #region Prototype
            Console.WriteLine("Prototype initialize");
            Livro p1 = new Livro(1, "Design Patterns - Livro", 20.00);
            Livro c1 = (Livro)p1.Clone();
            Console.WriteLine(c1.Descricao);

            DVD p2 = new DVD(2, "Design Patterns - DVD", 25.00);
            DVD c2 = (DVD)p2.Clone();
            Console.WriteLine(c2.Descricao);
            Console.WriteLine("Prototype Finalize");
            Console.ReadKey();
            #endregion

            #region Singleton
            Console.WriteLine("Singleton");
            var con1 = ConexaoBD.Instance();
            con1.stringConexao = "SQLServer";
            con1.Open();
            var con2 = ConexaoBD.Instance();
            con2.stringConexao = "Oracle";
            con2.Open();

            if (con1.Equals(con2))
                Console.WriteLine("Instancias Iguais");

            Console.WriteLine("Singleton Finalize");
            Console.ReadKey();
            #endregion           
        }
    }
}
