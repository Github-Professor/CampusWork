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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateFirstname.Text = "";
            updateLastname.Text = "";
            updateUsername.Text = "";
            updateAddress.Text = "";
            updatePhone.Text = "";
            updateAge.Text = "";
            updateGender.Text = "";
            updatePassword.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Body f9 = new Body();
            this.Hide();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(updateFirstname.Text.Equals("") || updateLastname.Text.Equals("") || updateUsername.Text.Equals("") || updateAddress.Equals("") || updatePhone.Text.Equals("") || updateAge.Text.Equals("") || updateGender.Text.Equals("") || updatePassword.Text.Equals("")))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Campus Work\Campus Projects\C# Project (Year 1 2nd Semester)\student.mdf;Integrated Security=True;Connect Timeout=30");
                string updateData = "UPDATE student SET lastname = '" + updateLastname.Text + "', username = '" + updateUsername.Text + "', address = '" + updateUsername.Text + "', phone = '" + updatePhone.Text + "', age = '" + updateAge.Text + "', gender = '" + updateGender.Text + "', password = '" + updatePassword.Text + "' WHERE firstname = '" + updateFirstname.Text + "'";
                SqlCommand cmd = new SqlCommand(updateData, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Data");
            }
            
        }
    }
}
