using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6_S
{
    [Serializable]
    public class Centimeter_Circle: Centimeter
    {
        static double p = Math.Pow(10, -2);
        public override double a { get; set; }

        public Centimeter_Circle()
        {
            a = 1;
        }

        public Centimeter_Circle(double a_)
        {
            a = a_;
        }

        public override string GetInfo()
        {
            return "Круг";
        }

        public double GetArea_Circle_meters()
        {
            return GetArea() * p;
        }

        public override double GetArea()
        {
            return Math.Round((Math.PI * Math.Pow(a, 2)), 3);
        }
    }
}
