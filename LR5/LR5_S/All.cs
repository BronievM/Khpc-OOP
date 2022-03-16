using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5_S
{
    public partial class All : Form
    {
        List<Meter> list_m = new List<Meter>();
        public All(List<Meter> list)
        {
            InitializeComponent();
            this.list_m = list;
           
            dataGridView1.Rows.Clear();
            if (list_m.Count == 0) dataGridView1.RowCount = 1;
            else dataGridView1.RowCount = list_m.Count;

            try
            {
                int i = 0;
                foreach (Meter p in list_m)
                {
                    dataGridView1.Rows[i].Cells[0].Value = p.a;
                    dataGridView1.Rows[i].Cells[6].Value = p.GetArea();

                    if (p is Centimeter_Circle centi)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " см";
                        dataGridView1.Rows[i].Cells[6].Value += " см";
                        dataGridView1.Rows[i].Cells[3].Value = centi.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = centi.GetArea_Circle_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = centi.GetInfo();
                    }
                    else if (p is Centimeter_Triangle centi_t)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " см";
                        dataGridView1.Rows[i].Cells[6].Value += " см";
                        dataGridView1.Rows[i].Cells[1].Value = centi_t.b + " см";
                        dataGridView1.Rows[i].Cells[2].Value = centi_t.c + " см";
                        dataGridView1.Rows[i].Cells[3].Value = centi_t.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[4].Value = centi_t.GetB() + " м";
                        dataGridView1.Rows[i].Cells[5].Value = centi_t.GetC() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = centi_t.GetArea_Triangle_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = centi_t.GetInfo();
                    }
                    else if (p is Centimeter cent)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " см";
                        dataGridView1.Rows[i].Cells[6].Value += " см";
                        dataGridView1.Rows[i].Cells[3].Value = cent.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = cent.GetArea_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = cent.GetInfo();
                    }

                    if (p is Decimeter_Circle deci_c)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " дм";
                        dataGridView1.Rows[i].Cells[6].Value += " дм";
                        dataGridView1.Rows[i].Cells[3].Value = deci_c.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = deci_c.GetArea_Circle_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = deci_c.GetInfo();
                    }
                    else if (p is Decimeter_Triangle deci_t)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " дм";
                        dataGridView1.Rows[i].Cells[6].Value += " дм";
                        dataGridView1.Rows[i].Cells[1].Value = deci_t.b + " дм";
                        dataGridView1.Rows[i].Cells[2].Value = deci_t.c + " дм";
                        dataGridView1.Rows[i].Cells[4].Value = deci_t.GetB() + " м";
                        dataGridView1.Rows[i].Cells[5].Value = deci_t.GetC() + " м";
                        dataGridView1.Rows[i].Cells[3].Value = deci_t.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = deci_t.GetArea_Triangle_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = deci_t.GetInfo();
                    }
                    else if (p is Decimeter deci)
                    {
                        dataGridView1.Rows[i].Cells[0].Value += " дм";
                        dataGridView1.Rows[i].Cells[6].Value += " дм";
                        dataGridView1.Rows[i].Cells[3].Value = deci.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[7].Value = deci.GetArea_meters() + " м";
                        dataGridView1.Rows[i].Cells[8].Value = deci.GetInfo();
                    }

                    i++;
                }
            }
            catch (Exception) { }

        }
    }
}
