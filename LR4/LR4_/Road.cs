using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LR4_
{
    internal class Road
    {
        public Train train;
        public Timetable timetable;
        public string date;
        public string timeStart;
        public string timeDest;

        public Road(Train train, Timetable timetable, string date, string timeStart ,string timeDest)
        {
            this.train = train;
            this.timetable = timetable;
            this.date = date;
            this.timeStart = timeStart;
            this.timeDest = timeDest;
        }
    }
}
