using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public class Kyiv: IAbstractFactory
    {
        public IPlace CreateMonument(string person)
        {
            return new Museum("Майдан Незалежності", 0, person);
        }
       
       public IPlace CreatePark(string Person)
        {
            return new Park("Парк ім. Гетьмана", 0, Person);
        }

        public IPlace CreateMuseum(string Person)
        {
            return new Museum("Музей української історії", 1, Person);
        }

        public Excursion CreateExcursionA(string Person)
        {
            Excursion ex = new Excursion();
            ex.monument = new Monument("Пам'ятник Перемоги", 1, Person);
            ex.park = new Park("Парк сім'ї Коцюбинських", 1, Person);
            ex.museum = new Museum("Музей української історії", 2, Person);
            ex.monument.setPrice(Person);
            ex.park.setPrice(Person);
            ex.museum.setPrice(Person);
            ex.setPrice(200);
            return ex;
        }
    }
}
