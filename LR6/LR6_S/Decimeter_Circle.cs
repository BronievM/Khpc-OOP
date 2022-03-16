using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6_S
{
    [Serializable]
    public class Decimeter_Circle: Decimeter
    {
        static double p = Math.Pow(10, -1);
        public override double a { get; set; }

        public Decimeter_Circle()
        {
            this.a = 1;
        }

        public Decimeter_Circle(double a)
        {
            this.a = a;
        }

        public double GetArea_Circle_meters()
        {
            return GetArea() * p;
        }

        public override string GetInfo()
        {
            return "Круг";
        }

        public override double GetArea()
        {
            return Math.Round((Math.PI * Math.Pow(a, 2)), 3);
        }
    }
}
