using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_
{
    internal class Centimeter: Meter
    {
        static double p = Math.Pow(10, -2);
        public Centimeter()
        {
            a = 1;
            b = 1;
        }

        public Centimeter(double a, double b)
        {
            this.a = a / p;
            this.b = b / p;
        }

        public override string GetSides()
        {
            return a + " см " + b + " см";
        }

        public string GetSides_meters()
        {
            return (a*p) + " м " + (b *p) + " м";
        }

        public string GetArea_meters()
        {
            return ((a*p)* (b*p)) + " м";
        }

        public override string GetArea()
        {
            return (a * b) + " см";
        }

    }
}
