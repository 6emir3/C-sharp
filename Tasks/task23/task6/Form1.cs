using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            if (textBox1.Visible == true)
            {
                textBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
