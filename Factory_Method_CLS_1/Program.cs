using Factory_Method_CLS_1.Examples;
using System;

namespace Factory_Method_CLS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExampleFromMetanit();

            RunExampleFromGURU();
        }

        private static void RunExampleFromGURU()
        {
            CreatorFromGURU creator = new ConcreteCreator1();
            IProduct product = creator.FactoryMethod();
            // Console.WriteLine(creator.SomeOperation()); 
            Console.WriteLine(product.Operation());

            CreatorFromGURU creator2 = new ConcreteCreator2();
            IProduct product2 = creator2.FactoryMethod();
            // Console.WriteLine(creator2.SomeOperation());
            Console.WriteLine(product2.Operation());
        }

        private static void RunExampleFromMetanit()
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house = dev.Create();
            Console.WriteLine(dev.GetType().Name + $" c именем {dev.Name} " + " построил " + house.GetType().Name);

            Console.WriteLine();

            Developer dev2 = new WoodDeveloper("Частный застройщик");
            House house2 = dev2.Create();
            Console.WriteLine(dev2.GetType().Name + $" c именем {dev2.Name} " + " построил " + house2.GetType().Name);

            Console.WriteLine();

            Developer dev3 = new HayDeveloper("Колхозные дела");
            House house3 = dev3.Create();
            Console.WriteLine(dev3.GetType().Name + $" c именем {dev3.Name} " + " построил " + house3.GetType().Name);

            Console.ReadLine();
        }
    }
}
