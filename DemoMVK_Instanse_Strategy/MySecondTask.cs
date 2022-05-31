using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVK_Instanse_Strategy
{
    /// <summary>
    /// Для второй задачи
    /// </summary>
    public class MySecondTask : TaskPatternBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public override MyDocument SetStatus(MyContext context, decimal id)
        {
            // Моя логика
            // Сменил статус
            return base.SetStatus(context, id);
        }

    }
}
