using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    internal class ConcretePark: Park
    {
        public double GetPrice()
        {
            return 100;
        }

        public double GetTime()
        {
            return 0.3;
        }
    }
}
