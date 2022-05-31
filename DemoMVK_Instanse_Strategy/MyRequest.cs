using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVK_Instanse_Strategy
{
    public class MyRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public decimal TaskId { get; set; }

        /// <summary>
        /// Идентификатор (тип) запроса
        /// </summary>
        public decimal RequestId { get; set; }
    }
}
