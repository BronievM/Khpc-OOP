using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_S
{
    internal class Centimeter : Meter
    {
        static double p = Math.Pow(10, -2);
        public override double a { get; set; }
        public Centimeter()
        {
            a = 1;
        }

        public Centimeter(double a)
        {
            this.a = a;
        }

        public double GetA_meters()
        {
            return a * p;
        }

        public override string GetInfo()
        {
            return "Квадрат";
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
