using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Orange);
            SolidBrush brush2 = new SolidBrush(Color.Black);

            e.Graphics.FillEllipse(brush, 100, 100, 300, 300);
            e.Graphics.FillEllipse(brush, 200, 85, 100, 70);
            e.Graphics.FillEllipse(brush2, 235, 85, 30, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
    }
}
