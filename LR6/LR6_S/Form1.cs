using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LR6_S
{
    public partial class Form1 : Form
    {
        public ArrayList list_m = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            All all = new All(list_m);
            all.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newComboBox();
            //comboBox1.SelectedIndex = 0;
        }

        private void newComboBox()
        {
            comboBox1.Items.Clear();

            foreach (Meter meter in list_m)
            {
                if (meter is Centimeter_Circle centi)
                {
                    comboBox1.Items.Add(centi.GetInfo() + ", " + centi.a);
                }
                else if (meter is Centimeter_Triangle trian)
                {
                    comboBox1.Items.Add(trian.GetInfo() + ", " + trian.a);
                }
                else if (meter is Centimeter cent)
                {
                    comboBox1.Items.Add(cent.GetInfo() + ", " + cent.a);
                }
                if (meter is Decimeter_Circle dec)
                {
                    comboBox1.Items.Add(dec.GetInfo() + ", " + dec.a);
                }
                else if (meter is Decimeter_Triangle trdec)
                {
                    comboBox1.Items.Add(trdec.GetInfo() + ", " + trdec.a);
                }
                else if (meter is Decimeter deci)
                {
                    comboBox1.Items.Add(deci.GetInfo() + ", " + deci.a);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Meter meter in list_m)
            {
                if (comboBox1.Text == meter.GetInfo() + ", " + meter.a)
                {
                    textBox1.Text = meter.a.ToString();
                    textBox7.Text = meter.GetArea().ToString();
                    if (meter is Centimeter_Circle centi)
                    {
                        textBox8.Text = centi.GetArea_Circle_meters().ToString();
                        textBox4.Text = centi.GetA_meters().ToString();
                        label4.Text = "см";
                        textBox2.Visible = false;
                        label5.Visible = false;
                        label2.Visible = false;
                        label10.Visible = false;
                        comboBox3.SelectedIndex = 2;
                        comboBox2.SelectedIndex = 0;
                    }
                    else if (meter is Centimeter_Triangle trcent)
                    {
                        textBox2.Text = trcent.b.ToString();
                        textBox3.Text = trcent.c.ToString();
                        textBox4.Text = trcent.GetA_meters().ToString();
                        textBox5.Text = trcent.GetB().ToString();
                        textBox6.Text = trcent.GetC().ToString();
                        textBox8.Text = trcent.GetArea_Triangle_meters().ToString();
                        label4.Text = "см";
                        textBox2.Visible = true;
                        label5.Visible = true;
                        label2.Visible = true;
                        label10.Visible = true;
                        comboBox3.SelectedIndex = 1;
                        comboBox2.SelectedIndex = 0;
                    }
                    else if (meter is Centimeter cent)
                    {
                        textBox4.Text = cent.GetA_meters().ToString();
                        textBox8.Text = cent.GetArea_meters().ToString();
                        label4.Text = "см";
                        textBox2.Visible = false;
                        label5.Visible = false;
                        label2.Visible = false;
                        label10.Visible = false;
                        comboBox3.SelectedIndex = 0;
                        comboBox2.SelectedIndex = 0;
                    }
                    else if (meter is Decimeter_Circle decc)
                    {
                        textBox8.Text = decc.GetArea_Circle_meters().ToString();
                        textBox4.Text = decc.GetA_meters().ToString();
                        label4.Text = "дм";
                        textBox2.Visible = false;
                        label5.Visible = false;
                        label2.Visible = false;
                        label10.Visible = false;
                        comboBox3.SelectedIndex = 2;
                        comboBox2.SelectedIndex = 1;
                    }
                    else if (meter is Decimeter_Triangle trdec)
                    {
                        textBox2.Text = trdec.b.ToString();
                        textBox3.Text = trdec.c.ToString();
                        textBox4.Text = trdec.GetA_meters().ToString();
                        textBox5.Text = trdec.GetB().ToString();
                        textBox6.Text = trdec.GetC().ToString();
                        textBox8.Text = trdec.GetArea_Triangle_meters().ToString();
                        label4.Text = "дм";
                        label5.Visible = true;
                        label10.Visible = true;
                        textBox2.Visible = true;
                        label2.Visible = true;
                        comboBox3.SelectedIndex = 1;
                        comboBox2.SelectedIndex = 1;
                    }
                    else if (meter is Decimeter dec)
                    {
                        textBox1.Text = dec.GetA_meters().ToString();
                        textBox8.Text = dec.GetArea_meters().ToString();
                        label4.Text = "дм";
                        label5.Visible = false;
                        label10.Visible = false;
                        textBox2.Visible = false;
                        label2.Visible = false;
                        comboBox3.SelectedIndex = 0;
                        comboBox2.SelectedIndex = 1;
                    }

                    textBox3.Visible = textBox2.Visible;
                    label5.Text = label4.Text;
                    label6.Text = label4.Text;
                    label15.Text = label4.Text;

                    label11.Visible = label10.Visible;
                    label12.Visible = label10.Visible;
                    label13.Visible = label10.Visible;
                    textBox5.Visible = label10.Visible;
                    textBox6.Visible = label10.Visible;
                    label6.Visible = label5.Visible;
                    label3.Visible = label2.Visible;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                checkBox2.Visible = true;
            }

            else
            {
                textBox1.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                checkBox2.Visible = false;
            }


            textBox2.Enabled = textBox1.Enabled;
            textBox3.Enabled = textBox1.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if (checkBox2.Checked)
            {
                i = list_m.Count;
                if (comboBox2.Text == "Сантиметри")
                {
                    if (comboBox3.Text == "Квадрат")
                    {
                        list_m.Add(new Centimeter(Convert.ToDouble(textBox1.Text)));
                    }
                    else if (comboBox3.Text == "Круг")
                    {
                        list_m.Add(new Centimeter_Circle(Convert.ToDouble(textBox1.Text)));
                    }
                    else if (comboBox3.Text == "Трикутник")
                    {
                        list_m.Add(new Centimeter_Triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
                    }

                    newComboBox();
                    comboBox1.SelectedIndex = i;
                }
                else if (comboBox2.Text == "Дециметри")
                {
                    if (comboBox3.Text == "Квадрат")
                    {
                        list_m.Add(new Decimeter(Convert.ToDouble(textBox1.Text)));
                    }
                    else if (comboBox3.Text == "Круг")
                    {
                        list_m.Add(new Decimeter_Circle(Convert.ToDouble(textBox1.Text)));
                    }
                    else if (comboBox3.Text == "Трикутник")
                    {
                        list_m.Add(new Decimeter_Triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
                    }

                    newComboBox();
                    comboBox1.SelectedIndex = i;
                }
            }
            else
            {
                i = comboBox1.SelectedIndex;

                (list_m[i] as Centimeter).a = Convert.ToDouble(textBox1.Text);
                if (list_m[i] is Centimeter_Triangle centi)
                {
                    centi.b = Convert.ToDouble(textBox2.Text);
                    centi.c = Convert.ToDouble(textBox3.Text);
                }
                else if (list_m[i] is Decimeter_Triangle deciT)
                {
                    deciT.b = Convert.ToDouble(textBox2.Text);
                    deciT.c = Convert.ToDouble(textBox3.Text);
                }
                newComboBox();
                comboBox1.SelectedIndex = i;
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Трикутник")
            {
                textBox2.Visible = true;
                label5.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }

            textBox3.Visible = textBox2.Visible;
            label5.Text = label4.Text;
            label6.Text = label4.Text;
            label6.Visible = label5.Visible;
            label3.Visible = label2.Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Дециметри")
            {
                label4.Text = "дм";
            }
            else label4.Text = "см";

            label5.Text = label4.Text;
            label6.Text = label4.Text;
            label15.Text = label4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = comboBox1.SelectedIndex;
                list_m.Remove(list_m[i]);
                newComboBox();
                if (i == 0) comboBox1.SelectedIndex = 0;
                else comboBox1.SelectedIndex = i - 1;
            }
            catch (Exception) { comboBox1.Text = "Список пустий"; }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Бінарний файл(*.bin)|*.bin|Файл XML(*.xml)|*.xml|Усі файли(*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(open.FileName) == ".bin")
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate))
                        {
                            list_m = new ArrayList();
                            list_m = (ArrayList)formatter.Deserialize(fs);
                            newComboBox();
                            comboBox1.SelectedIndex = 0;
                        }
                    }

                    else if (Path.GetExtension(open.FileName) == ".xml")
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Centimeter), typeof(Decimeter), typeof(Centimeter_Circle), typeof(Centimeter_Triangle), typeof(Decimeter_Circle), typeof(Decimeter_Triangle) });
                        using (FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate))
                        {
                            list_m = new ArrayList();
                            list_m = (ArrayList)formatter.Deserialize(fs);
                            newComboBox();
                            comboBox1.SelectedIndex = 0;
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
                        XmlSerializer formatter = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Centimeter), typeof(Decimeter), typeof(Centimeter_Circle), typeof(Centimeter_Triangle), typeof(Decimeter_Circle), typeof(Decimeter_Triangle) });
                        using (FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, list_m);
                        }
                    }
                }
            }
        }
    }
}

