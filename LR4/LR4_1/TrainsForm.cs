using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_1
{
    public partial class TrainsForm : Form
    {
        public List<Train> trains { get; set; }
        public int count { get; set; }
        public TrainsForm(List<Train> trains, int count)
        {
            InitializeComponent();
            this.trains = trains;
            this.count = count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            Form1 f1 = new Form1();
            if (checkBox1.Checked)
            {
                i = count + 1;
                if (!IsNumberFree(Convert.ToInt32(textBox1.Text))) MessageBox.Show("Здається, цей номер зайнятий. Спробуйте інший", "УВАГА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    trains.Add(new Train(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text)));
                    count++;
                    newItemBox();
                    newComboBox();
                    comboBox1.SelectedIndex = i - 1;
                    f1.trains = trains;
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
                        f1.trains = trains;
                        newComboBox();
                        newItemBox();
                        f1.newComboBox();
                        comboBox1.SelectedIndex = i;
                        
                    }

                }

            }
        }

        private void TrainsForm_Load(object sender, EventArgs e)
        {
            count = 0;
            newItemBox();
            newComboBox();
            comboBox1.SelectedIndex = 0;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                if (comboBox1.Text == trains[i].number.ToString())
                {
                    textBox1.Text = trains[i].number.ToString();
                    textBox2.Text = trains[i].type;
                    //textBox6.Text = trains[i].time.Start + " → " + trains[i].time.Destination;
                    listBox1.SelectedIndex = i;
                }
            }
        }

        public bool IsNumberFree(int Entered)
        {
            int ch = 0;
            for (int i = 0; i < count; i++)
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
                checkBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                checkBox1.Visible = false;
                button1.Visible = false;
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        public void newComboBox()
        {
            comboBox1.Items.Clear();
            count = 0;
            foreach (Train t in trains)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                comboBox1.Items.Add(trains[i].number);
            }
        }

        public void newItemBox()
        {
            listBox1.Items.Clear();
            count = 0;
            foreach (Train t in trains)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(trains[i].number + "\t| " + trains[i].type);
            }
        }

    }
}
