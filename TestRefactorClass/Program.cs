using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRefactorClass
{

    public class BaseClass
    {
        public void Log()
        {
            Console.WriteLine($"{this.GetType().Name}");
        }
    }
    public class ChildClass : BaseClass
    {

    }

    public class Program
    {
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();
            childClass.Log();
            Console.ReadKey();

        }
    }
}
