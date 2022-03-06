using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_игры_с_дизайнером.Static_classes
{
    /// <summary>
    /// Проверка на наличия данных
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Для Type
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool ForType(List<string> list)
        {
            bool result = true;
            foreach (var item in list)
            {
                if (item.Length == 0)
                    result = false;
            }
            return result;
        }
    }
}
