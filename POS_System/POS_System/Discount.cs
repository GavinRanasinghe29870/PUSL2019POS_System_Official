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
    public partial class Discount : Form
    {
        private string connectionString = @"Data Source=Vihanga\SQLEXPRESS;Initial Catalog=abcsupermarket;Integrated Security = True;Encrypt=True;Trust Server Certificate=True;";
        private SqlConnection connection;
        public Discount()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void Discount_Load(object sender, EventArgs e)
        {
            LoadDiscounts();
        }

        private void LoadDiscounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //string query = "SELECT * FROM Discount";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDiscounts.DataSource = dt;
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string discountType = cmbDisType.Text;
            decimal percentage = numDisPercentage.Value;
            string productSpecific = cmbProduct.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (string.IsNullOrEmpty(discountType))
            {
                MessageBox.Show("Please select the Discount Type!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Discount (DiscType,DiscPercentage,ProductID,StartDate,EndDate) " +
                               "VALUES (@discountType,@percentage,@productSpecifi,@startDate,@endDatee)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@discountType", discountType);
                    cmd.Parameters.AddWithValue("@percentage", percentage);
                    cmd.Parameters.AddWithValue("@productSpecific", productSpecific);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Discount Added Successfully!");
            LoadDiscounts();


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
