using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LR4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count_tr, count_r, count_l;
        List<Train> trains = new List<Train>();
        List<Timetable> timetables = new List<Timetable>();
        List<Road> roads = new List<Road>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            timetables.Add(new Timetable("Київ", "Ужгород"));
            timetables.Add(new Timetable("Київ", "Харків"));
            timetables.Add(new Timetable("Одеса", "Харків"));

            //
            trains.Add(new Train(3, "Купе", 10, timetables[1]));
            trains.Add(new Train(2, "Купе", 100, timetables[0]));
            trains.Add(new Train(10, "Плацкарт", 55 ,timetables[0]));
            trains.Add(new Train(6, "Львів", 60 ,timetables[1]));

            //
            roads.Add(new Road(trains[0], timetables[0], "29.01.2023", "11:30", "20:00"));
            roads.Add(new Road(trains[1], timetables[1], "02.11.2022", "08:00", "20:00"));
            roads.Add(new Road(trains[2], timetables[2], "10.02.2023", "07:00", "22:00"));

            newComboBox_R();
            newComboBox_T();
            newComboBox_L();
        }

        public void newComboBox_R()
        {
            comboBox1.Items.Clear();
            count_r = 0;

            foreach (Road t in roads)
            {
                count_r++;
            }

            for (int i = 0; i < count_r; i++)
            {
                comboBox1.Items.Add(roads[i].timetable.Start + " => " + roads[i].timetable.Destination);
            }
        }

        public void newComboBox_T()
        {
            comboBox2.Items.Clear();
            count_tr = 0;

            foreach (Train t in trains)
            {
                count_tr++;
            }

            for (int i = 0; i < count_r; i++)
            {
                comboBox2.Items.Add(trains[i].number);
            }
            comboBox2.SelectedIndex = 0;
        }

        public void newComboBox_L()
        {
            comboBox3.Items.Clear();
            count_l = 0;

            foreach (Timetable t in timetables)
            {
                count_l++;
            }

            for (int i = 0; i < count_l; i++)
            {
                comboBox3.Items.Add(timetables[i].Start + " => " + timetables[i].Destination);
            }
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count_r; i++)
            {
                if (comboBox1.Text == roads[i].timetable.Start + " => " + roads[i].timetable.Destination)
                {
                    textBox1.Text = roads[i].train.number.ToString();
                    textBox2.Text = roads[i].train.type;
                    textBox3.Text = roads[i].train.capacity.ToString();

                    textBox4.Text = roads[i].timetable.Start;
                    textBox5.Text = roads[i].timetable.Destination;

                    textBox6.Text = roads[i].date;
                    textBox7.Text = roads[i].timeStart;
                    textBox8.Text = roads[i].timeDest;

                    //if (roads[i].train.number.ToString() == textBox1.Text) comboBox2.SelectedIndex = i;
                    // if (roads[i].timetable.Start + " => " + roads[i].timetable.Destination == comboBox3.Text) comboBox3.SelectedIndex = i;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count_l; i++)
            {
                if (timetables[i].Start + " => " + timetables[i].Destination == comboBox3.Text)
                {
                    comboBox3.SelectedIndex = i;

                    textBox4.Text = timetables[i].Start;
                    textBox5.Text = timetables[i].Destination;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = true;
                comboBox2.Visible = true;
                label2.Visible = true;
                comboBox3.Visible = true;

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                button2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                comboBox3.Visible = false;

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                button2.Visible = false;
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < count_r; i++)
            {
                if (trains[i].number.ToString() == comboBox2.Text)
                {
                    comboBox2.SelectedIndex = i;

                    textBox1.Text = trains[i].number.ToString();
                    textBox2.Text = trains[i].type;
                    textBox3.Text = trains[i].capacity.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (radioButton1.Checked)
            {
                i = count_tr + 1;

                int j = comboBox2.SelectedIndex;
                Timetable temp = timetables[j];
                trains.Add(new Train(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), temp));
                count_tr++;
                newComboBox_T();
                newComboBox_R();
               
                //comboBox2.SelectedIndex = i - 1;
            }

            else if(radioButton2.Checked)
            {
                i = count_l + 1;
                // Timetable temp = timetables[comboBox3.SelectedIndex];
                timetables.Add(new Timetable(textBox4.Text, textBox5.Text));
                count_l++;
                newComboBox_R();
                newComboBox_L();
                comboBox2.SelectedIndex = i - 1;
            }

        }
    }
}
