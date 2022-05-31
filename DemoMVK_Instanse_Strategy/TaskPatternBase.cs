using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVK_Instanse_Strategy
{
    public class TaskPatternBase
    {
        public MyDocument GetDocument(MyContext context, decimal id)
        {
            // Моя реализация.
            return new MyDocument();

        }

        public virtual MyDocument SetStatus(MyContext context, decimal id)
        {
            // Установка статуса или просто заглушка

            return new MyDocument();
        }
    }


}
