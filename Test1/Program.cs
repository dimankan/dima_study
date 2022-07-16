using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Test1
{
    #region For Reflection. Get String PropValue
    public class TestInner
    {
        public TestInner(int inner1, int inner2)
        {
            Inner1 = inner1;
            Inner2 = inner2;
        }

        public int Inner1 { get; set; }
        public int Inner2 { get; set; }
    }
    public class Test
    {
        public Test(int myProperty, int myValue, string myName)
        {
            MyProperty = myProperty;
            MyValue = myValue;
            MyName = myName;
        }

        public TestInner InnerProp { get; set; } = new TestInner(1111, 2222);
        public int MyProperty { get; set; } 
        public int MyValue { get; set; }
        public string MyName { get; set; }
    }

    #endregion
    internal class Program
    {
        
        static void Main(string[] args)
        {
            TestInner testInner = new TestInner(3, 2);
            var x = JsonSerializer.Serialize(testInner);

            Console.WriteLine(x);
            Console.WriteLine();

            Test test = new Test(3,4,"fdsf");
            var testJs = JsonSerializer.Serialize(test);
            Console.WriteLine(testJs);
        }


        
        #region RunGetPropValue
        private static void RunGetPropValue()
        {
            Test test = new Test(32, 222, "dsdsds");


            Console.WriteLine();

            string result = GetStringPropValue(test);
            result += GetStringPropValue(test);
            Console.WriteLine(result);
        }

        public static string GetStringPropValue(object obj)
        {
            string result = obj.GetType().Name + ":\n";

            PropertyInfo[] propertyInfo = obj.GetType().GetProperties();

            foreach (var item in propertyInfo)
            {
                // if(item.PropertyType == typeof(class))
                result += $"{item.Name} = {item.GetValue(obj)}; ";
            }

            return result + "\n\n";
        }

        private static void RunGeneric()
        {
            PlusShow<string>("100", "500"); // 100500
            PlusShow<int>(100, 500);        // 600
            PlusShow<bool>(true, false);    // Я не знаю что делать
        }

        #endregion
        public static void PlusShow<T>(T x, T y)
        {
            if (typeof(T) == typeof(string))
            {
                Console.WriteLine(x.ToString() + y.ToString());
            }
            else if (typeof(T) == typeof(int))
            {
                Console.WriteLine(Convert.ToInt32(x) + Convert.ToInt32(y));
            }
            else
            {
                Console.WriteLine("Я не знаю что делать");
            }
        }

     




        


        private static void RunDocSignCollection()
        {
            //Console.WriteLine(DocSignCollection.collection[0].Name);
            //Console.WriteLine(DocSignCollection.collection[0].Oper);
            //Console.WriteLine( DocSignCollection.collection.Contains());

            List<string> list = new List<string>() { "VKCaseDocSign", "VKReqDocSign", "VKBCDocSign", };

            //DocSignCollection.dictOper.Values.

            foreach (var item in DocSignCollection.dictOper)
            {
                Console.WriteLine(DocSignCollection.dictOper.Keys.ToList().IndexOf(item.Key) + $" {item.Key} {item.Value}");
            }
        }
    }
    
    public static class DocSignCollection
    {
        public static List<DocSign> collection = new List<DocSign>() { new DocSign { Name = "VKCaseDocSign", Oper = "o:RvcValutOper.o_VKCaseDocSign" }, new DocSign { Name = "VKReqDocSign", Oper = "o:RvcValutOper.o_VKReqDocSign" }, new DocSign { Name = "VKBCDocSign", Oper = "o:RvcValutOper.o_VKBCDocSign" }, new DocSign { Name = "VKCaseJourSign", Oper = "o:RvcValutOper.o_VKCaseJourSign" }, new DocSign { Name = "VKReqJourSign", Oper = "o:RvcValutOper.o_VKReqJourSign" }, new DocSign { Name = "VKBCJourSign", Oper = "o:RvcValutOper.o_VKBCJourSign" }, };


        public static Dictionary<string, string> dictOper = new Dictionary<string, string>()
        {
            {"VKCaseDocSign",   "o:RvcValutOper.o_VKCaseDocSign"},
            {"VKReqDocSign",    "o:RvcValutOper.o_VKReqDocSign" },
            {"VKBCDocSign",     "o:RvcValutOper.o_VKBCDocSign" },
            {"VKCaseJourSign",  "o:RvcValutOper.o_VKCaseJourSign" },
            {"VKReqJourSign",   "o:RvcValutOper.o_VKReqJourSign" },
            {"VKBCJourSign",    "o:RvcValutOper.o_VKBCJourSign" }

        };



    }
    //o:RvcValutOper.o_VKCaseDocSign,
    //o:RvcValutOper.o_VKReqDocSign,
    //o:RvcValutOper.o_VKBCDocSign,

    //o:RvcValutOper.o_VKCaseJourSign,
    //o:RvcValutOper.o_VKReqJourSign,
    //o:RvcValutOper.o_VKBCJourSign

    public class DocSign
    {
        public string Name { get; set; }
        public string Oper { get; set; }

    }
    class Apple
    {
        public static string operator +(Apple a, Pen b) => "ApplePen";
    }

    class Pen
    {
        public static string operator +(Pen a, Apple b) => "PenApple";
    }

    class MathHelper<T, S>
    {
        //public string Plus(T t, S s)
        //{
        //    return Sum(t, s);
        //}

        //private static string Sum(T a, S b)
        //{
        //    //return a+b;
        //}
    }

    public enum IdTask
    {
        One = 1,
        Two = 2,
        Three = 3
    }

  
}
