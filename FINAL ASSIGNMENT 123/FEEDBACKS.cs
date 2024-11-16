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
    public partial class FEEDBACKS : Form
    {
        public FEEDBACKS()
        {
            InitializeComponent();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            ADMIN_LOGIN_PAGE frm = new ADMIN_LOGIN_PAGE();
            frm.Show();
            this.Close();
        }

        private void FEEDBACKS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARSHOP123DataSet.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.cARSHOP123DataSet.Feedback);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
