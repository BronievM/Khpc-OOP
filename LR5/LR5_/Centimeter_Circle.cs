using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_
{
    internal class Centimeter_Circle: Centimeter 
    {
        static double p = Math.Pow(10, -2);
        public override double a { get; set; }

        public Centimeter_Circle(double a)
        {
            this.a = a;
        }

        public override string GetInfo()
        {
            return "Круг";
        }

        public double GetArea_Circle_meters()
        {
            return Math.Round((Math.PI * Math.Pow(a*p, 2)), 4);
        }

        public override double GetArea()
        {
            return Math.Round((Math.PI * Math.Pow(a, 2)),4);
        }
    }
}
