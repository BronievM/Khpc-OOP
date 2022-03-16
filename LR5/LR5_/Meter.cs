using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_
{
    internal abstract class Meter
    {
        public abstract double a { get; set; }
        public abstract double b { get; set; }

        public abstract string GetSides();
        public abstract string GetArea();

    }
}
