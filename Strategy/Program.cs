using Strategy.DataReaders;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();
            Console.WriteLine(dataReader.GetValue(new StringDataReader(), "Firrs\nsecond\nthirt"));
            Console.WriteLine("===========");
            Console.WriteLine(dataReader.GetValue(new FileDataReader(), @"C:\Users\ASUS\OneDrive\Рабочий стол\11.txt"));   

        }
    }
}
