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
    public partial class Form2 : Form
    {
        dynamic builder = new ConcreteBuilder();
        public Form2(dynamic b)
        {
            InitializeComponent();
            builder = b;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            builder.GetAllText(listBox1);
        }
    }
}
