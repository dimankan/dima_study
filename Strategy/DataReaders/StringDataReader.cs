using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DataReaders
{
    class StringDataReader : IReader
    {
        public string GetValue(string datas)
        {
            if (string.IsNullOrEmpty(datas))
            {
                return string.Empty;
            }

            
                var dataArray = datas.Trim()
                    .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var resultValues = dataArray.Select((x, i) => $"{i + 1}: {x}");
                return String.Join("\n", resultValues);
            
        }
    }
}
