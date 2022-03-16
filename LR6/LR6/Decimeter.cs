using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR6
{
    [Serializable]
    public class Decimeter : Meter
    {
        
        static double p = Math.Pow(10, -1);
        public override double a { get; set; }
        public Decimeter()
        {
            a = 1;
        }

        public Decimeter(double a)
        {
            this.a = a;
        }

        public double GetA_meters()
        {
            return a * p;
        }
        public double GetArea_meters()
        {
            return (a * p) * (a * p);
        }

        public override double GetArea()
        {
            return (a * a);
        }
    }
}
