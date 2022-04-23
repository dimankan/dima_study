using System;
using System.Linq;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 531;
            decimal result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = i * result;
            }
            string str = result.ToString();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            var re = chars.TakeWhile(x => x == '0');
            Console.WriteLine(re.Count());
        }
    }
}
