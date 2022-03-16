using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public class Khmelnytskiy: IAbstractFactory
    {
        public IPlace CreateMonument(string Person)
        {
            return new Museum("Пам'ятник Івану Франку", 0, Person);
        }
       
       public IPlace CreatePark(string Person)
        {
            return new Park("Полісся", 0, Person);
        }

        public IPlace CreateMuseum(string Person)
        {
            return new Museum("Хмельницький музей історії фотографії", 1, Person);
        }

        public Excursion CreateExcursionA(string Person)
        {
            Excursion ex = new Excursion();
            ex.monument = new Monument("Пам'ятник Богдану Хмельницькому", 1, Person);
            ex.park = new Park("ArtPlace", 1, Person);
            ex.museum = new Museum("Музей історії міста", 2, Person);
            ex.monument.setPrice(Person);
            ex.park.setPrice(Person);
            ex.museum.setPrice(Person);
            ex.setPrice(50);
            return ex;
        }
    }
}
