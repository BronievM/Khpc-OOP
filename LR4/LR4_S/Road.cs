using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_S
{
    public class Road
    {
        public Train train;
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public Road()
        {
            dateStart = new DateTime(2022, 7, 20, 18, 30, 25);
            dateEnd = new DateTime(2022, 7, 21, 09, 30, 25);
        }

        public Road(Train train, DateTime dateStart, DateTime dateEnd)
        {
            this.train = train;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }
    }
}
