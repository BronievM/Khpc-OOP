using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_
{
    internal class Decimeter_Triangle: Decimeter
    {
        static double p = Math.Pow(10, -1);
        public override double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Decimeter_Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetB()
        {
            return b*p;
        }

        public double GetC()
        {
            return c*p;
        }

        public override string GetInfo()
        {
            return "Трикутник";
        }

        public double GetArea_Triangle_meters()
        {
            double per = (((a*p)+(b*p) +(c*p))/2);
            return Math.Round(Math.Sqrt((per*(per-(a*p))*(per-(b*p))*(per-(c*p)))), 4);
        }

        public override double GetArea()
        {
            double per = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(per * (per - a) * (per - b) * (per - c)), 4);
        }
    }
}
