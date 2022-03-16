using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR7_2
{
    public class Singleton
    {
        private static Singleton ocassion;
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (ocassion == null)
            {
                ocassion = new Singleton();
            }
            return ocassion;
        }

        public string Protocol(Event ev)
        {
            return ev.Name + " | " + ev.Importance + " | " + ev.data;
        }

    }

}
