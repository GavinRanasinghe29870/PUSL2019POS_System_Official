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
using POS_System.Classes;

namespace POS_System.UserControls
{
    public partial class UserControl1UserM : UserControl
    {
        public UserControl1UserM()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            string conString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataView.DataSource = dt;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Uname.Text) ||
                string.IsNullOrEmpty(Upassword.Text) ||
                string.IsNullOrEmpty(Uemail.Text) ||
                string.IsNullOrEmpty(Utype.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string conString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("AddUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", Uname.Text);
                cmd.Parameters.AddWithValue("@Password", Upassword.Text);
                cmd.Parameters.AddWithValue("@Email", Uemail.Text);
                cmd.Parameters.AddWithValue("@UserType", Utype.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("User added successfully!");
            LoadUserData();
            ClearFields();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Uname.Text) ||
                string.IsNullOrEmpty(Upassword.Text) ||
                string.IsNullOrEmpty(Uemail.Text) ||
                string.IsNullOrEmpty(Utype.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (dataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string conString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", Uname.Text);
                cmd.Parameters.AddWithValue("@Password", Upassword.Text);
                cmd.Parameters.AddWithValue("@Email", Uemail.Text);
                cmd.Parameters.AddWithValue("@UserType", Utype.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully.");
                    LoadUserData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            string query = "DELETE FROM Users WHERE UserID = @UserID";

            string conString = ConnectionString.constring;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", dataView.SelectedRows[0].Cells[0].Value);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User removed successfully.");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            //Uid.Clear();
            Uname.Clear();
            Upassword.Clear();
            Uemail.Clear();
            Utype.Clear();
        }

        private void UserControl1UserM_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
