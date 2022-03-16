using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_S
{
    public class Train
    {
        public int number { get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        public Timetable timetable;

        public Train()
        {
            number = 0;
            type = "Купе";
            capacity = 0;
        }

        public Train(int number, string type, int capacity, Timetable timetable)
        {
            this.number = number;
            this.type = type;
            this.capacity = capacity;
            this.timetable = timetable;
        }
    }
}
