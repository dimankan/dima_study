using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void ShowMessageDelegate(string message);

    // Является классом издателем, т.к. в нем создалось событие
    public class Student
    {
        /// <summary>
        /// Базовый метод, без использования делегата
        /// </summary>
        /// <param name="distance"></param>
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Идёт перемещение... Пройдено километров: {i}");

            }
        }
        /// <summary>
        /// Метод, предполагающий использование отдельно созданного делегата ShowMessageDelegate
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="method"></param>
        public void Move(int distance, ShowMessageDelegate method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method($"Идёт перемещение... Пройдено километров: {i}");

            }
        }

        /// <summary>
        /// Метод, требующий использовать обобщенный делегат Action
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="method"></param>
        public void Move(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method($"Идёт перемещение... Пройдено километров: {i}");

            }
        }

        public Action<string> Moving { get; set; }

        public void MoveByProperty(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);

                if (Moving != null)
                    Moving($"Идёт перемещение... Пройдено километров: {i}");
            }
        }

        // Событие
        public event EventHandler<MovingEventArgs> MovingPropertyEH;
        public void MoveMethodEventHandler(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);

                if (MovingPropertyEH != null)
                {
                    object sender = this;
                    var data = new MovingEventArgs($"Идёт перемещение... Пройдено километров: {i}");

                    MovingPropertyEH(sender, data);
                }
            }
        }
    }
}
