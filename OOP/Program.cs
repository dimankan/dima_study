using OOP.Upcasting;
using System;

namespace OOP
{

    public class Parrent
    {
        public void Show()
        {
            Console.WriteLine("Вызван базовый класс");
        }
    }
    public class Child : Parrent
    {
        public new void Show()
        {
            Console.WriteLine("Вызван дочерний класс");
        }
    }

    public class Program
    {
        public void ShowPhone()
        {
            Console.WriteLine("8 (800) 555-35-35");
        }

        // Перегрузка метода - Ad-Hoc полиморфизм
        public void ShowPhone(string phone)
        {
            Console.WriteLine(phone);
        }

        static void Main(string[] args)
        {
            // Upcast
            if (true)
            {
                Employee employee = new Employee("Tom", "Microsoft");

                // 0.1. Присвоенние экземпляра наследника к родительскому типу
                Person person0 = (Person)employee;   // преобразование от Employee к Person
                Person person = employee;   // преобразование от Employee к Person

                // 0.2. Использование конструктора наследника
                Person bob = new Client("Bob", "ContosoBank");

                // 1. Явное преобразование
                Person bobExplicit = (Person)employee;

                object person1 = new System.String("example string");  // от Employee к object
                var person11 = new System.Int32();  // от Employee к object
                person11 = 33;
                int x = 4;
                object person22 = x;  // от Employee к object
                object person2 = new Client("Bob", "ContosoBank");  // от Client к object
                object person3 = new Person("Sam");                 // от Person к object

            }
            else if(true)
            {
                // Downcast

                Employee employee = new Employee("Tom", "Microsoft");
                Person person = employee;   // преобразование от Employee к Person

                // 1. Явное преобразование
                Employee employee2 = (Employee)person;
            }
        }

        private static void RunParrentAndChild()
        {
            Parrent baseClass = new Parrent();
            baseClass.Show(); // "Вызван базовый класс"

            Child child = new Child();
            child.Show();     // "Вызван дочерний класс"
        }
    }

    class Phone
    {


        public void ShowPhone()
        {
            Console.WriteLine("8 (800) 555-35-35");
        }

        // Перегрузка метода - Ad-Hoc полиморфизм
        public void ShowPhone(string phone)
        {
            Console.WriteLine(phone);
        }


        public (T, T) Swap<T>(T x, T y)
        {
            return (y, x);
        }
    }




}
