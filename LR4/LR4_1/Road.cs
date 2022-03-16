using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_1
{
    public class Road
    {
        public Train train = new Train();
        public Timetable timetable = new Timetable();

        public Road(Train train, Timetable timetable)
        {
            this.train = train;
            this.timetable = timetable;
        }


    }
}
