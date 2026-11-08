using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_perimeter_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double area, long_side, short_side, perimeter;

            long_side = Convert.ToDouble(textBox1.Text);
            short_side = Convert.ToDouble(textBox2.Text);

            area = long_side * short_side;
            perimeter = 2*(long_side + short_side);

            label5.Text = area.ToString();
            label6.Text = perimeter.ToString();


        }
    }
}
