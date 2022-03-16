using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_3
{
    public interface IAbstractFactory
    {
        IPlace CreateMuseum(string Person);
        IPlace CreatePark(string Person);
        IPlace CreateMonument(string Person);
        Excursion CreateExcursionA(string Person);
    }
}
