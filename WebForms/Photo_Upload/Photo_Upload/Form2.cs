using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Upload
{
    public partial class Form2 : Form
    {
        public Form2(Image pic1)
        {
            InitializeComponent();
            pictureBox1.Image = pic1;

            label1.Text = Form1.l1;



        }

        }
    }
