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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30");
            string login = "SELECT * FROM student where username = '" + loginUsername.Text + "' AND password = '" + loginPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, con);

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome User");
                    Body f9 = new Body();
                    this.Hide();
                    f9.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Login Failed " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home f7 = new Home();
            this.Hide();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginUsername.Text = "";
            loginPassword.Text = "";
        }
    }
}
