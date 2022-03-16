using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace LR1_1
{
    internal class Auto
    {
        //Атрибути
        private string Manufacture;
        private string Model;
        private string Engine;
        private int Power;
        private float Price;
        private int YearOfProd;

    //Конструктори
    public Auto()
        {
            Manufacture = "None";
            Model = "None";
            Engine = "None";
            Power = 20;
            Price = 1000;
            YearOfProd = 1927;
        }

        public Auto(string manufacture, string md, string eng, int power, int price, int YOP)
        {
            Manufacture = manufacture;
            Model = md;
            Engine = eng;
            Power = power;
            Price = price;
            YearOfProd = YOP;
        }

        //Методи
        public void InputAuto()
        {
            Console.WriteLine("Enter manufacture of car: ");
            Manufacture = Console.ReadLine();
            Console.WriteLine("Enter model of car: ");
            Model = Console.ReadLine();
            Console.WriteLine("Enter engine type/name: ");
            Engine = Console.ReadLine();
            Console.WriteLine("Enter power: ");
            Power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year of produce: ");
            YearOfProd = Convert.ToInt32(Console.ReadLine());
        }
        public void OutAuto()
        {
            Console.WriteLine("| " + Manufacture + " " + Model + " | " + Engine + " " + Power.ToString() + " hp | " + Price.ToString() + "$ " + YearOfProd + " |");
        }


        public void Search(string w, int be)
        {
            switch(be)
            {
                case 1:
                    {
                        if (Manufacture.Equals(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                case 2:
                    {
                        if (Model.Equals(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                case 3:
                    {
                        if (Engine.Equals(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                case 4:
                    {
                        if (Power == Int32.Parse(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                case 5:
                    {
                        if (Price == Int32.Parse(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                case 6:
                    {
                        if (YearOfProd == Int32.Parse(w))
                        {
                            OutAuto();
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Sorry, i can't find it. Try again.");
                        break;
                    }
            }     
        }

        public string return_(int s)
        {
            switch (s)
            {
                case 2: return Model;
                case 3: return Engine;
                case 4: return Power.ToString();
                case 5: return Price.ToString();
                case 6: return YearOfProd.ToString();
                default: return Manufacture;
            }
        }


        public void Years(int year)
        {
            Console.WriteLine("| Car produced " + (year - YearOfProd) + " years ago");
        }
    }
}
