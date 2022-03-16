using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace LR6
{
    public partial class Form1 : Form
    {
        public ArrayList list_m = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
            UpdDGW();
        }

        public void UpdDGW()
        {
           if (list_m.Count == 0) dataGridView1.RowCount = 1;
           else dataGridView1.RowCount = list_m.Count+1;

            try
            {
                int i = 0;
                foreach (Meter p in list_m)
                {
                    dataGridView1.Rows[i].Cells[0].Value = p.a;
                    dataGridView1.Rows[i].Cells[2].Value = p.GetArea();
                    if (p is Centimeter centi)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = centi.GetA_meters() +" м";
                        dataGridView1.Rows[i].Cells[3].Value = centi.GetArea_meters()+ " м";
                        dataGridView1.Rows[i].Cells[2].Value += " см";

                    }
                    else if (p is Decimeter deci)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = deci.GetA_meters() + " м";
                        dataGridView1.Rows[i].Cells[3].Value = deci.GetArea_meters() + " м";
                        dataGridView1.Rows[i].Cells[2].Value += " дм";
                    }
                    i++;
                }
            }
            catch (Exception) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog save = new OpenFileDialog())
            {
                save.Filter = "Бінарний файл(*.bin)|*.bin|Файл XML(*.xml)|*.xml|Усі файли(*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(save.FileName) == ".bin")
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            list_m = new ArrayList();
                            list_m = (ArrayList)formatter.Deserialize(fs);
                            UpdDGW();
                        }
                    }

                    else if (Path.GetExtension(save.FileName) == ".xml")
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Centimeter), typeof(Decimeter) });
                        using (FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            list_m = new ArrayList();
                            list_m = (ArrayList)formatter.Deserialize(fs);
                            UpdDGW();
                        }
                    }
                }
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Бінарний файл(*.bin)|*.bin|Файл XML(*.xml)|*.xml|Усі файли(*.*)|*.*";
                //save.DefaultExt = ".bin";
                save.FileName = "NoName.bin";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(save.FileName) == ".bin")
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, list_m);
                        }
                    }

                    else if (Path.GetExtension(save.FileName) == ".xml")
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Meter>), new Type[] { typeof(Centimeter), typeof(Decimeter) });
                        using (FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, list_m);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if ((dataGridView1.Rows[i].Cells[0].Value != null))
            {
                try
                {
                    list_m[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    //list_m[i].b = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    UpdDGW();
                }

                catch (Exception)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value == null)
                    {
                        if (MessageBox.Show("Оберіть тип: \n Так - сантиметри \n Ні - дециметри", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            list_m.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
                        }
                        else
                        {
                            list_m.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
                        }
                        UpdDGW();
                    }
                }
               
            }
        }
    }
}
