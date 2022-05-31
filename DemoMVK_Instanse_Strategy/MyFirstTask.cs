using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVK_Instanse_Strategy
{
    /// <summary>
    /// Для одной задачи
    /// </summary>
    public class MyFirstTask : TaskPatternBase
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
            return base.SetStatus(context, id);
        }

    }
}
