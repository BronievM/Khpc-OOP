using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    internal class ConcreteMuseum: Museum
    {
        public double GetPrice()
        {
            return 10;
        }

        public double GetTime()
        {
            return 0.5;
        }
    }
}
