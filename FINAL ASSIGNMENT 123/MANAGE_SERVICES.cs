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
    public partial class MANAGE_SERVICES : Form
    {
        private ServiceManager serviceManager;

        public MANAGE_SERVICES()
        {
            InitializeComponent();
        }

        private void MANAGE_SERVICES_Load(object sender, EventArgs e)
        {
            // Load data into the 'Services' table from your dataset
            this.servicesTableAdapter.Fill(this.cARSHOP123DataSet11.Services);

            // Initialize ServiceManager and link it to dataGridView1
            serviceManager = new ServiceManager(dataGridView1);

            // Optionally, set the DataGridView DataSource to the table
            dataGridView1.DataSource = this.cARSHOP123DataSet11.Services;
        }


        private void BACK_Click(object sender, EventArgs e)
        {
            ADMIN_LOGIN_PAGE frm = new ADMIN_LOGIN_PAGE();
            frm.Show();
            this.Close();
        }


        private void ADD_SERVICES_Click(object sender, EventArgs e)
        {
            ADD_SERVICE FRM = new ADD_SERVICE();
            FRM.Show();
            this.Close();
            
        }

        private void EDIT_SERVICE_Click(object sender, EventArgs e)
        {
            UPDATE_SERVICE FRM = new UPDATE_SERVICE();
            FRM.Show();
            this.Close();
        }

        private void DELETE_SERVICE_Click(object sender, EventArgs e)
        {  
            Delete_Service frm = new Delete_Service();
            frm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

