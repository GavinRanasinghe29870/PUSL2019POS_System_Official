using POS_System;
using POS_System.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockManagement
{
    public partial class MainForm : Form
    {
        private SqlConnection connection;
        public string connectionString = "Data Source=DESKTOP-JUPKERV\\SQLEXPRESS;Initial Catalog=abcsupermarket;Integrated Security=True;TrustServerCertificate=True;";

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (ProductName, Quantity, Price, Category) VALUES (@ProductName, @Quantity, @Price, @Category)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox2.Text)); // Ensure proper conversion
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox3.Text)); // Ensure proper conversion
                        cmd.Parameters.AddWithValue("@Category", textBox4.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!");
                        LoadData(); // Refresh the data grid view
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxsearch.Text) || !int.TryParse(textBoxsearch.Text, out int ProductID))
            {
                MessageBox.Show("Please enter a valid ProductID!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Products SET ProductName=@ProductName, Quantity=@Quantity, Price=@Price, Category=@Category WHERE ProductID=@ProductID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@ProductName", textBox1.Text);
                        command.Parameters.AddWithValue("@Quantity", int.Parse(textBox2.Text)); // Proper type conversion
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBox3.Text)); // Proper type conversion
                        command.Parameters.AddWithValue("@Category", textBox4.Text);

                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!");
                            LoadData(); // Refresh the data grid view
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       


        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];

                textBoxsearch.Text = row.Cells["ProductID"].Value?.ToString();
                textBox1.Text = row.Cells["ProductName"].Value?.ToString();
                textBox2.Text = row.Cells["Quantity"].Value?.ToString();
                textBox3.Text = row.Cells["Price"].Value?.ToString();
                textBox4.Text = row.Cells["Category"].Value?.ToString();
            }
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ProductID, ProductName, Quantity, Price, Category FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvStock.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadDataByProductID(int ProductID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ProductID, ProductName, Quantity, Price, Category FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            DataRow row = table.Rows[0];
                            textBox1.Text = row["ProductName"].ToString();
                            textBox2.Text = row["Quantity"].ToString();
                            textBox3.Text = row["Price"].ToString();
                            textBox4.Text = row["Category"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxsearch.Text, out int ProductID))
            {
                MessageBox.Show("Please enter a valid ProductID!");
                return;
            }

            LoadDataByProductID(ProductID);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete!");
                return;
            }

            var productIDCellValue = dgvStock.CurrentRow.Cells["ProductID"].Value;
            if (productIDCellValue == null || !int.TryParse(productIDCellValue.ToString(), out int ProductID))
            {
                MessageBox.Show("Invalid ProductID!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@ProductID", ProductID);

                    con.Open(); // Correctly open the `con` connection
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!");
                        LoadData(); // Refresh the data grid view
                    }
                    else
                    {
                        MessageBox.Show("No product found with the given ID.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxsearch.Text, out int ProductID))
            {
                MessageBox.Show("Please enter a valid ProductID!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ProductID, ProductName, Quantity, Price, Category FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            dgvStock.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
