using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_S
{
    public partial class AllRoutes : Form
    {
        List<Road> roads = new List<Road>();
        public AllRoutes(List<Road> roads)
        {
            InitializeComponent();
            this.roads = roads;

            if (roads.Count == 0) dataGridView1.RowCount = 1;
            else dataGridView1.RowCount = roads.Count;

            for (int i = 0; i < roads.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = roads[i].train.number.ToString();
                dataGridView1.Rows[i].Cells[1].Value = roads[i].train.type;
                dataGridView1.Rows[i].Cells[2].Value = roads[i].train.capacity.ToString();
                dataGridView1.Rows[i].Cells[3].Value = roads[i].train.timetable.Start;
                dataGridView1.Rows[i].Cells[4].Value = roads[i].train.timetable.Destination;
                dataGridView1.Rows[i].Cells[5].Value = roads[i].dateStart;
                dataGridView1.Rows[i].Cells[6].Value = roads[i].dateEnd;
            }
        }
    }
}
