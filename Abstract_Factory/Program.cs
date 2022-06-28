using Abstract_Factory.Examples;
using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunClassicRealistaion();

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();
        }

        private static void RunClassicRealistaion()
        {
            Client client1 = new Client(new ConcreteFactory1());
            var x = client1.abstractProductA;
            var y = client1.abstractProductB;
        }
    }

   
}
