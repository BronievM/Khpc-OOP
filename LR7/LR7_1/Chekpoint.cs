using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_1
{
    public class Chekpoint
    {
        public string Name { get; set; }
        public double width { get; set; }
        public double length { get; set; }
        public string type { get; set; }
        public double timeOfPen { get; set; }

        public Chekpoint()
        {
            Name = "U Turn, Woods";
            width = 0;
            length = 0;
            type = "Requied";
            timeOfPen = 0;
        }

        public Chekpoint(string Name, double width, double length, string type, double time)
        {
            this.Name = Name;
            this.width = width;
            this.length = length;
            this.type = type;
            this.timeOfPen = time;
        }
    }
}
