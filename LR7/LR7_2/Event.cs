using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_2
{
    public class Event
    {
        Random rnd = new Random();
        public string Name { get; set; } 
        public string Importance { get; set; } = "Виконано";
        public TimeSpan data { get; set; }

        public Event()
        {
           
        }

        public Event(TimeSpan Time)
        {
            this.data = Time;
        }

        public void SetName()
        {
            int d = rnd.Next(0, 20);

            if (d %2 == 1)
            {
                Name = "Відкриття файлу";
            }
            else if (d %2 == 0)
            {
                Name = "Збереження файлу";
            }
            else
            {
                Name = "Видалення файлу";
            }
        }
    }
}
