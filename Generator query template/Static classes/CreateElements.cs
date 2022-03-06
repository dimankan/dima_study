using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_игры_с_дизайнером.Static_classes
{
    /// <summary>
    /// Добавление элементов в форме. Возращает list<object>
    /// </summary>
    public class CreateElements
    {

        /// <summary>
        /// Создание TextBox для Алиасов. 
        /// </summary>
        /// <param name="arrayAlias"></param>
        /// <param name="f"></param>
        /// <returns>Лист с объектами</returns>
        public static List<object> Alias(string[] arrayAlias, Form f)
        {
            List<object> result = new List<object>();

            for (int i = 0, n = 44; i < arrayAlias.Length; i++, n += 25)
            {
                result.Add(new TextBox()
                {
                    Location = new System.Drawing.Point(319, n),
                    Name = $"Alias.{i}",
                    Size = new System.Drawing.Size(100, 20),
                    Text = arrayAlias[i]
                });
                f.Controls.Add(result[i] as TextBox);

            }
            return result;
        }
        /// <summary>
        /// TextBox for Fields. List object 
        /// </summary>
        /// <param name="arrayFields"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static List<object> Fields(string[] arrayFields, Form f)
        {
            List<object> result = new List<object>();
            for (int i = 0, n = 44; i < arrayFields.Length; i++, n += 25)
            {
                result.Add(new TextBox()
                {
                    Location = new System.Drawing.Point(441, n),
                    Name = $"Fields.{i}",
                    Size = new System.Drawing.Size(122, 20),
                    Text = arrayFields[i]
                });
                f.Controls.Add(result[i] as TextBox);
            }
            return result;
        }
        /// <summary>
        /// ComboBox for Type. return List object
        /// </summary>
        /// <param name="anyArray"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static List<object> Type(string[] anyArray, Form f)
        {
            List<object> result = new List<object>();
            for (int i = 0, n = 44; i < anyArray.Length; i++, n += 25)
            {

                result.Add(new ComboBox()
                {
                    DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
                    Location = new System.Drawing.Point(588, n),
                    Name = $"Type.{i}",
                    Size = new System.Drawing.Size(120, 20),
                });

                (result[i] as ComboBox).Items.AddRange(new object[] { "string", "decimal", "date" });

                f.Controls.Add(result[i] as ComboBox);

            }
            return result;
        }

    }
}
