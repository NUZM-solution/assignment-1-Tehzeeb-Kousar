using System.Data;

namespace Tehzeebk
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public void createnewrow()
        {
            if (dt.Rows.Count <= 0)
            {
                DataColumn dc1 = new DataColumn("Course Code", typeof(string));
                DataColumn dc2 = new DataColumn("Course Title", typeof(string));
                DataColumn dc3 = new DataColumn("Obt. Marks", typeof(double));
                DataColumn dc4 = new DataColumn("Grade", typeof(string));
                DataColumn dc5 = new DataColumn("Status", typeof(string));
                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc3);
                dt.Columns.Add(dc4);
                dt.Columns.Add(dc5);
                dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                TehzeebGridView.DataSource = dt;
            }
            else
            {
                dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                TehzeebGridView.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createnewrow();
        }
    }
}
