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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(firstname.Text.Equals("") || lastname.Text.Equals("") || username.Text.Equals("") || age.Text.Equals("") || gender.Text.Equals("") || password.Text.Equals("")))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO student VALUES('" + firstname.Text + "', '" + lastname.Text + "', '" + username.Text + "', '" + address.Text + "', '" + phone.Text + "', '" + age.Text + "', '" + gender.Text + "', '" + password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !!! " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter Data");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            more f3 = new more();
            this.Hide();
            f3.Show();
        }
    }
}
