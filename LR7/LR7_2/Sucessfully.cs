using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_2
{
    internal class Sucessfully: Event
    {
        public override Singleton s { get; set; }
        public override string Text { get; set; }

        public override string GetEventText()
        {
            return Text;
        }

        public override string Launch()
        {
            Singleton s = Singleton.GetOcassion("Успішно!");
            return s.Value;
        }
    }
}
