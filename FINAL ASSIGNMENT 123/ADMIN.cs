using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_ASSIGNMENT_123
{
    public partial class ADMIN_LOGIN : Form
    {
        public ADMIN_LOGIN()
        {
            InitializeComponent();
        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            string CORRECTUSERNAME = "RASHID";
            string CORRECTPASSWORD = "RASHID123";

            if (textBox_USERNAME.Text == CORRECTUSERNAME && textBox_PASSWORD.Text == CORRECTPASSWORD)
            {
                MessageBox.Show("LOGIN SUCCESSFUL");
                this.Hide();
                ADMIN_LOGIN_PAGE frm = new ADMIN_LOGIN_PAGE();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, please try again");
                textBox_USERNAME.Clear();
                textBox_PASSWORD.Clear();
            }
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
          
           this.Close();
        }
    }
}
