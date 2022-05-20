using System;
using System.Linq;

namespace CodeWars
{
    delegate int NameDelegate(int x, int y);
    delegate string NameDelegate2(string x, string y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = MyClass.SomeMethod1(222, 278);
            //Console.WriteLine(x);

            //Console.WriteLine(SomeMethod3());
            //Console.WriteLine(SomeMethod4(4,3));

            NameDelegate name = SomeMethod1;
            name += SomeMethod4;
            name += (x, y) => { return x + y; };
             NameDelegate2 name2 = (x, y) => { return x + y; }; ;


            var x = name2("2","3");
            Console.WriteLine(x);
        }
        public static int SomeMethod2()
        {
            return 3 + 5;
        }

        public static int SomeMethod3() => 3 + 5;

        public static int SomeMethod1(int x, int y)
        {
            return x + y;
        }

        public static int SomeMethod4(int x, int y) => x * y;



    }
}
