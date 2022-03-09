using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stimul47.StaticClasses
{
    internal static class XML
    {

        /// <summary>
        /// Записать данные из DataTable в txt или xml
        /// </summary>
        /// <param name="dataTable1"></param>
        public static void Get(DataTable dataTable1)
        {
            dataTable1.TableName = "DataTable";
            string path = Selector.SaveFile("txt files (*.txt)|*.txt|xml files (*.xml)|*.xml");
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                dataTable1.WriteXml(stream);
            }

            Selector.DialogOpenFile(path);
        }
    }
}
