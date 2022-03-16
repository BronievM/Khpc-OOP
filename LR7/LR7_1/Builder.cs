using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_1
{
    interface IBuilder
    {
        void AddCP(string Name, double width, double length, string type, double time);
    }
}
