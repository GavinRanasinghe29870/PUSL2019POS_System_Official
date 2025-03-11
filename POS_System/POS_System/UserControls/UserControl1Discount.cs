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
    public partial class UserControl1Discount : UserControl
    {
        //private string connectionString = @"Data Source=Vihanga\SQLEXPRESS;Initial Catalog=abcsupermarket;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string connectionString = ConnectionString.constring;
        public UserControl1Discount()
        {
            InitializeComponent();
            LoadDiscount();
        }

        //Method to clear input fields
        private void ClearFields()
        {
            cmbDisType.SelectedIndex = -1; //Resets ComboBox
            txtProID.Clear(); //Clears ProductID
            numDisPercentage.Value = 0; //Reset Numeric Updown value
            dtpStartDate.Value = DateTime.Now;//Reset Start Date
            dtpEndDate.Value = DateTime.Now;//Reset End Date
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Discount (DiscType,DiscPercentage,ProductID,StartDate,EndDate) VALUES (@DiscType,@DiscPercentage,@ProductID,@StartDate,@EndDate)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (cmbDisType.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a Discount Type!");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@DiscType", cmbDisType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiscPercentage", numDisPercentage.Value);
                    cmd.Parameters.AddWithValue("@ProductID", txtProID.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Discount Added!");

                        LoadDiscount();//Refresh DataGridView
                        ClearFields();//Clear input fields

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred " + ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //Validate DiscountID input
            if (string.IsNullOrWhiteSpace(txtDiscountID.Text) || !int.TryParse(txtDiscountID.Text, out int DiscountID))

            {
                MessageBox.Show("Please enter a valid Discount ID!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    //UPDATE Query
                    string query = "UPDATE Discount SET DiscType = @DiscType, DiscPercentage = @DiscPercentage, ProductID = @ProductID, StartDate = @StartDate, EndDate = @EndDate WHERE DiscountID = @DiscountID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (cmbDisType.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a Discount Type!");
                        return;
                    }

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@DiscountID", DiscountID);
                    cmd.Parameters.AddWithValue("@DiscType", cmbDisType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DiscPercentage", numDisPercentage.Value);
                    cmd.Parameters.AddWithValue("@ProductID", txtProID.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);

                    //Execute the Query
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Discount updated successfully!");
                        LoadDiscount();//Refresh the DataGridView
                        ClearFields();//Clear input fields
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred " + ex.Message);
                }
            }
        }

        private void LoadDiscount()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT DiscountID, DiscType, DiscPercentage, ProductID, StartDate, EndDate FROM Discount";


                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvDiscounts.DataSource = table;

                    // Set AutoGenerateColumns to true for manual column definition
                    dgvDiscounts.AutoGenerateColumns = true;

                    // Adjust column widths for better display
                    dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        private void UserControl1Discount_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadDiscountByID(int DiscountID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                try
                {
                    //Query to fetch discound record by ID
                    string query = "SELECT DiscType,DiscPercentage,ProductID,StartDate,EndDate FROM Discount WHERE DiscountID = @DiscountID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DiscountID", DiscountID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the fields if the record is found
                        cmbDisType.SelectedItem = reader["DiscType"].ToString();
                        numDisPercentage.Value = Convert.ToDecimal(reader["DiscPercentage"]);
                        txtProID.Text = reader["ProductID"].ToString();
                        dtpStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                        dtpEndDate.Value = Convert.ToDateTime(reader["EndDate"]);
                    }
                    else
                    {
                        MessageBox.Show("No record found with this ID");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.Message);
                }
            }
        }

        private void dgvDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ensure a valid row is selected
            if (e.RowIndex >= 0)
            {
                //Get the selected row
                DataGridViewRow row = dgvDiscounts.Rows[e.RowIndex];

                //Populate input controls with the selected row's data
                txtProID.Text = row.Cells["ProductID"].Value?.ToString();
                cmbDisType.SelectedItem = row.Cells["DiscType"].Value?.ToString();
                numDisPercentage.Value = Convert.ToDecimal(row.Cells["DiscPercentage"].Value ?? 0);
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value ?? DateTime.Now);
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value ?? DateTime.Now);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (dgvDiscounts.CurrentRow == null)
            {
                MessageBox.Show("Please select a discount to delete !");
                return;
            }

            int DiscountID = Convert.ToInt32(dgvDiscounts.CurrentRow.Cells["DiscountID"].Value);

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this discount?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "DELETE FROM Discount WHERE DiscountID = @DiscountID";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@DiscountID", DiscountID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Discount deleted successfully!");
                            LoadDiscount();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Validate DiscountID input
            if (string.IsNullOrWhiteSpace(txtDiscountID.Text) || !int.TryParse(txtDiscountID.Text, out int DiscountID))
            {
                MessageBox.Show("Please enter a valid Discount ID.");
                return;
            }

            // Load the discount record based on DiscountID
            LoadDiscountByID(DiscountID);
        }

        private void dgvDiscounts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
