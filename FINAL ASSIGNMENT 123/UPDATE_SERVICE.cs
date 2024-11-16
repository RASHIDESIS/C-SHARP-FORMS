using System;
using System.Windows.Forms;


namespace FINAL_ASSIGNMENT_123
{
    public partial class UPDATE_SERVICE : Form
    {
        Service service = new Service();

        public UPDATE_SERVICE()
        {
            InitializeComponent();

            // Bind the Load event to the UPDATE_SERVICE_Load method
         //   this.Load += new System.EventHandler(this.UPDATE_SERVICE_Load);
        }

        // Define the UPDATE_SERVICE_Load method
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceID = int.Parse(textBoxServiceID.Text);
                string serviceType = textBoxServiceType.Text;
                string description = textBoxDescription.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                int estimatedTime = int.Parse(textBoxEstimatedTime.Text);

                // Call UpdateService method on the service instance
                Service service = new Service();
                service.UpdateService(serviceID, serviceType, description, price, estimatedTime);

                MessageBox.Show("Service updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating service: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MANAGE_STAFF_ACCOUNTS FRM = new MANAGE_STAFF_ACCOUNTS();
            FRM.Show();
        }

        
    }
    

}
