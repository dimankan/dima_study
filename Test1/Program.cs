using System;
using System.Linq;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            int[] arr = {3,4,5,6};

            bool isHave = arr.Contains(x);
            Console.WriteLine(isHave);

        }
    }
}
