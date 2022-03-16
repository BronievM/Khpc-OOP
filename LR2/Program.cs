using LR2_1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace LR2_1
{
    //Coded by Broniev
    internal class Program
    {
        public static void Sort(List<Figure> list, int size, int s)
        {
            for (int i = 0; i < size; i++)
            {
                int max_i = i;
                string max = list[i].GetType().ToString();
                for (int j = i + 1; j < size; j++)
                {
                    string sec = list[j].GetType().ToString();
                    if (String.Compare(max, sec) > 0 && s == 1)
                    {
                        max_i = j;
                    }

                    else if (String.Compare(max, sec) < 0 && s == 2)
                    {
                        max_i = j;
                    }
                    
                    max = list[max_i].GetType().ToString();
                }

                Figure list_sort = list[max_i];
                list[max_i] = list[i];
                list[i] = list_sort;
            }

        }

        public static void S()
        {
            Console.WriteLine("1.By type of figure (A to Z)");
            Console.WriteLine("2.By type of figure (Z to A)");
        }

        public static string Typ(Figure p)
        {

            switch (p)
            {
                case Rectangle:
                    {
                        return "Rectangle";
                    }

                case Triangle:
                    {
                        return "Triangle";
                    }
                case Circle:
                    {
                        return "Circle";
                    }
                default:
                    {
                        return "Figure";
                    }
            }



            //if (p.GetType() == typeof(Rectangle))
            //{
            //    return "Rectangle";
            //}
            //else if (p.GetType() == typeof(Triangle))
            //{
            //    return "Triangle";
            //}
            //else if (p.GetType() == typeof(Circle))
            //{
            //    return "Circle";
            //}
            //else return "Figure";
        }

        public static void Search(string word, Figure p)
        {
            if (Typ(p).Equals(word))
            {
                if (p is Rectangle)
                {
                    (p as Rectangle).OutRectangle();
                }
                else if (p is Triangle)
                {
                    (p as Triangle).OutTriangle();
                }
                else if (p is Circle)
                {
                    (p as Circle).OutCirlce();
                }
                else if (p is Figure || (p is not Triangle or Circle or Rectangle))
                {
                    (p as Figure).OutFigure();
                }
            }
        }

        static void Main(string[] args)
        {
            string end = "-----------------------------------------";
            int k = 0, l = 0;
            //Список 
            List<Figure> fig = new List<Figure>();
            fig.Add(new Circle(3));
            fig.Add(new Triangle(3, 4, 5));
            fig.Add(new Triangle(7, 9, 5));
            fig.Add(new Rectangle(4, 4));


            //Меню і основний код
           

            while (k != 1)
            {
                Console.WriteLine("_____| Menu |_____");
                Console.WriteLine("1.Add new figure");
                Console.WriteLine("2.Delete figure");
                Console.WriteLine("3.Show figure list");
                Console.WriteLine("4.Show figure in figure list by index");
                Console.WriteLine("5.Sort figure list");
                Console.WriteLine("6.Search by type of figure");
                Console.WriteLine("0.Exit");
                Console.WriteLine(end);
                Console.WriteLine("Choose an option: ");
                l = Int32.Parse(Console.ReadLine());

                Console.WriteLine(end);
                switch (l)
                {
                    case 0:
                        {
                            //Вихід з програми
                            k = 1;
                            break;
                        }
                    case 1:
                        {
                            //Додавання
                            Console.WriteLine("Enter type of figure (Triangle, Circle, Rectangle):");
                            string ty = Console.ReadLine();

                            if (ty == "Rectangle")
                            {
                                Rectangle rt = new Rectangle();
                                rt.AddRectangle();
                                fig.Add(rt);
                            }

                            else if (ty == "Triangle")
                            {
                                Triangle tr = new Triangle();
                                tr.AddTriangle();
                                fig.Add(tr);
                            }

                            else if (ty == "Circle")
                            {
                                Circle c = new Circle();
                                c.AddCircle();
                                fig.Add(c);
                            }

                            else
                            {
                                Figure f = new Figure();
                                f.InputFigure();
                                fig.Add(f);
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 2:
                        {
                            //видалення по індексу
                            Console.WriteLine("Enter a index of figure:");
                            int t = Int32.Parse(Console.ReadLine()) - 1;
                            fig.RemoveAt(t);
                            Console.WriteLine(end);
                            break;
                        }
                    case 3:
                        {
                            //Усі на екран

                            foreach (Figure p in fig)
                            {
                                if (p is Rectangle rect)
                                {
                                    rect.OutRectangle();
                                    continue;
                                }
                                if (p is Triangle trian)
                                {
                                    trian.OutTriangle();
                                    continue;
                                }
                                if (p is Circle cirl)
                                {
                                    cirl.OutCirlce();
                                    continue;
                                }
                                else p.OutFigure();
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 4:
                        {
                            Circle c = new Circle(2);
                            //Пошук по індексу
                            int t = 0;
                            Console.WriteLine("Enter a index of figure:");
                            t = Int32.Parse(Console.ReadLine());
                            t = t - 1;
                            Console.WriteLine(end);
                            if(fig[t] is Rectangle rect)
                                {
                                rect.OutRectangle();
                            }
                            if (fig[t] is Triangle trian)
                            {
                                trian.OutTriangle();
                            }
                            if (fig[t] is Circle cirl)
                            {
                                cirl.OutCirlce();
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 5:
                        {
                            //Сортування
                            Console.WriteLine("Sort: ");
                            S();
                            int size = 0;
                            foreach (Figure p in fig)
                            {
                                size++;
                            }
                            Console.WriteLine("Choose an option: ");
                            int s = Int32.Parse(Console.ReadLine());
                            Sort(fig, size, s);
                            Console.WriteLine(end);
                            Console.WriteLine("Finished");
                            Console.WriteLine(end);
                            break;
                        }
                    case 6:

                        {
                            //Пошук
                            Console.WriteLine("Enter what you want to find: ");
                            string word = Console.ReadLine();
                            Console.WriteLine(end);
                            foreach (Figure p in fig)
                            {
                                Search(word, p);
                            }
                            Console.WriteLine(end);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Try again");
                            Console.WriteLine(end);
                            break;
                        }

                }
                
                if (l != 0)
                {
                    Console.WriteLine("Press enter for return to menu: ");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
        }

    }
}
