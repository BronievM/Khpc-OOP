using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_S
{
    public class Timetable
    {
        public string Start { get; set; }
        public string Destination { get; set; }

        public Timetable()
        {
            this.Start = "Київ";
            this.Destination = "Львів";
        }

        public Timetable(string st, string dest)
        {
            this.Start = st;
            this.Destination = dest;
        }
    }
}
