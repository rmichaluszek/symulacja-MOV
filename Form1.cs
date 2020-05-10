using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesor
{
    public partial class Form1 : Form
    {
        int parameter1 = 0;
        int parameter2 = 1;


        decimal AXValue = 0;
        decimal BXValue = 0;
        decimal CXValue = 0;
        decimal DXValue = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = parameter1;
            comboBox2.SelectedIndex = parameter2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AXValue = numericUpDown1.Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameter1 = comboBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desc = numericUpDown1;
            if(parameter1==1) { desc = numericUpDown2; }
            else if(parameter1 == 2) { desc = numericUpDown3; }
            else if (parameter1 == 3) { desc = numericUpDown4; }

            var src = numericUpDown1;
            if (parameter2 == 1) { src = numericUpDown2; }
            else if (parameter2 == 2) { src = numericUpDown3; }
            else if (parameter2 == 3) { src = numericUpDown4; }

            desc.Value = src.Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameter2 = comboBox2.SelectedIndex;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            BXValue = numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CXValue = numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            DXValue = numericUpDown4.Value;
        }
    }
}
