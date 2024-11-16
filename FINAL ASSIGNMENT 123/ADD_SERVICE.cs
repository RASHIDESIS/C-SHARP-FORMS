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
    public partial class ADD_SERVICE : Form
    {
        Service service = new Service();

        public ADD_SERVICE()
        {
            InitializeComponent();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MANAGE_SERVICES frm = new MANAGE_SERVICES();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServiceType;
            string Description;
            decimal price; // Use decimal instead of float
            string EstimatedTime; // Use int instead of string

            // Check for invalid price input
            if (!decimal.TryParse(textBox2.Text, out price))
            {
                MessageBox.Show("Invalid format for price, please check the input values.");
                return;
            }


            // Get other input values
            ServiceType = textBox1.Text;
            Description = textBox4.Text;
            EstimatedTime = textBox3.Text;

            // Add service details into the table
            try
            {
                service.add_Service(ServiceType, Description, price,  EstimatedTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This method seems to be empty and can be removed if not needed
        }
    }
}
