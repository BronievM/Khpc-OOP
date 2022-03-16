using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LR2_1
{
    public class Figure
    {
        protected double a;
        protected double b;
        public Figure()
        {
            a = 1;
            b = 1;
        }

        public Figure(double a_, double b_)
        {
            a = a_;
            b = b_;
        }

        public void InputFigure()
        {
                Console.WriteLine("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
        }

        public void OutFigure()
        {
            Console.WriteLine("| " + "Figure" + " | Perim: " + Per() + " Square: " + Area() + " Sides: " + a + ", " + b + " |");
        }

        public double Per()
        {
            return (a + b);
        }

        public double Area()
        {
            return (a * b);
        }

    }

    public class Rectangle : Figure
    {
        public Rectangle()
        {
            a = 1;
            b = 1;
        }
        public Rectangle(double A, double B)
        {
            a = A;
            b = B;
        }

        public double Per_rect()
        {
            return Math.Round((a + b), 2);
        }

        public double Area_rect()
        {
            return Math.Round((a * b), 2);
        }

        public void AddRectangle()
        {
            Console.WriteLine("Enter a:");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Double.Parse(Console.ReadLine());
        }
        public void OutRectangle()
        {
            Console.WriteLine("| " + "Rectangle" + " | Perim: " + Per_rect() + " Square: " + Area_rect() + " Sides: " + a + ", " + b + " |");
        }
    }

    public class Triangle : Figure
    {
        private double c;
        double p;

        public Triangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            p = (a + b + c) / 2;
        }

        public double Per_trian()
        {
            return Math.Round((a + b + c), 2);
        }

        public double Area_trian()
        {
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public void AddTriangle()
        {
            Console.WriteLine("Enter a:");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Double.Parse(Console.ReadLine());
        }
        public void OutTriangle()
        {
            Console.WriteLine("| " + "Triangle" + " | Perim: " + Per_trian() + " Square: " + Area_trian() + " Sides: " + a + ", " + b + ", " + c + " |");
        }
    }

    public class Circle : Figure
    {
        public Circle()
        {
            a = 1;
        }
        public Circle(double radius)
        {
            a = radius;
        }

        public double Per_circ()
        {
            return Math.Round(Math.PI * 2 * a, 2);
        }

        public double Area_circ()
        {
            return Math.Round(Math.PI * Math.Pow(a, 2), 2);
        }

        public void AddCircle()
        {
            Console.WriteLine("Enter radius:");
            a = Double.Parse(Console.ReadLine());
        }

        public void OutCirlce()
        {
            Console.WriteLine("| " + "Circle" + " | Perim: " + Per_circ() + " Square: " + Area_circ() + " Radius: " + a + " |");
        }
    }
}
