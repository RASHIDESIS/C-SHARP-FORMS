using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public class ServiceManager
{
    private BindingList<Service> services;
    private DataGridView dataGridView;

    public ServiceManager(DataGridView dataGridView)
    {
        this.dataGridView = dataGridView;
        services = new BindingList<Service>();
        dataGridView.DataSource = services;
    }

    public void AddService(Service service)
    {
        services.Add(service);
    }

    public void DeleteService(int index)
    {
        if (index >= 0 && index < services.Count)
        {
            services.RemoveAt(index);
        }
    }

    public void EditService(int index, Service updatedService)
    {
        if (index >= 0 && index < services.Count)
        {
            services[index] = updatedService;
        }
    }
    private void LoadServices()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Define the query to fetch service data
                string query = "SELECT * FROM SERVICES";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                   //     dataGridView1.DataSource = dataTable;
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
