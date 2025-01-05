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

namespace POS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static int loggedUser = 0;
        private void textBox1_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            if (textBox1_login.Text == "Owner@admin" && textBox2_login.Text == "ownerPassword")
            {
                CustomerM customerM = new CustomerM();
                customerM.Show();
                this.Hide();
            }
            else
            {
                string Username = textBox1_login.Text;
                string Password = textBox2_login.Text;
                string selectRole = comboBox1_login.SelectedItem.ToString();

                string connectionString = ConnectionString.constring;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = $"SELECT * FROM Users WHERE UserName =  @Username AND Passwords = @Passwords AND UserType = @UserType";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", Username);
                            cmd.Parameters.AddWithValue("@Passwords", Password);
                            cmd.Parameters.AddWithValue("@UserType", selectRole);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    loggedUser = reader.GetInt32(0);

                                    if (selectRole == "Cashier")
                                    {
                                        sales_billing sales_Billing = new sales_billing();
                                        sales_Billing.Show();
                                    }
                                    else if (selectRole == "Admin")
                                    {
                                        Console.Write(loggedUser);
                                        Dashboard dashboard = new Dashboard();
                                        dashboard.Show();
                                    }

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Credential. Please Try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error Occurred: "+ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
