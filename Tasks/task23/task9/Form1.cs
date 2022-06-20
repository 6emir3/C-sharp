using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 12; // Кол-во строк
            dataGridView1.ColumnCount = 12; // Кол-во столбцов
            int[,] array = new int[12, 12];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                {
                    array[i, j] = rand.Next(100);
                    dataGridView1.Rows[i].Cells[j].Value =array[i, j].ToString();
                    if (j > i) { sum += array[i, j]; }
                }
            label1.Text = "Результат: " + sum;
        }
    }
}
