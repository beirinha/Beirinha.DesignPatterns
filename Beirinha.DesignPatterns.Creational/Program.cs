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

            //Step 1
            SqlCommand cmd = new SqlCommand();
            SqlConection cnn = new SqlConection();
            cmd.Execute();

            //Apply Abstract Factory pattern
            DbFactory db = new OracleFactory();
            var con = db.createConnection();
            con.Open();
            var command = db.createCommand();
            command.Execute();

            Console.WriteLine("Abstract Factory finalize" + Environment.NewLine);
            #endregion

            #region Builder
            Console.WriteLine("Builder initialize");

            //Step 1
            var car = new Auto("Car");
            car["gear"] = "127c";
            car["doors"] = "4";
            car["tires"] = "4";
            car.Show();
            Console.ReadLine();

            var bike = new Auto("bike");
            bike["gear"] = "50c";
            bike["doors"] = "0";
            bike["tires"] = "2";
            bike.Show();
            Console.ReadLine();

            //Apply Builder pattern
            AutoBuilder builder;
            var director = new Director();

            builder = new CarBuilder();
            director.Construct(builder);
            builder.Auto.Show();

            builder = new BikeBuilder();
            director.Construct(builder);
            builder.Auto.Show();

            Console.WriteLine("Builder finalize" + Environment.NewLine);
            #endregion

            #region Factory
            Console.WriteLine("Factory Method Initialize");

            //Step 1
            var login = new AuthGoogle();
            login.Authorize();
            Console.ReadLine();

            //Apply Factory
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Auth aut = c.CreateInstance(); //Factory Method
                aut.Authorize();
            }
            Console.ReadLine();

            Console.WriteLine("Factory Finalize" +Environment.NewLine);
            #endregion

            #region Prototype
            Console.WriteLine("Prototype initialize");
            Book p1 = new Book(1, "Design Patterns - Book", 20.00);
            Book c1 = (Book)p1.Clone();
            Console.WriteLine(c1.Description);

            DVD p2 = new DVD(2, "Design Patterns - DVD", 25.00);
            DVD c2 = (DVD)p2.Clone();
            Console.WriteLine(c2.Description);
            Console.WriteLine("Prototype Finalize" +Environment.NewLine);
            Console.ReadKey();
            #endregion

            #region Singleton
            Console.WriteLine("Singleton Initialize");
            var con1 = ConnectionBD.Instance();
            con1.stringConexao = "SQLServer";
            con1.Open();
            var con2 = ConnectionBD.Instance();
            con2.stringConexao = "Oracle";
            con2.Open();

            if (con1.Equals(con2))
                Console.WriteLine("Equals Instances");

            Console.WriteLine("Singleton Finalize" + Environment.NewLine);
            Console.ReadKey();
            #endregion           
        }
    }
}
