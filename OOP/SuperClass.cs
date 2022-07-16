using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class SuperClass
    {
        private string superPhone = "8 (800) 555-35-35";
        public void superShowPhone()
        {
            Console.WriteLine(superPhone);
        }
    }

    class Class1 : SuperClass { }
    class Class2 : SuperClass { }
    class Class3 : SuperClass { }
    // .............
    class Class100500 : SuperClass { }

}
