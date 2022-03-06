using System;

namespace Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunReflect();
        }


        static void RunReflect()
        {
            Reflect.ShowMemberInfoName("Student");

            Console.WriteLine();

            Reflect.ShowMemberInfoNameNonPublicORInstance("Student");

            Console.WriteLine();

            Reflect.ChangeField();
        }
    }
}
