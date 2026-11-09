using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square_and_cube_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double number, cube, square;

        private void button2_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);

            square = number * number;

            label2.Text = square.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);

            cube = number * number * number;

            label2.Text = cube.ToString();

        }
    }
}
