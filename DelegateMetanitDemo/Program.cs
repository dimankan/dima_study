using System;

namespace DelegateMetanitDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //RunUseDelegate();

            //RuMethodsFromSeveralClasses();

            //RunUseOperation();

            //RunAddSeveralMethods();
            //RunDeleteSeveralMethods();

            //RunUnionDelegate();

            //RunInvoke();

            Message? mes;
            //mes();        // ! Ошибка: делегат равен null

            Operation? op = Add;
            op -= Add;      // делегат op пуст
            int n = op(3, 4);       // !Ошибка: делегат равен null

        }

        delegate void Message();
        delegate int Operation(int x, int y);

        #region StaticMethods
        static void Hello() => Console.WriteLine("Hello!");
        static void HowAreYou() => Console.WriteLine("How are you?");
        static int Add(int x, int y) => x + y;
        static int Multiply(int x, int y) => x * y;
        #endregion


        #region 1. UseDelegate

        private static void RunUseDelegate()
        {
            Message mes = Hello;
            mes();
        }

        #endregion
        #region 2. Размещение в делегат методов с других классов
        private static void RuMethodsFromSeveralClasses()
        {
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            message1(); // Welcome
            message2(); // Привет
        }
        #endregion
        #region 3. Параметры и результат делегата. Operation
        private static void RunUseOperation()
        {
            Operation operation = Add;      // делегат указывает на метод Add
            //Operation operation = new Operation(Add); // Либо так
            int result = operation(4, 5);   // фактически Add(4, 5)
            Console.WriteLine(result);      // 9

            operation = Multiply;           // теперь делегат указывает на метод Multiply
            //Operation operation = new Operation(Multiply); // Либо так
            result = operation(4, 5);       // фактически Multiply(4, 5)
            Console.WriteLine(result);      // 20
        }


        #endregion
        #region 4.1 Добавление методов в делегат
        private static void RunAddSeveralMethods()
        {
            Message message = Hello;
            message += HowAreYou;  // теперь message указывает на два метода
            message += Hello;
            message += Hello;
            message += Hello;
            message();              // вызываются оба метода - Hello и HowAreYou, столько раз, сколько было добавлено
        }
        #endregion
        #region 4.2 Удаление методов с делегата

        private static void RunDeleteSeveralMethods()
        {
            Message? message = Hello; // Используем nullable
            message += HowAreYou;
            message();  // вызываются все методы из message
            message -= HowAreYou;   // удаляем метод HowAreYou
            if (message != null) message(); // вызывается метод Hello
        }
        #endregion
        #region 5. Объединение делегатов

        private static void RunUnionDelegate()
        {
            Message mes1 = Hello;
            Message mes2 = HowAreYou;
            Message mes3 = mes1 + mes2; // объединяем делегаты
            mes3(); // вызываются все методы из mes1 и mes2
        }
        #endregion
        #region 6.1 Вызов делегата. Invoke()
        private static void RunInvoke()
        {
            //// Ранее писали
            //Message mes = Hello;
            //mes();

            //Operation op = Add;
            //int n = op(3, 4);
            //Console.WriteLine(n);

            //// Версия с INVOKE
            Message mes = Hello;
            mes.Invoke(); // Hello

            Operation op = Add;
            int n = op.Invoke(3, 4);
            Console.WriteLine(n);   // 7
        }
        #endregion
    }



}
