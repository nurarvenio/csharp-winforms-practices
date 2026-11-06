using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpa_calculatorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double exam_1, exam_2, oral, gpa;

            exam_1 = Convert.ToDouble(textBox1.Text);
            exam_2 = Convert.ToDouble(textBox2.Text);
            oral = Convert.ToDouble(textBox3.Text);

            gpa = (exam_2 + exam_2 + oral) / 3;

            label5.Text = gpa.ToString();
        }
    }
}
