using System;
using System.Text.Json;

namespace ExceptionMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Two two = new Two(3);
            try
            {
                two.ShowEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                //var x = JsonSerializer.Serialize(ex);
                //Console.WriteLine(x);
            }
        }



    }
    public record One(string x, string y)
    {
        public void Show()
        {
            throw new NotImplementedException();
        }
    }
    public record Two
    {
        public Two(int myProperty)
        {
            MyProperty = myProperty;
            One = new One("21", "sasd");
        }

        public int MyProperty { get; set; }
        public One One{ get; set; }

        public void ShowEx()
        {
            One.Show();
        }
    }
}
#region Trash
/*
using System;

namespace ExceptionMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionExample();
        }

        private static void ExceptionExample()
        {
            OneClass oneClass = new OneClass();
            oneClass.Id = 1;

            try
            {
                oneClass.Show();
            }
            catch (OneIdException)
            {
                //Console.WriteLine("Обработка ошибки при 1");
                try
                {
                    throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Перехваченная общая ошибка 2");
                    Console.WriteLine("Msg: " + ex.Message);
                    Console.WriteLine("Trace: " + ex.StackTrace);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Перехваченная общая ошибка");
            }
        }

    }
    public class OneIdException : Exception { }
    public class OneClass
    {
        public int Id { get; set; }
        public void Show()
        {
            if (Id == 1)
            {
                throw new OneIdException();
            }

            Console.WriteLine(Id);
        }
    }
}*/
#endregion