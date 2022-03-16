using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_1
{
    public class ConcreteBuilder: IBuilder
    {
        public Road r1 = new Road();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.r1 = new Road();
        }

        public void AddCP(string Name, double width, double length, string type, double time)
        {
            if (type == "Required") time = 0;
            r1.AddCP(Name, width, length, type, time);
        }

        public double GetAllPen()
        {
            double allpen = 0;
            foreach (Chekpoint p in r1.chekpoints)
            {
                allpen += p.timeOfPen;
            }
            return allpen;
        }

        public void GetAllIntoTable(DataGridView d1)
        {
            int i = 0;

            if (r1.chekpoints.Count == 0) d1.RowCount = 1;
            else d1.RowCount = r1.chekpoints.Count + 1;

            foreach (Chekpoint p in r1.chekpoints)
            {
                d1.Rows[i].Cells[0].Value = i + 1;
                d1.Rows[i].Cells[1].Value = r1.GetNameCP(i);
                d1.Rows[i].Cells[2].Value = r1.GetWidthCP(i);
                d1.Rows[i].Cells[3].Value = r1.GetLengthCP(i);
                d1.Rows[i].Cells[4].Value = r1.GetPenaltyCP(i);
                d1.Rows[i + 1].Cells[4].Value = GetAllPen();
                d1.Rows[i].Cells[5].Value = r1.GetTypeCP(i);
                i++;
            }
            
        }

        public void GetAllText(ListBox l1)
        {
            int i = 0;
            foreach (Chekpoint p in r1.chekpoints)
            {
                l1.Items.Add(i + 1 + " | " + r1.GetNameCP(i) + " | " + r1.GetWidthCP(i) + " " + r1.GetLengthCP(i) + " | " + r1.GetPenaltyCP(i));
                i++;
            }
        }

        public Road GetRoad()
        {
            Road result = this.r1;
            Reset();
            return result;
        }
    }
}

