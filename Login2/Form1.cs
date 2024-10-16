using System;

namespace Login2
{
    public partial class Form1 : Form
    {
        Double count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tehzeeb_Kousar" && textBox2.Text == "22011556-006")
            {
                MessageBox.Show("Logged In Successfully! ");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong Username or password " + remain + " tries left!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try Exceeded.");
                    Application.Exit();
                }
            }
        }
    }
}