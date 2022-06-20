using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Иванов М.А." +
            Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Log(x);
                textBox5.Text += "x=" + Convert.ToString(x) + ";  y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
