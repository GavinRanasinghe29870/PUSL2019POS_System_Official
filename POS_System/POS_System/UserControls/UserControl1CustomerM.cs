using POS_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.UserControls
{
    public partial class UserControl1CustomerM : UserControl
    {
        private string connectionString = ConnectionString.constring;
        public UserControl1CustomerM()
        {
            InitializeComponent();
        }

        private void UserControl1CustomerM_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoadCustomerData();
        }

        private void btnSaveCus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if Email Already Exists for a Different Customer
                    string checkQuery = "SELECT COUNT(*) FROM Customer WHERE Email = @Email AND CustomerID != @CustomerID";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    checkCommand.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(txtSearch.Text.Trim()) ? 0 : Convert.ToInt32(txtSearch.Text.Trim())); // For new insert, treat as 0

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This email already exists. Please use a different email.");
                        return;
                    }

                    // Determine if INSERT or UPDATE
                    if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        // INSERT Query
                        string insertQuery = "INSERT INTO Customer (FullName, Email, Phone) VALUES (@FullName, @Email, @Phone)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Phone", txtContactInf.Text.Trim());


                        int rowsInserted = insertCommand.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("New customer added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new customer.");
                        }
                    }
                    else
                    {

                        string updateQuery = "UPDATE Customer SET FullName = @FullName, Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtSearch.Text.Trim()));
                        updateCommand.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@Phone", txtContactInf.Text.Trim());

                        int rowsUpdated = updateCommand.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Customer details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.");
                        }
                    }


                    LoadCustomerData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClearCus_Click(object sender, EventArgs e)
        
        {
                ClearFields();
        }

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContactInf.Text = string.Empty;
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", txtSearch.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        // Populate data into textboxes
                        txtName.Text = table.Rows[0]["FullName"].ToString();
                        txtEmail.Text = table.Rows[0]["Email"].ToString();
                        txtContactInf.Text = table.Rows[0]["Phone"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Assuming you select the customer ID from the grid
                    int selectedRow = dataGridView1.CurrentCell.RowIndex;
                    int customerId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["CustomerID"].Value);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                        LoadCustomerData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtContactInf.Enabled = true;

                MessageBox.Show("You can now edit the customer details. Click Save after editing.");
            }
        }

        private void LoadCustomerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
    
}
