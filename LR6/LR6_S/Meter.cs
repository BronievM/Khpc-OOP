using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6_S
{
    [Serializable]
    public abstract class Meter
    {
        public abstract double a { get; set; }
        public abstract double GetArea();
        public abstract string GetInfo();
    }
}
