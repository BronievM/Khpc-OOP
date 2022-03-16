using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_
{
    internal class Decimeter: Meter
    {
        static double p = Math.Pow(10, -1);
        public Decimeter()
        {
            a = 1;
            b = 1;
        }

        public Decimeter(double a, double b)
        {
            this.a = a/p;
            this.b = b/p;
        }

        public override string GetSides()
        {
            return a + " дм " + b + " дм";
        }
        public string GetSides_meters()
        {
            return (a * p) + " м " + (b * p) + " м";
        }

        public string GetArea_meters()
        {
            return ((a * p) * (b * p)) + " м";
        }

        public override string GetArea()
        {
            return (a * b) + " дм";
        }
    }
}
