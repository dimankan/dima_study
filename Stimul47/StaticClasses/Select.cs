using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stimul47.StaticClasses
{
    internal static class Select
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


        /// <summary>
        /// Выбрать файл
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string Method(string filter = "All files (*.*)|*.*")
        {
            string result = string.Empty;

            //var fileContent = string.Empty;
            //var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = path;
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = filter;
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result = openFileDialog.FileName;
                    ////Get the path of specified file
                    //filePath = openFileDialog.FileName;

                    ////Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
            return result;
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
    }
}
