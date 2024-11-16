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
    public partial class Delete_Service : Form
    {
        public Delete_Service()
        {
            InitializeComponent();
        }

        private void Delete_Service_Load(object sender, EventArgs e)
        {
            // Bind DataGridView to dataset table
            dataGridView1.DataSource = cARSHOP123DataSet1.Tables["Services"];
            // Fill the data in case it hasn't been loaded yet
            this.servicesTableAdapter.Fill(this.cARSHOP123DataSet1.Services);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the ServiceID TextBox has a valid integer
            if (int.TryParse(textBoxServiceID.Text, out int serviceID))
            {
                try
                {
                    // Initialize the Service class and attempt deletion
                    Service service = new Service();
                    service.DeleteService(serviceID);

                    // Refresh the DataGridView to reflect changes in the database
                    this.servicesTableAdapter.Fill(this.cARSHOP123DataSet1.Services);
                    MessageBox.Show("Service deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting service: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Service ID.");
            }
        }



    }
}
