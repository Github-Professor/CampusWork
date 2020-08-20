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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(deleteUsername.Text.Equals("") || deletePassword.Text.Equals("")))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30");
                string delete = "DELETE FROM student WHERE username = '" + deleteUsername.Text + "' AND password = '" + deletePassword.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteUsername.Text = "";
            deletePassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Body f7 = new Body();
            this.Hide();
            f7.Show();
        }
    }
}
