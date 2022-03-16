using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_1
{
    public class Timetable
    {
        public string Start { get; set; }
        public string Destination { get; set; }
        public string TimeOnStant { get; set; }
        public string TimeFromStant { get; set; }

        public Timetable()
        {
            Start = "Київ";
            Destination = "Львів";
            TimeOnStant = "00:00";
            TimeFromStant = "00:00";
        }

        public Timetable(string st, string dest ,string TON, string TFO)
        {
            Start = st;
            Destination = dest;
            TimeOnStant = TON;
            TimeFromStant = TFO;
        }

        //public void GetTable(TextBox t1, TextBox t2, TextBox t3, TextBox t4)
        //{
        //    t1.Text = Start;
        //    t2.Text = Destination;
        //    t3.Text = TimeOnStant;
        //    t4.Text = TimeFromStant;
        //}

        //public void SetTable(TextBox t1, TextBox t2, TextBox t3, TextBox t4)
        //{
        //    Start = t1.Text;
        //    Destination = t2.Text;
        //    TimeOnStant = t3.Text;
        //    TimeFromStant = t4.Text;
        //}

    }
}
