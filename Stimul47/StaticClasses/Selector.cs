using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stimul47.StaticClasses
{
    internal static class Selector
    {
        /// <summary>
        /// Выбор папки
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


        /// <summary>
        /// Выбрать файл который нужно открыть
        /// </summary>
        /// <param name="filter">фильтр</param>
        /// <returns></returns>
        public static string ChooseFile(string filter = "All files (*.*)|*.*")
        {
            string result = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result = openFileDialog.FileName;
                }
            }
            return result;
        }

        /// <summary>
        /// Выбирает место, куда сохранить файл
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string SaveFile(string filter = "All files (*.*)|*.*")
        {
            string result = String.Empty;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = filter;
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    result = saveFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохраниения:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        /// <summary>
        /// Диалоговое окно на открытие файла
        /// </summary>
        /// <param name="path"></param>
        public static void DialogOpenFile(string path)
        {
            DialogResult result = MessageBox.Show("Файл сохранен!\nОткрыть?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Process.Start("explorer", path);
            }
        }

    }
}
