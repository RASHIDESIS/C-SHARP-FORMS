using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

public class Service
{
    public int ServiceID { get; set; }
    public string ServiceType { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int EstimatedTime { get; set; }

    public Service(int serviceID, string serviceType, string description, decimal price, int estimatedTime)
    {
        ServiceID = serviceID;
        ServiceType = serviceType;
        Description = description;
        Price = price;
        EstimatedTime = estimatedTime;

    }
    public Service() { }


    public void add_Service(string ServiceType, string Description, decimal Price, string EstimatedTime)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            // Convert EstimatedTime to int (assuming it's valid)
            int estimatedTimeInt;
            if (!int.TryParse(EstimatedTime, out estimatedTimeInt))
            {
                MessageBox.Show("Invalid format for EstimatedTime.");
                return;
            }

            // Using the connection and command to insert data
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Define the query with parameters
                string query = "INSERT INTO SERVICES (ServiceType, Description, Price, EstimatedTime) " +
                               "VALUES (@ServiceType, @Description, @Price, @EstimatedTime)";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameters and assign their values
                cmd.Parameters.AddWithValue("@ServiceType", ServiceType);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@EstimatedTime", estimatedTimeInt);

                // Execute the query (Insert the data)
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if rows were inserted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Service added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add service.");
                }
            }
        }
        catch (SqlException sqlEx)
        {
            // Log the exception (you can log it to a file, or use a logging library)
            MessageBox.Show("Database error: " + sqlEx.Message);
        }
        catch (Exception ex)
        {
            // Catch any other general exceptions
            MessageBox.Show("An error occurred: " + ex.Message);
        }

    }
    public void DeleteService(int serviceID)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Define the delete query
                string query = "DELETE FROM SERVICES WHERE ServiceID = @ServiceID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ServiceID", serviceID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Service deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Service not found.");
                    }
                }
            }
        }
        catch (SqlException sqlEx)
        {
            MessageBox.Show("Database error: " + sqlEx.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }
    public void UpdateService(int serviceID, string serviceType, string description, decimal price, int estimatedTime)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Define the update query
                string query = "UPDATE SERVICES SET ServiceType = @ServiceType, Description = @Description, " +
                               "Price = @Price, EstimatedTime = @EstimatedTime WHERE ServiceID = @ServiceID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters and assign values
                    cmd.Parameters.AddWithValue("@ServiceID", serviceID);
                    cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@EstimatedTime", estimatedTime);

                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Service updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Service not found.");
                    }
                }
            }
        }
        catch (SqlException sqlEx)
        {
            MessageBox.Show("Database error: " + sqlEx.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }


}
