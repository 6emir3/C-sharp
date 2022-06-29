using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            double z = Convert.ToDouble(textBoxZ.Text);
            double f = (Math.Pow(y + Math.Pow(x - 1, 1 / 3f), 1 / 4f)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));
            labelF.Text = $"f = {Convert.ToString(f)}";
        }
    }
}
