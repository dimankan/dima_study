using System;

namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInterface s = new FirstClass(44, "dsd", "sda");
            var x = (FirstClass)s;
            x.Show();
        }
    }

    interface IInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        void Show();
    }

    public class FirstClass : IInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public FirstClass(int x, string z, string y)
        {
            Id = x;
            Name = z;
            Family = y;
        }

        public void Show()
        {
            Console.WriteLine($"{Id}, {Name}, {Family}");
        }
    }
    public class SecondClass : IInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public SecondClass(int x, string z, string y)
        {
            Id = x;
            Name = z;
            City = y;
        }

        public void Show()
        {
            Console.WriteLine($"{Id}, {Name}, {City}");
        }
    }
}
