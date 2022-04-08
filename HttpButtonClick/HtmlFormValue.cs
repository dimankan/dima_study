using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpButtonClick
{
    public class HtmlFormValue
    {
        public HtmlFormValue()
        {
            ListInputs = new List<Inputitem>();
        }
        /// <summary>
        /// Имя вебформы, может отсутствовать
        /// </summary>
        public string NameForm { get; set; }
        /// <summary>
        /// Oбработчик, к которому обращаются данные формы при их отправке на сервер
        /// </summary>
        public string ActionForm { get; set; }
        /// <summary>
        /// Метод который использует форма для отправки на сервер Post или Get
        /// </summary>
        public string MethodForm { get; set; }
        /// <summary>
        /// Список всех всех input Html элементов в вебформе
        /// </summary>
        public List<Inputitem> ListInputs { get; set; }
        /// <summary>
        /// Список элементов в формате 'Имя=Значение'
        /// </summary>
        /// <returns></returns>
        public List<string> GetInputsNameValue() => ListInputs
        .Select(x => $"{x.InputName}={x.InputValue}")
        .ToList();
    }
}
