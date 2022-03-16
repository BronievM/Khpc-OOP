using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    public interface Builder
    {
        void GiveNumber();
        void GiveName(string name);
        void GiveCoord();
        void GiveTime();
    }
}
