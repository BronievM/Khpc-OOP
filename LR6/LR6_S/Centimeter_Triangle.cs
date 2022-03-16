using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6_S
{
    [Serializable]
    public class Centimeter_Triangle: Centimeter
    {
        static double p = Math.Pow(10, -2);
        public override double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Centimeter_Triangle()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }

        public Centimeter_Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetB()
        {
            return b * p;
        }

        public double GetC()
        {
            return c * p;
        }

        public override string GetInfo()
        {
            return "Трикутник";
        }

        public double GetArea_Triangle_meters()
        {
            return GetArea() * p;
        }

        public override double GetArea()
        {
            double per = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(per * (per - a) * (per - b) * (per - c)), 3);
        }
    }
}
