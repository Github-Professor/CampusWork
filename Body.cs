using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Body : Form
    {
        public Body()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete f8 = new Delete();
            this.Hide();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update f10 = new Update();
            this.Hide();
            f10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll f11 = new ShowAll();
            this.Hide();
            f11.Show();
        }
    }
}
