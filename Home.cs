using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Home : MetroSetForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void metroSetButton7_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            ManageCategories categories = new ManageCategories();
            this.Hide();
            categories.Show();
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            this.Hide();
            orders.Show();
        }

        private void metroSetButton5_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            this.Hide();
            users.Show();
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            ManageProducts products = new ManageProducts();
            this.Hide();
            products.Show();
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            this.Hide();
            viewOrders.Show();
        }

        private void metroSetButton6_Click(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            this.Hide();
            customers.Show();
        }
    }
}
