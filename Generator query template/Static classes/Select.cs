using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_игры_с_дизайнером.Static_classes
{
    /// <summary>
    /// Выбор 
    /// </summary>
    public class Select
    {
        /// <summary>
        /// Выбор папки для сохранения
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ChooseFolder(string path)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = path;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            return path;
        }
    }
}
