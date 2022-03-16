using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6_S
{
    [Serializable]
    public class Decimeter: Meter
    {
        static double p = Math.Pow(10, -1);
        public override double a { get; set; }
        public Decimeter()
        {
            a = 1;
        }

        public Decimeter(double a_)
        {
            a = a_;
        }

        public override string GetInfo()
        {
            return "Квадрат";
        }

        public double GetA_meters()
        {
            return a * p;
        }

        public double GetArea_meters()
        {
            return GetArea() * p;
        }

        public override double GetArea()
        {
            return Math.Round(a * a, 3);
        }
    }
}
