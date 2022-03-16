using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_1
{
    public class Road
    {
        public List<Chekpoint> chekpoints = new List<Chekpoint>();

        public Road()
        {

        }

        public void AddCP(string name, double width, double length, string type, double time)
        {
            chekpoints.Add(new Chekpoint(name, width, length, type, time));
        }

        public string GetNameCP(int i)
        {
            return chekpoints[i].Name;
        }

        public double GetWidthCP(int i)
        {
            return chekpoints[i].width;
        }

        public double GetLengthCP(int i)
        {
            return chekpoints[i].length;
        }

        public double GetPenaltyCP(int i)
        {
            return chekpoints[i].timeOfPen;
        }

        public string GetTypeCP(int i)
        {
            return chekpoints[i].type;
        }

    }
}
