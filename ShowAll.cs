using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registration
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(showUsername.Text.Equals("")))
            {
                string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30";
                string show = "SELECT * FROM student WHERE username = '" + showUsername.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(show, conString);
                DataSet ds = new DataSet();

                da.Fill(ds, "student");
                dataGridView1.DataSource = ds.Tables["student"];
            }
            else
            {
                MessageBox.Show("Please Enter Username");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showUsername.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30";
            string showAll = "SELECT * FROM student";
            SqlDataAdapter da = new SqlDataAdapter(showAll, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Body f12 = new Body();
            this.Hide();
            f12.Show();
        }
    }
}
