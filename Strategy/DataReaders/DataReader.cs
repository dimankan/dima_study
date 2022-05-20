using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DataReaders
{
     class DataReader
    {
        public string GetValue(IReader reader, string datas)
        {
            return reader.GetValue(datas);
        }
    }
}
