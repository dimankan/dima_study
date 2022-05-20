using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DataReaders
{
    class FileDataReader : IReader
    {
        public string GetValue(string datas)
        {
            if (string.IsNullOrEmpty(datas))
            {
                return string.Empty;
            }

            using( var fileReader = new StreamReader(datas))
            {
                var dataArray = fileReader.ReadToEnd().Trim()
                    .Split(new[] { '\n'}, StringSplitOptions.RemoveEmptyEntries);

                var resultValues = dataArray.Select((x, i) => $"{i + 1}: {x}");
                return String.Join("\n", resultValues);
            }
        }
    }
}
