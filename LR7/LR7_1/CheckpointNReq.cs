using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_1
{
    class CheckpointNReq: Chekpoint
    {
        public double timeOfPen { get; set; }

        public CheckpointNReq()
        {
            Name = "Woods";
            width = 0;
            length = 0;
            timeOfPen = 0.0015;
        }

        public CheckpointNReq(string Name, double width, double length, double Pen)
        {
            this.Name = Name;
            this.width = width;
            this.length = length;
            this.timeOfPen = Pen;
        }

        public double GetPenalty()
        {
            return timeOfPen;
        }
        public double AddPen()
        {
            return timeOfPen;
        }
    }
}
