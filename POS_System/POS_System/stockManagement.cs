using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class MainForm : Form
    {
        // DataTable to hold stock items
        private DataTable stockTable;

        public MainForm()
        {
            InitializeComponent();
            InitializeStockTable();
        }

        // Initialize the DataTable and bind it to the DataGridView
        private void InitializeStockTable()
        {
            stockTable = new DataTable();
            stockTable.Columns.Add("Item Name", typeof(string));
            stockTable.Columns.Add("Category", typeof(string));
            stockTable.Columns.Add("Price", typeof(decimal));
            stockTable.Columns.Add("Quantity", typeof(int));

            dataGridView1.DataSource = stockTable;
        }

        // Add a new item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                stockTable.Rows.Add(ColItemName.HeaderText, ColCategory.HeaderText, Convert.ToDecimal(ColPrice.HeaderText), Convert.ToInt32(ColQuantity.HeaderText));
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Edit the selected item
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && ValidateInputs())
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                selectedRow.Cells["Item Name"].Value = ColItemName.HeaderText;
                selectedRow.Cells["Category"].Value = ColCategory.HeaderText;
                selectedRow.Cells["Price"].Value = Convert.ToDecimal(ColPrice.HeaderText);
                selectedRow.Cells["Quantity"].Value = Convert.ToInt32(ColQuantity.HeaderText);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select a row and fill all fields correctly.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete the selected item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Search for items
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue =textBox3.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Cells["Item Name"].Value.ToString().ToLower().Contains(searchValue) ||
                              row.Cells["Category"].Value.ToString().ToLower().Contains(searchValue);
            }
        }

        // Validate input fields
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(ColItemName.HeaderText) &&
                   !string.IsNullOrWhiteSpace(ColCategory.HeaderText) &&
                   decimal.TryParse(ColPrice.HeaderText, out _) &&
                   int.TryParse(ColQuantity.HeaderText, out _);
        }

        // Clear input fields
        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
