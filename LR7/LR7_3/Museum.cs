using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public class Museum: IPlace
    {
        public string Name { get; set; }
        public double time { get; set; }
        public string person { get; set; }
        public double price { get; set; }

        public Museum()
        {

        }

        public Museum(string Name, double time, string Person)
        {
            this.Name = Name;
            this.time = time;
            this.person = Person;
            setPrice(Person);
        }

        public void setPerson(string Person)
        {
            this.person = Person;
        }
        public void setPrice(string Person)
        {
            if (Person.Equals("Дитина"))
            {
                price = 10;
            }
            else if (Person.Equals("Студент"))
            {
                price = 15;
            }
            else if (Person.Equals("Дорослий"))
            {
                price = 20;
            }
            else if (Person.Equals("Пенсіонер"))
            {
                price = 16;
            }
        }
        public double getPrice()
        {
            return price;
        }
        public double getTime()
        {
            return 1;
        }
        public string getName()
        {
            return Name;
        }
        public string getPerson()
        {
            return person;
        }
    }
}
