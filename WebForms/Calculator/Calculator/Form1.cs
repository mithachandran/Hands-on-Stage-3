using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string Operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Operation == "+")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
              
            }
           else if (Operation == "-")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));

            }
           else if (Operation == "*")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));

            }
           else  if (Operation == "/")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));

            }

        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "+";
        }

        private void Sub_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "-";

        }

       

        private void Div_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "/";

        }

        private void Mul_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "*";
        }
    }
}
