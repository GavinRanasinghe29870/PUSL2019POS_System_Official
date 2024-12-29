using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace POS_System
{
    partial class sales_billing
    {
        private System.ComponentModel.IContainer components = null;
        string connectionString = "Data Source=DESKTOP-QT104GF\\SQLEXPRESS;Initial Catalog=abcsupermarket;Integrated Security=True";

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void InitializeComponent()
        {
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(16, 15);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(265, 22);
            this.txtBarcode.TabIndex = 0;
            // 
            // numericDiscount
            // 
            this.numericDiscount.Location = new System.Drawing.Point(16, 47);
            this.numericDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(265, 22);
            this.numericDiscount.TabIndex = 1;
            this.numericDiscount.ValueChanged += new System.EventHandler(this.numericDiscount_ValueChanged);
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(16, 79);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(1035, 308);
            this.dgvCart.TabIndex = 2;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(16, 406);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(93, 16);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(16, 434);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 16);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount: $0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(16, 463);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(104, 16);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax (10%): $0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 491);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: $0.00";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(291, 12);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnRemoveProduct.Location = new System.Drawing.Point(399, 12);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(133, 28);
            this.btnRemoveProduct.TabIndex = 8;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnGenerateBill.Location = new System.Drawing.Point(540, 12);
            this.btnGenerateBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(133, 28);
            this.btnGenerateBill.TabIndex = 9;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // sales_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.numericDiscount);
            this.Controls.Add(this.txtBarcode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sales_billing";
            this.Text = "Sales and Billing";
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnGenerateBill;

        // Add the event handlers and logic here
        private List<Product> cart = new List<Product>();
        private decimal subtotal = 0;
        private const decimal taxRate = 0.10m;



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
            decimal discount = numericDiscount.Value;
            decimal tax = subtotal * taxRate;
            decimal total = subtotal - discount + tax;

            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDiscount.Text = $"Discount: ${discount:F2}";
            lblTax.Text = $"Tax (10%): ${tax:F2}";
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

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


        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            string receipt = "Billing Receipt\n\nProducts:\n";
            decimal discount = numericDiscount.Value;
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
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
