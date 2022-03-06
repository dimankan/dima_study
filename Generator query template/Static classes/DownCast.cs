using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_игры_с_дизайнером.Static_classes
{
    /// <summary>
    /// Downcast. Get object.Text in List string
    /// </summary>
    public class DownCast
    {
        /// <summary>
        /// For TextBox or ComboBox
        /// </summary>
        /// <param name="listObjet"></param>
        /// <returns></returns>
        public static List<string> ToStingFromObject(List<object> listObjet)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < listObjet.Count; i++)
            {
                if (listObjet[i] is TextBox)
                    result.Add((listObjet[i] as TextBox).Text);
                else if (listObjet[i] is ComboBox)
                    result.Add((listObjet[i] as ComboBox).Text);
            }
            return result;
        }
    }
}
