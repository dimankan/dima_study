using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpButtonClick
{
    public class Inputitem
    {
        /// <summary>
        /// Тип элемента формы
        /// </summary>
        public string InputType { get; set; }
        /// <summary>
        /// Имя элемента формы
        /// </summary>
        public string InputName { get; set; }
        /// <summary>
        /// Значение элемента формы
        /// </summary>
        public string InputValue { get; set; }
        /// <summary>
        /// Форма в которой содержатся элементы
        /// </summary>
        public HtmlFormValue FormAtribute { get; set; }
    }
}
