using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    internal class ConcreteFactory
    {
        public Museum CreateMuseum()
        {
            return new ConcreteMuseum();
        }

        public Park CreatePark()
        {
            return new ConcretePark();
        }

        public Monument CreateMonument()
        {
            return new ConcreteMonument();
        }
    }
}
