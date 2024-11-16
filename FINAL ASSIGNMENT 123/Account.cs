using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Account
{
    public int AccountID { get; set; }
    public string AccountName { get; set; }
    public string AccountEmail { get; set; }
    public string AccountStatus { get; set; }
    public string AccountPassword { get; set; }

    public void AddAccount(string tableName, string accountName, string accountEmail, string accountStatus, string accountPassword)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query;
                if (tableName == "Mechanic")
                {
                    query = "INSERT INTO Mechanic (mecName, mecEmail, mecStatus, mecPassword) " +
                            "VALUES (@Name, @Email, @Status, @Password)";
                }
                else if (tableName == "Receptionist")
                {
                    query = "INSERT INTO Receptionist (recepName, recepEmail, recepAccountStatus, recepPassword) " +
                            "VALUES (@Name, @Email, @Status, @Password)";
                }
                else
                {
                    MessageBox.Show("Invalid table name.");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", accountName);
                    cmd.Parameters.AddWithValue("@Email", accountEmail);
                    cmd.Parameters.AddWithValue("@Status", accountStatus);
                    cmd.Parameters.AddWithValue("@Password", accountPassword);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0
                        ? "Account added successfully."
                        : "Failed to add account.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }

    public void DeactivateAccount(int userID, string tableName)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query;
                if (tableName == "Mechanic")
                {
                    query = "UPDATE Mechanic SET mecStatus = @Status WHERE mechanicID = @ID";
                }
                else if (tableName == "Receptionist")
                {
                    query = "UPDATE Receptionist SET recepAccountStatus = @Status WHERE receptionistID = @ID";
                }
                else
                {
                    MessageBox.Show("Invalid role selected.");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", userID);
                    cmd.Parameters.AddWithValue("@Status", "In-Active");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0
                        ? "Account status updated to 'Inactive' successfully."
                        : "No account found with the given ID.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }

    public void SearchAccount(int userID, string tableName)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query;
                if (tableName == "Mechanic")
                {
                    query = "SELECT mecName FROM Mechanic WHERE mechanicID = @ID";
                }
                else if (tableName == "Receptionist")
                {
                    query = "SELECT recepName FROM Receptionist WHERE receptionistID = @ID";
                }
                else
                {
                    MessageBox.Show("Invalid role selected.");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", userID);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        this.AccountName = result.ToString();
                        this.AccountID = userID;
                        MessageBox.Show($"Account found: {this.AccountName}");
                    }
                    else
                    {
                        MessageBox.Show("No account found with the given ID.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }
}
