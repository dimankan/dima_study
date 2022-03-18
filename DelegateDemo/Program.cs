using System;
using System.Linq;

namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunStringHelper();

            //RunStudentSimple();
            //RunStudentDelegate();

            //RunStudentAction();

        }



        #region 1. StringHelper

        private static void RunStringHelper()
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            //CountDelegate error = helper.GetCountSymbol;

            string testString = "LAMP";

            Console.WriteLine($"Общее количество символов: {TestDelegate(d1, testString)}");
            Console.WriteLine($"Общее количество символов A: {TestDelegate(d2, testString)}");
        }

        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
        #endregion

        #region 2.1 StudentSimple. Без делегата
        private static void RunStudentSimple()
        {
            Student student = new Student();
            student.Move(100);
        }

        #endregion
        #region 2.2. StudentDelegate
        private static void RunStudentDelegate()
        {
            Student student = new Student();
            ShowMessageDelegate method = Show;
            student.Move(8, method);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        #endregion

        //Обобщенные делегаты Action<T1,T2,T...>, Func<T1,T2,T..., T out>
        #region 2.3.1.1 Action. Без свойства.
        private static void RunStudentAction()
        {
            Student student = new Student();
            Action<string> method = Show; // Метод Show тот же что и в 2.2
            student.Move(7, method);
        } 
        #endregion



    }

   
}
