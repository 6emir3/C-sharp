namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a, c;
            a = random.Next(20, 200);
            c = random.Next(20, 200);
            Button b = new Button();
            b.Location = new Point(a, c);
            b.Text = button1.Text;
            Controls.Add(b);
            b.Click += new System.EventHandler(button1_Click);
            TextBox v = new TextBox();
            v.Location = new Point(100, 20);
            v.Click += new System.EventHandler(button1_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a, c;
            a = random.Next(20, 200);
            c = random.Next(20, 200);
            Label lbl1 = new Label();
            lbl1.Location = new Point(a, c);
            lbl1.Text = label1.Text;
            Controls.Add(lbl1);
            lbl1.Click += new System.EventHandler(label1_Click);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int a, c;
            a = random.Next(20, 200);
            c = random.Next(20, 200);
            TextBox txt1 = new TextBox();
            txt1.Location = new Point(a, c);
            txt1.Text = textBox1.Text;
            Controls.Add(txt1);
            txt1.Click += new System.EventHandler(textBox1_TextChanged);
        }
    }
}