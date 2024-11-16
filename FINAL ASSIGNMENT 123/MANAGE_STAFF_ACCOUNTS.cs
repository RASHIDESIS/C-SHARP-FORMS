using System;
using System.Windows.Forms;

namespace FINAL_ASSIGNMENT_123
{
    public partial class MANAGE_STAFF_ACCOUNTS : Form
    {

        // Create an instance of the Account class
        Account account = new Account();
        public MANAGE_STAFF_ACCOUNTS()
        {
            InitializeComponent();
        }

        // Form Load event - this will run when the form is first loaded
        private void MANAGE_STAFF_ACCOUNTS_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with options for role selection
            ComboBox1.Items.AddRange(new string[] { "Mechanic", "Receptionist" });
        }

        // Button Click event for adding account
        private void ADD_Click_1(object sender, EventArgs e)
        {

            // Validate inputs
            if (
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                ComboBox1.SelectedItem != null)
            {
                // Retrieve input values
                string accountName = textBox2.Text;
                string accountEmail = textBox3.Text;
                string accountStatus = textBox4.Text;
                string selectedRole = ComboBox1.SelectedItem.ToString();
                string password = textBox1.Text;

                // Determine the target table based on the selected role
                string tableName = selectedRole == "Mechanic" ? "Mechanic" : "Receptionist";

                // Add the account to the specified table
                try
                {
                    account.AddAccount(tableName, accountName, accountEmail, accountStatus, password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the account: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and select a role.");
            }
        }

        // Back button functionality (optional, for navigation)
        private void BACK_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMIN_LOGIN_PAGE frm = new ADMIN_LOGIN_PAGE();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(textBox8.Text);
            string userrole = comboBox2.Text;
            account.DeactivateAccount(userID, userrole);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Parse User ID from the TextBox
                int userID = int.Parse(textBox8.Text);

                // Get the selected role from the ComboBox
                string tableName = comboBox2.Text;


                account.SearchAccount(userID, tableName);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric User ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}