using System.CodeDom;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace LR4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Train> trains = new List<Train>();
        public List<Timetable> timetables = new List<Timetable>();
        public List<Road> roads = new List<Road>();
        int count_tr, count_ti, count_roads;
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            trains.Add(new Train(769, "Купе", 100));
            trains.Add(new Train(2, "Купе", 50));
            trains.Add(new Train(10, "Київ", 49));
            trains.Add(new Train(22, "Львів", 100));

            //
            timetables.Add(new Timetable("Київ", "Ужгорож", "12:30", "22:40"));
            timetables.Add(new Timetable("Київ", "Харків", "15:30", "23:40"));

            //
            roads.Add(new Road(trains[0], timetables[0]));
            roads.Add(new Road(trains[1], timetables[1]));

            newComboBox();
            newTimeBox();
            newTrainBox();

            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count_tr; i++)
            {
                if (comboBox1.Text == trains[i].number.ToString())
                {
                    textBox1.Text = trains[i].number.ToString();
                    textBox2.Text = trains[i].type;
                    //textBox6.Text = trains[i].time.Start + " → " + trains[i].time.Destination;
                }
            }
        }

        public bool IsNumberFree(int Entered)
        {
            int ch = 0;
            for (int i = 0; i < count_tr; i++)
            {
                if ((Entered == trains[i].number)) ch++;
            }

            if (ch > 0) return false;
            else return true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                checkBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                checkBox1.Visible = false;
                button1.Visible = false;
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        public void newComboBox()
        {
            comboBox1.Items.Clear();
            count_tr = 0;
            foreach (Train t in trains)
            {
                count_tr++;
            }

            for (int i = 0; i < count_tr; i++)
            {
                comboBox1.Items.Add(trains[i].number);
                
            }
        }

        public void newTrainBox()
        {
            numb.Items.Clear();
            count_tr = 0;
            foreach (Train t in trains)
            {
                count_tr++;
            }

            for (int i = 0; i < count_tr; i++)
            {
                numb.Items.Add(trains[i].number.ToString());
            }
            
        }

        public void newTimeBox()
        {
            Road.Items.Clear();
            count_ti = 0;
            foreach (Timetable t in timetables)
            {
                count_ti++;
            }

            for (int i = 0; i < count_ti; i++)
            {
                Road.Items.Add(timetables[i].Start+" "+timetables[i].Destination);
            }
            textBox6.Text = count_ti.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if (checkBox1.Checked)
            {
                i = count_ti + 1;
                if (!IsNumberFree(Convert.ToInt32(textBox1.Text))) MessageBox.Show("Здається, цей номер зайнятий. Спробуйте інший", "УВАГА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    trains.Add(new Train(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text)));
                    count_ti++;
                    newComboBox();
                    comboBox1.SelectedIndex = i - 1;
                }
            }
            else
            {
                if (checkBox2.Checked && (textBox1.Text != "" && !(textBox1.Text.Equals(comboBox1.Text))))
                {
                    if (!IsNumberFree(Convert.ToInt32(textBox1.Text)))
                    {
                        textBox1.Text = comboBox1.Text;
                        MessageBox.Show("Здається, цей номер зайнятий. Спробуйте інший", "УВАГА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        i = comboBox1.SelectedIndex;
                        trains[i].number = Convert.ToInt32(textBox1.Text);
                        trains[i].type = textBox2.Text;
                        newComboBox();
                        comboBox1.SelectedIndex = i;
                    }
                    
                }
                
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf(':') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4_KeyPress(sender, e);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < count_tr - 1; i++)
            {
                //string SelectedNum = Convert.ToString((dataGridView1.Rows[0].Cells["numb"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                if ("2".Equals(trains[i].number.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = trains[i].type;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = trains[i].capacity;
                }
            }

            for(int i = 0; i < count_ti; i++)
            {
                //string SelectedText = Convert.ToString((dataGridView1.Rows[0].Cells["road"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                if ("Київ Ужгород" == timetables[i].Start+" "+timetables[i].Destination.ToString())
                {
                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = timetables[i].Start;
                    dataGridView1.Rows[e.RowIndex].Cells[7].Value = timetables[i].Destination;
                }
            }
        }

        private void numb_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void поїздиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainsForm tf = new TrainsForm(trains, count_ti);
            tf.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            newComboBox();
            newTimeBox();
            newTrainBox();

        }

    }
}