using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_2
{
    public partial class Form1 : Form
    {
        public List<Event> events = new List<Event>();
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateEV(int i)
        {
            int count = 0;
            if (events.Count <= 0) count = 0;
            else count = events.Count;
            for (int j = count; j < count+i; j++)
            {
                TimeSpan Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                events.Add(new Event(Time));
                events[j].SetName();

                dataGridView1.RowCount++;
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = events[j].Name;
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = events[j].data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            CreateEV(num);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            listBox1.Items.Add(Singleton.GetInstance().Protocol(events[ind]));
        }
    }
}
