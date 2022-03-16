using LR1_1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace PR1_1
{
    //Coded by Broniev
    internal class Program
    {
        public static void Sort(List<Auto> cars, int size, int s)
        {
            for (int i = 0; i < size; i++)
            {
                int max_i = i;
                string max = cars[i].return_(s);
                for (int j = i + 1; j < size; j++)
                {
                    string sec = cars[j].return_(s);
                    if ((s == 1) || (s == 2) || (s == 3))
                    {

                        if (String.Compare(max, sec) > 0)
                        {
                            max_i = j;
                        }
                    }

                    else if ((s == 4) || (s == 5) || (s == 6))
                    {
                        if (int.Parse(max) > int.Parse(sec))
                        {
                            max_i = j;
                        }
                    }
                        max = cars[max_i].return_(s);
                }

                Auto cars_sort = cars[max_i];
                cars[max_i] = cars[i];
                cars[i] = cars_sort;
            }

        }

        public static void S()
        {
            Console.WriteLine("1.By manufacture");
            Console.WriteLine("2.By model");
            Console.WriteLine("3.By engine type");
            Console.WriteLine("4.By power");
            Console.WriteLine("5.By price");
            Console.WriteLine("6.By year of produce");
        }


        static void Main(string[] args)
        {
            string end = "-----------------------------------------";
            int k = 0, l = 0, year = 2022;
            //Список Авто
            List<Auto> cars = new List<Auto>();
            cars.Add(new Auto("Ford", "Model A", "Gasoline", 20, 300, 1928));
            cars.Add(new Auto("BMW", "E53", "Diesel", 250, 4000, 2006));
            cars.Add(new Auto("Tesla", "Model S", "Hybride", 300, 45000, 2015));
            cars.Add(new Auto("BMW", "M2 CS", "Gasoline", 660, 50000, 2018));
            cars.Add(new Auto("Skoda", "Octavia RS", "Gasoline", 320, 9900, 2014));
            cars.Add(new Auto("Mercedes-Benz", "A45", "Gasoline", 320, 15000, 2013));
            cars.Add(new Auto("Volkswagen", "Golf GTI", "Gasoline", 300, 30000, 2021));
            cars.Add(new Auto("Toyota", "Prius", "Hybride", 100, 7500, 2013));
            cars.Add(new Auto("Audi", "A6", "Gasoline", 220, 6000, 2008));
            cars.Add(new Auto("Nissan", "X-Trail", "Gasoline", 200, 15000, 2020));
            cars.Add(new Auto("Mitsubishi", "Lancer", "Gas/Gasoline", 120, 3000, 1998));
            cars.Add(new Auto("Daewoo", "Lanos RS", "Gas/Gasoline", 920, 30000, 2006));



            while (k != 1)
            {
                //Меню і основний код
                Console.WriteLine("_____| Menu |_____");
                Console.WriteLine("1.Add new car");
                Console.WriteLine("2.Delete car");
                Console.WriteLine("3.Show carlist");
                Console.WriteLine("4.Show car in carlist by index");
                Console.WriteLine("5.Sort");
                Console.WriteLine("6.Search");
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
                            Auto r = new Auto();
                            //Додавання авто
                            r.InputAuto();
                            cars.Add(r);
                            Console.WriteLine(end);
                            break;
                        }
                    case 2:
                        {
                            //видалення певного авто по індексу
                            int t = 0;
                            Console.WriteLine("Enter a index of car:");
                            t = Int32.Parse(Console.ReadLine());
                            t = t - 1;
                            cars.RemoveAt(t);
                            Console.WriteLine(end);
                            break;
                        }
                    case 3:
                        {
                            //Усі на екран
                            foreach (Auto p in cars)
                            {
                                p.OutAuto();
                            }
                            Console.WriteLine(end);
                            break;
                        }
                    case 4:
                        {
                            //Пошук по індексу
                            Console.WriteLine("Enter a index of car:");
                            int t = (Int32.Parse(Console.ReadLine()) - 1);
                            cars[t].OutAuto();
                            cars[t].Years(year);
                            Console.WriteLine(end);
                            break;
                        }
                    case 5:
                        {
                            //Сортування
                            int size = 0;
                            foreach (Auto p in cars)
                            {
                                size++;
                            }
                            S();
                            Console.WriteLine("Choose an option: ");
                            int s = Int32.Parse(Console.ReadLine());
                            Sort(cars, size, s);
                            Console.WriteLine(end);
                            Console.WriteLine("Finished");
                            Console.WriteLine(end);
                            break;
                        }
                    case 6:

                        {
                            Auto r = new Auto();
                            //Пошук
                            Console.WriteLine(end);
                            Console.WriteLine("Search: ");
                            S();
                            Console.WriteLine("Choose an option: ");
                            int s = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter what you choose: ");
                            string word = Console.ReadLine();
                            Console.WriteLine(end);
                            foreach (Auto p in cars)
                            {
                                p.Search(word, s);
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
                if(l != 0)
                {
                    Console.WriteLine("Press enter for return to menu: ");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

    }
}
