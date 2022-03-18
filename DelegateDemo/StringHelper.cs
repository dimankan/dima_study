using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int CountDelegate(string message);
    public class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }
        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }
        // Данный метод не подходит, для того чтобы расположить его в делегат
        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
}
