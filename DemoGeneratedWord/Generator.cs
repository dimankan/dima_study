using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneratedWord
{
  
    public class Generator
    {
        public static string UniversalGenerator(int len)
        {
            string result = String.Empty;

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwxyz".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            char[] symbols = ";.,-_".ToCharArray();

            List<char> list = new List<char>();
            list.AddRange(letters);
            list.AddRange(numbers);
            list.AddRange(symbols);

            Random rand = new Random();

            for (int i = 0; i < len; i++)
            {
                result += list[rand.Next(0, list.Count - 1)];
            }

            return result;
        }




        /// <summary>
        /// Рандомное слово заданной длины
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string ConstWord(int len)
        {
            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwxyz".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();

            string result = "";

            for (int i = 0; i < len; i++)
            {
                result += letters[rand.Next(0, letters.Length - 1)];
            }
            return result;
        }

        /// <summary>
        /// Рандомные цифры заданной длины
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string ConstNumberString(int len)
        {
            // Создаем массив цифр, которые мы будем использовать.
            char[] letters = "0123456789".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();

            string result = "";

            for (int i = 0; i < len; i++)
            {
                result += letters[rand.Next(0, letters.Length - 1)];
            }
            return result;
        }
        /// <summary>
        /// Возвращает случайное число до заданного максимума
        /// </summary>
        /// <param name="maxLen"></param>
        /// <returns></returns>
        public static int RandNumber(int maxLen)
        {
            Random rand = new Random();
            int result = rand.Next(1, maxLen);
            return result;
        }
        /// <summary>
        /// Возвращает случайное слово случайной длины не превышающее максимума длины
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string RandWord(int number) => ConstWord(RandNumber(number));


    }
}
