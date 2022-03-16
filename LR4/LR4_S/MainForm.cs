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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Road> roads = new List<Road>();
        int count;
        private void Form1_Load(object sender, EventArgs e)
        {
            roads.Add(new Road(new Train(4, "Вантажний", 900, new Timetable("Київ", "Севастополь")), new DateTime(2022, 11, 01, 11, 18, 00), new DateTime(2022, 11, 02, 07, 59, 00)));
            roads.Add(new Road(new Train(93, "Пасажирський", 80, new Timetable("Хмельницький", "Кам'янець-Подільський")), new DateTime(2022, 10, 29, 08, 30, 00), new DateTime(2022, 10, 29, 16, 30, 00)));
            roads.Add(new Road(new Train(5, "Пасажирський", 80, new Timetable("Сімферополь", "Харків")), new DateTime(2022, 11, 03, 01, 00, 00), new DateTime(2022, 11, 05, 09, 30, 00)));
            roads.Add(new Road(new Train(2, "Пасажирський", 80, new Timetable("Львів", "Запоріжжя")), new DateTime(2022, 11, 01, 18, 59, 00), new DateTime(2022, 11, 04, 15, 20, 00)));
            roads.Add(new Road(new Train(20, "Вантажний", 800, new Timetable("Суми", "Рівне")), new DateTime(2022, 11, 03, 01, 23, 00), new DateTime(2022, 11, 07, 11, 04, 00)));
            newComboBox();
            checkBox1_CheckedChanged(sender, e);
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm";
            dateTimePicker2.CustomFormat = "yyyy.MM.dd HH:mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                if (comboBox1.Text == roads[i].train.timetable.Start + " => " + roads[i].train.timetable.Destination + ", " + roads[i].train.number)
                {
                    textBox1.Text = roads[i].train.number.ToString();
                    textBox2.Text = roads[i].train.type;
                    textBox3.Text = roads[i].train.capacity.ToString();
                    textBox4.Text = roads[i].train.timetable.Start;
                    textBox5.Text = roads[i].train.timetable.Destination;
                    dateTimePicker1.Value = roads[i].dateStart;
                    dateTimePicker2.Value = roads[i].dateStart;
                    label9.Text = roads[i].train.timetable.Start + " => " + roads[i].train.timetable.Destination + ", " + roads[i].train.type + " потяг";
                }
            }
        }

        private void newComboBox()
        {
            comboBox1.Items.Clear();
            count = 0;
            foreach (Road t in roads)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                comboBox1.Items.Add(roads[i].train.timetable.Start + " => " + roads[i].train.timetable.Destination + ", " + roads[i].train.number);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllRoutes f2 = new AllRoutes(roads);
            f2.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button2.Visible = true;
                button3.Visible = true;
                checkBox2.Visible = true;
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                button2.Visible = false;
                button3.Visible = false;
                checkBox2.Visible = false;
            }
        }

        public bool IsNumberFree(int Entered)
        {
            int ch = 0;
            for (int i = 0; i < count; i++)
            {
                if (Entered == roads[i].train.number) ch++;
            }

            if (ch > 0) return false;
            else return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (checkBox2.Checked)
            {
                i = count + 1;
                if (IsNumberFree(Convert.ToInt32(textBox1.Text)))
                {
                    roads.Add(new Road(new Train(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), new Timetable(textBox4.Text, textBox5.Text)), dateTimePicker1.Value, dateTimePicker2.Value));
                    count++;
                    newComboBox();
                    comboBox1.SelectedIndex = i - 1;
                }
                else MessageBox.Show("Здається, цей номер зайнятий. Спробуйте інший", "УВАГА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (textBox1.Text != "")
                {
                        i = comboBox1.SelectedIndex;
                        roads[i].train.number = Convert.ToInt32(textBox1.Text);
                        roads[i].train.type = textBox2.Text;
                        roads[i].train.capacity = Convert.ToInt32(textBox3.Text);
                        roads[i].train.timetable.Start = textBox4.Text;
                        roads[i].train.timetable.Destination = textBox5.Text;
                        roads[i].dateStart = dateTimePicker1.Value;
                        roads[i].dateEnd = dateTimePicker2.Value;
                        newComboBox();
                        comboBox1.SelectedIndex = i;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                int i = comboBox1.SelectedIndex;
                roads.Remove(roads[i]);
                newComboBox();
                if (i == 0) comboBox1.SelectedIndex = 0;
                else comboBox1.SelectedIndex = i - 1;
            }
            catch (Exception) { comboBox1.Text = "Список пустий"; }
           
        }
    }
}
