using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_
{
    public class Timetable
    {
        public string Start { get; set; }
        public string Destination { get; set; }

        public Timetable()
        {
            Start = "Київ";
            Destination = "Львів";
        }

        public Timetable(string st, string dest)
        {
            Start = st;
            Destination = dest;
        }
    }
}
