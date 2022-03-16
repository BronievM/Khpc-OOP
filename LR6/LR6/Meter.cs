using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR6
{
    [Serializable]
    public abstract class Meter
    {
        public abstract double a { get; set; }
        public abstract double GetArea();

    }
}
