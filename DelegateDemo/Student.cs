using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void ShowMessageDelegate (string message);
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Идёт перемещение... Пройдено километров: {i}") ;

            }
        }
        public void Move(int distance, ShowMessageDelegate method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method($"Идёт перемещение... Пройдено километров: {i}");

            }
        }
        public void Move(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method($"Идёт перемещение... Пройдено километров: {i}");

            }
        }
    }
}
