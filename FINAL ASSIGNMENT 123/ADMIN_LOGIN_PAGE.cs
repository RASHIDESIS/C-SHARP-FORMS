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
    public partial class ADMIN_LOGIN_PAGE : Form
    {
        public ADMIN_LOGIN_PAGE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MANAGE_STAFF_ACCOUNTS frm = new MANAGE_STAFF_ACCOUNTS();
            frm.Show();
            this.Close();
        }

        private void Manage_Service_Click(object sender, EventArgs e)
        {
            MANAGE_SERVICES frm = new MANAGE_SERVICES();
            frm.Show();
            this.Close();
        }

        private void FEEDBACKS_Click(object sender, EventArgs e)
        {
            FEEDBACKS frm = new FEEDBACKS();
            frm.Show();
            this.Close();
        }

        private void REPORTS_Click(object sender, EventArgs e)
        {
            REPORTS frm = new REPORTS();
            frm.Show();
            this.Close();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("LOGOUT SUCCESSFUL");
            ADMIN_LOGIN FRM = new ADMIN_LOGIN();
            FRM.Show();
        }
    }
}
