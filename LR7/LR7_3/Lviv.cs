using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public class Lviv: IAbstractFactory
    {
        public IPlace CreateMonument(string Person)
        {
            return new Museum("Львіська писанка", 1, Person);
        }
       
       public IPlace CreatePark(string Person)
        {
            return new Park("Лісовий парк", 0.5, Person);
        }

        public IPlace CreateMuseum(string Person)
        {
            return new Museum("Львіський музей історії", 1, Person);
        }

        public Excursion CreateExcursionA(string Person)
        {
            Excursion ex = new Excursion();
            ex.monument = new Monument("Львіський архітектор", 1, Person);
            ex.park = new Park("Парк культури", 1, Person);
            ex.museum = new Museum("Архітектурна галерея мистецтв", 2, Person);
            ex.monument.setPrice(Person);
            ex.park.setPrice(Person);
            ex.museum.setPrice(Person);
            ex.setPrice(250);
            return ex;
        }
    }
}
