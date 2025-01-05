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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Discount Discount = new Discount();
            Discount.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            Report.Show();
            this.Hide();
        }
    }
}
