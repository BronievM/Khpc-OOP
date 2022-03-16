using LR3_1;
using LR3_1.T1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace PR1_1
{
    //Coded by Broniev
    internal class Program
    {
        public static void Sort(List<AutomatedTransport> list, int size, int s)
        {
            for (int i = 0; i < size; i++)
            {
                int max_i = i;
                string max = list[i].return_(s);
                for (int j = i + 1; j < size; j++)
                {
                    string sec = list[j].return_(s);
                    if ((s == 1) || (s == 2))
                    {

                        if (String.Compare(max, sec) > 0)
                        {
                            max_i = j;
                        }
                    }

                    else if ((s == 3))
                    {
                        if (int.Parse(max) > int.Parse(sec))
                        {
                            max_i = j;
                        }
                    }
                    max = list[max_i].return_(s);
                }

                AutomatedTransport list_sort = list[max_i];
                list[max_i] = list[i];
                list[i] = list_sort;
            }
        }

        public static void S()
        {
            Console.WriteLine("1.By manufacture");
            Console.WriteLine("2.By model");
            Console.WriteLine("3.By price");
        }

        public static string getTyp(AutomatedTransport p)
        {
            if (p.GetType() == typeof(Auto)) return "Auto";
            else if (p.GetType() == typeof(Train)) return "Train";
            else if (p.GetType() == typeof(Express)) return "Express";
            else return "Automated Vehicle";
        }

        public static void Search(string word, AutomatedTransport p, int s)
        {
            if (word.Equals(p.return_(s)))
            {
                p.OutInfo();
            }
        }

        static void Main(string[] args)
        {
            string end = "-----------------------------------------";
            int k = 0, l = 0;
            //Список Авто
            List<AutomatedTransport> veh = new List<AutomatedTransport>();
            veh.Add(new AutomatedTransport("Horse wagon", "4Wheeled", 2000));
            veh.Add(new Auto("Ford", "Transit", 20000, "ВХ7777ВХ"));
            veh.Add(new Auto("Mercedes", "G65 AMG", 2000000, "G65"));
            veh.Add(new Train("VL", "10", 20000, 01));



            while (k != 1)
            {
                //Меню і основний код
                Console.WriteLine("_____| Menu |_____");
                Console.WriteLine("1.Add new vehicle");
                Console.WriteLine("2.Delete vehicle");
                Console.WriteLine("3.Show vehicle list");
                Console.WriteLine("4.Show vehicle list by type");
                Console.WriteLine("5.Show vehicle in vehicle list by index");
                Console.WriteLine("6.Sort");
                Console.WriteLine("7.Search");
                
                Console.WriteLine("0.Exit");
                Console.WriteLine(end);
                Console.WriteLine("Choose an option: ");

                l = Int32.Parse(Console.ReadLine());

                Console.WriteLine(end);
                switch (l)
                {
                    //виведення по типах
                    case 0:
                        {
                            k = 1;
                            break;
                        }
                    case 1:
                        {
                            AutomatedTransport r = new AutomatedTransport();
                            r.AddInfo();
                            veh.Add(r);
                            Console.WriteLine(end);
                            break;
                        }
                    case 2:
                        { 
                            int t = 0;
                            Console.WriteLine("Enter a index of vehicle:");
                            t = Int32.Parse(Console.ReadLine());
                            t = t - 1;
                            veh.RemoveAt(t);
                            Console.WriteLine(end);
                            break;
                        }
                    case 3:
                        {
                            foreach (AutomatedTransport p in veh)
                            {
                                p.OutInfo();
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter what you want find (Auto, Automated Vehicle, Train, Express): ");
                            string word = Console.ReadLine();
                            Console.WriteLine(end);
                            foreach (AutomatedTransport p in veh)
                            {
                                if(word.Equals(getTyp(p)))
                                {
                                    p.OutInfo();
                                }
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter a index of vehicle:");
                            int t = (Int32.Parse(Console.ReadLine()) - 1);
                            veh[t].OutInfo();
                            Console.WriteLine(end);
                            break;
                        }
                    case 6:
                        {
                            int size = 0;
                            foreach (AutomatedTransport p in veh)
                            {
                                size++;
                            }
                            S();
                            Console.WriteLine("Choose an option: ");
                            int s = Int32.Parse(Console.ReadLine());
                            Sort(veh, size, s);
                            Console.WriteLine(end);
                            Console.WriteLine("Finished");
                            Console.WriteLine(end);
                            break;
                        }
                    case 7:

                        {
                            AutomatedTransport r = new AutomatedTransport();
                            Console.WriteLine(end);
                            Console.WriteLine("Search: ");
                            S();
                            Console.WriteLine("Choose an option: ");
                            int s = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter what you choose: ");
                            string word = Console.ReadLine();
                            Console.WriteLine(end);
                            foreach (AutomatedTransport p in veh)
                            {
                               Search(word, p, s);
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
