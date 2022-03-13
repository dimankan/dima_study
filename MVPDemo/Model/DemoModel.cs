using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Model
{
    public class DemoModel
    {
        // data
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }

        public int Result { get; private set; }

        // business logic
        public void Sum()
        {
            Result = Operand1 + Operand2;
        }
    }
}
