using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public class Excursion
    {
        public double price { get; set; }

        public void setPrice(double byCity)
        {
            price += museum.getPrice() + park.getPrice() + monument.getPrice() + byCity;
        }

        public Museum museum { get; set; }
        public Park park { get; set; }
        public Monument monument { get; set; }
      
    }
}
