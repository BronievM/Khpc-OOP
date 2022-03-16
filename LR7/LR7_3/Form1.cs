using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        IAbstractFactory factory = null;
        IPlace place = null;

        private void button1_Click(object sender, EventArgs e)
        {
                if (((string)comboBox1.SelectedItem).Equals("Музей")) place = factory.CreateMuseum(((string)comboBox2.SelectedItem));
                else if (((string)comboBox1.SelectedItem).Equals("Парк")) place = factory.CreatePark(((string)comboBox2.SelectedItem));
                else place = factory.CreateMonument(((string)comboBox2.SelectedItem));
        
                dataGridView1.RowCount++;
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = place.getPerson();
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = place.getName();
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = place.getPrice();
                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = place.getTime();

            UPDGr();
        }
        
        private void UPDGr()
        {
            double sum = 0, sumt = 0;

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[j].Cells[2].Value);
                sumt += Convert.ToDouble(dataGridView1.Rows[j].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();
            textBox2.Text = sumt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excursion ex = null;
            ex = factory.CreateExcursionA(((string)comboBox2.SelectedItem));

            
            dataGridView1.RowCount++;
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = ex.museum.getPerson();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = ex.museum.getName();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = ex.museum.getPrice();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = ex.museum.getTime();
            dataGridView1.RowCount++;
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = ex.park.getPerson();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = ex.park.getName();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = ex.park.getPrice();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = ex.park.getTime();
            dataGridView1.RowCount++;
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = ex.monument.getPerson();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = ex.monument.getName();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = ex.monument.getPrice();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = ex.monument.getTime();
            UPDGr();
        }
                


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((string)comboBox3.SelectedItem))
            {
                case "Київ":
                    {
                        factory = new Kyiv();
                        break;
                    }
                case "Львів":
                    {
                        factory = new Lviv();
                        break;
                    }
                case "Хмельницький":
                    {
                        factory = new Khmelnytskiy();
                        break;
                    }
            }
        }
    }
}
