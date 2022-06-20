using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string newStr = "";
            for(int i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'А')||(str[i]=='A'))
                {
                    newStr += '*';
                }
                else
                {
                    newStr += str[i];
                }
            }
            label1.Text =$"Обработанная строка: {newStr}";
        }
    }
}
