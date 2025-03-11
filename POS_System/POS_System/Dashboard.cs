using StockManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl1UserM1.Show();
            userControl1Discount2.Hide();
            userControl1Report1.Hide();
            userControl1stockManagement1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MainForm MainForm = new MainForm();
            //MainForm.Show();
            //this.Hide();
            userControl1stockManagement1.Show();
            userControl1Report1.Hide();
            userControl1Discount2.Hide();
            userControl1UserM1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Discount Discount = new Discount();
            //Discount.Show();
            userControl1Discount2.Show();
            userControl1Report1.Hide();
            userControl1UserM1.Hide();
            userControl1stockManagement1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Report Report = new Report();
            //Report.Show();
            userControl1Report1.Show();
            userControl1Discount2.Hide();
            userControl1UserM1.Hide();
            userControl1stockManagement1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
