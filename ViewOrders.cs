using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace InventoryManagement
{
    public partial class ViewOrders : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void populateViewOrdersGrid()
        {
            var query = "select * from OrderTable";
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                viewOrdersGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateViewOrdersGrid();
        }

        int selectedIndex = 0;
        private void viewOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedIndex = e.RowIndex;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Arial", 25, FontStyle.Bold), new SolidBrush(Color.Red), 300.0F, 0.0F);
            e.Graphics.DrawString("Order ID: "+viewOrdersGridView.Rows[selectedIndex].Cells[0].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 150.0F);
            e.Graphics.DrawString("Customer ID: " + viewOrdersGridView.Rows[selectedIndex].Cells[1].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 190.0F);
            e.Graphics.DrawString("Customer Name: " + viewOrdersGridView.Rows[selectedIndex].Cells[2].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 230.0F);
            e.Graphics.DrawString("Order Date: " + viewOrdersGridView.Rows[selectedIndex].Cells[3].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 270.0F);
            e.Graphics.DrawString("Total Amount: " + viewOrdersGridView.Rows[selectedIndex].Cells[4].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 310.0F);
            e.Graphics.DrawString("Quantity: " + viewOrdersGridView.Rows[selectedIndex].Cells[5].Value.ToString(), new Font("Arial", 25, FontStyle.Regular), new SolidBrush(Color.Black), 80.0F, 350.0F);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ManageOrders);
            if (formToShow != null)
            {
                formToShow.Show();
                this.Hide();
                return;
            }
                Home home = new Home();
                this.Hide();
                home.Show();
        }

        private void searchOrderBtn_Click(object sender, EventArgs e)
        {
            if (searchOrderTextBox.Text == string.Empty)
            {
                MessageBox.Show("Search by Name or ID must be in the search field");
                return;
            }

            try
            {
                var query = "select * from OrderTable where OrderId like '%" + searchOrderTextBox.Text + "%' or CustName like '%" + searchOrderTextBox.Text + "%'  or OrderDate like '%" + searchOrderTextBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Order not Found");
                    return;
                }
                viewOrdersGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            searchOrderTextBox.Text = string.Empty;
            populateViewOrdersGrid();
        }
    }
}
