using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Meter> list_m = new List<Meter>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            list_m.Add(new Centimeter(1, 1));
            list_m.Add(new Decimeter(3, 3));
            list_m.Add(new Centimeter(10, 10));
            list_m.Add(new Decimeter(6, 8));
            list_m.Add(new Centimeter(3, 3));
            list_m.Add(new Decimeter(1, 6));
            list_m.Add(new Centimeter(2, 3));
            list_m.Add(new Decimeter(1, 5));
            list_m.Add(new Centimeter(6, 7));
            list_m.Add(new Decimeter(9, 1));
            dataGridView2.Rows.Clear();

            int count = list_m.Count;

            if (count == 0) dataGridView2.RowCount = 1;
            else dataGridView2.RowCount = list_m.Count;

            try
            {
                int i = 0;
                foreach (Meter p in list_m)
                {
                    int i1 = p.GetSides().IndexOf(" ");
                    int i2 = p.GetSides().IndexOf(" ", i1 + 1);

                    string sa = p.GetSides().Remove(i2);
                    string sb = p.GetSides().Remove(0, i2);


                    dataGridView2.Rows[i].Cells[0].Value = sa.ToString();
                    dataGridView2.Rows[i].Cells[2].Value = sb.ToString();
                    dataGridView2.Rows[i].Cells[4].Value = p.GetArea(); 
                    if (p is Centimeter centi)
                    {
                        int i1_ = centi.GetSides_meters().IndexOf(" ");
                        int i2_ = centi.GetSides_meters().IndexOf(" ", i1_ + 1);
                        string ca = centi.GetSides_meters().Remove(i2_);
                        string cb = centi.GetSides_meters().Remove(0, i2_);

                        dataGridView2.Rows[i].Cells[1].Value = ca;
                        dataGridView2.Rows[i].Cells[3].Value = cb;
                        dataGridView2.Rows[i].Cells[5].Value = centi.GetArea_meters();

                    }
                    else if (p is Decimeter deci)
                    {
                        int i1_ = deci.GetSides_meters().IndexOf(" ");
                        int i2_ = deci.GetSides_meters().IndexOf(" ", i1_ + 1);
                        string ca = deci.GetSides_meters().Remove(i2_);
                        string cb = deci.GetSides_meters().Remove(0, i2_);

                        dataGridView2.Rows[i].Cells[1].Value = ca;
                        dataGridView2.Rows[i].Cells[3].Value = cb;
                        dataGridView2.Rows[i].Cells[5].Value = deci.GetArea_meters();
                    }
                    i++;
                }
            }
            catch (Exception) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
