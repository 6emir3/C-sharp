using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxBukva.Text == "П")
            {
                TextBox newTextBox = new TextBox()
                {
                    Text = "Поле ввода",
                    BackColor = Color.Red,
                    ForeColor = Color.Aqua,
                    Location = new Point(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text))
                };
                Controls.Add(newTextBox);
            }
            else if (textBoxBukva.Text == "К")
            {
                Button newButton = new Button()
                {
                    Text = "Кнопка",
                    BackColor = Color.Yellow,
                    ForeColor = Color.Green,
                    Location = new Point(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text))
                };
                Controls.Add(newButton);
            }
            else if (textBoxBukva.Text == "М")
            {
                Label newLabel = new Label()
                {
                    Text = "Метка",
                    ForeColor = Color.Purple,
                    Location = new Point(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text))
                };
                Controls.Add(newLabel);
            }
        }
    }
}
