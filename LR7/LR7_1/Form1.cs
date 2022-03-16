using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_1
{
    public partial class Form1 : Form
    {
        dynamic builder = new ConcreteBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            builder.AddCP("Woods_", 10, 100, "Required", 0);
            builder.AddCP("Woods U-turn", 20, 100, "Not Required",0.001);
            builder.AddCP("Woods Finish", 50, 140, "Required", 0);
            

            builder.GetAllIntoTable(dataGridView1);
        }

        private void усіНаЕкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(builder);
            f2.ShowDialog();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if ((dataGridView1.Rows[i].Cells[1].Value != null) && (dataGridView1.Rows[i].Cells[2].Value != null) && (dataGridView1.Rows[i].Cells[3].Value != null) && (dataGridView1.Rows[i].Cells[4].Value != null) && (dataGridView1.Rows[i].Cells[5].Value != null))
            {
                builder.AddCP(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), dataGridView1.Rows[i].Cells[5].Value.ToString(), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));
                builder.GetAllIntoTable(dataGridView1);
            }
        }
    }
}
