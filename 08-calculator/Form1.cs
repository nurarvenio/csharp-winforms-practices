using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double result, number_1, number_2;

        private void button2_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_2 = Convert.ToDouble(textBox2.Text);

            result = number_1 / number_2;
            label3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_2 = Convert.ToDouble(textBox2.Text);

            result = number_1 * number_2;
            label3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_2 = Convert.ToDouble(textBox2.Text);

            result = number_1 % number_2;
            label3.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_2 = Convert.ToDouble(textBox2.Text);

            result = number_1 - number_2;
            label3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_2 = Convert.ToDouble(textBox2.Text);

            result = number_1 + number_2;
            label3.Text = result.ToString();
        }
    }
}
