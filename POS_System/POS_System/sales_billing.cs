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

namespace POS_System
{
    public partial class sales_billing : Form
    {
        public sales_billing()
        {
            InitializeComponent();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            Product product = new Product { Name = barcode, Price = (decimal)(new Random().NextDouble() * 100), Quantity = 1 };

            var existingProduct = cart.Find(item => item.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity++;
            }
            else
            {
                cart.Add(product);
            }

            UpdateCart();
            txtBarcode.Clear();
        }
        private void AddProductToDatabase(string barcode, decimal price, int quantity)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Products (Barcode, Price, Quantity) VALUES (@Barcode, @Price, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateCart()
        {
            // Ensure columns are defined only once
            if (dgvCart.Columns.Count == 0)
            {
                dgvCart.Columns.Add("Name", "Product Name");
                dgvCart.Columns.Add("Price", "Price");
                dgvCart.Columns.Add("Quantity", "Quantity");
                dgvCart.Columns.Add("Total", "Total");
            }

            dgvCart.Rows.Clear();
            subtotal = 0;

            foreach (var item in cart)
            {
                decimal itemTotal = item.Price * item.Quantity;
                dgvCart.Rows.Add(item.Name, item.Price.ToString("F2"), item.Quantity, itemTotal.ToString("F2"));
                subtotal += itemTotal;
            }

            CalculateTotals();
        }

        private void CalculateTotals()
        {
            decimal discount = GetDiscountFromDatabaseById(selectedDiscountId); // Get the discount using the selected Discount ID
            decimal tax = subtotal * taxRate;
            decimal total = subtotal - discount + tax;

            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDiscount.Text = $"Discount: ${discount:F2}";
            lblTax.Text = $"Tax (10%): ${tax:F2}";
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private decimal GetDiscountFromDatabaseById(int discountId)
        {
            decimal discount = 0;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DiscPercentage FROM Discount WHERE DiscountID = @DiscountID"; // Query by Discount ID
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DiscountID", discountId); // Pass the Discount ID as a parameter
                        object result = cmd.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal discountPercentage))
                        {
                            discount = discountPercentage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching discount by ID from database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return discount;
        }

        // Example property for storing the selected Discount ID
        private int selectedDiscountId = 1; // Default or user-selected Discount ID



        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                string productName = dgvCart.SelectedRows[0].Cells[0].Value.ToString();
                var productToRemove = cart.Find(item => item.Name == productName);
                if (productToRemove != null)
                {
                    cart.Remove(productToRemove);
                }

                UpdateCart();
            }
        }

        //function 1
        private decimal CalculateDiscountedTotal(decimal subtotal, decimal discount)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT dbo.CalculateDiscountedTotal(@subtotal, @discount)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    conn.Open();
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }
        //function 2

        private decimal CalculateTax(decimal amount, decimal taxRate)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT dbo.CalculateTax(@amount, @taxRate)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@taxRate", taxRate);
                    conn.Open();
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }
        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            // Assume selectedDiscountId is updated elsewhere when a discount is selected
            decimal discount = GetDiscountFromDatabaseById(selectedDiscountId);

            if (discount > 0)
            {
                CalculateTotals();
            }
            else
            {
                MessageBox.Show("No discount selected or found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCusID.Text, out int customerID))
            {
                MessageBox.Show("Please enter a valid Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string receipt = "Billing Receipt\n\nProducts:\n";
            decimal discount = GetDiscountFromDatabaseById(selectedDiscountId); // Get discount by ID
            decimal tax = subtotal * taxRate;
            decimal total = subtotal - discount + tax;

            foreach (var item in cart)
            {
                decimal itemTotal = item.Price * item.Quantity;
                receipt += $"{item.Name}: ${item.Price:F2} x {item.Quantity} = ${itemTotal:F2}\n";
            }
            receipt += $"\nSubtotal: ${subtotal:F2}\n";
            receipt += $"Discount: ${discount:F2}\n";
            receipt += $"Tax (10%): ${tax:F2}\n";
            receipt += $"Total: ${total:F2}\n";

            MessageBox.Show(receipt, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save the sales data to the database with CustomerID
            SaveSalesData(total, discount, tax, subtotal, customerID);
        }


        private void SaveSalesData(decimal total, decimal discount, decimal tax, decimal subtotal, int customerID)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Insert into Sales table
                    string insertSalesQuery = @"
                INSERT INTO Sales (CustomerID, Subtotal, Discount, Tax, Total, Date)
                OUTPUT INSERTED.SaleID
                VALUES (@CustomerID, @Subtotal, @Discount, @Tax, @Total, @Date)";
                    int saleId;
                    using (SqlCommand cmd = new SqlCommand(insertSalesQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                        cmd.Parameters.AddWithValue("@Discount", discount);
                        cmd.Parameters.AddWithValue("@Tax", tax);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        saleId = (int)cmd.ExecuteScalar();
                    }

                    // Insert into SalesDetails table
                    string insertDetailsQuery = @"
                INSERT INTO SalesDetails (SaleID, ProductName, Price, Quantity, Total)
                VALUES (@SaleID, @ProductName, @Price, @Quantity, @Total)";
                    foreach (var item in cart)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertDetailsQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleId);
                            cmd.Parameters.AddWithValue("@ProductName", item.Name);
                            cmd.Parameters.AddWithValue("@Price", item.Price);
                            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            cmd.Parameters.AddWithValue("@Total", item.Price * item.Quantity);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Sales data successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cart.Clear();
                UpdateCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerM customerM = new CustomerM();
            customerM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
  


    
}
