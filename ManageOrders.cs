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

namespace InventoryManagement
{
    public partial class ManageOrders : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void FillCategory()
        {
            try
            {

                string query = "select * from CategoryTable";

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    searchCategoryComboBox.DataSource = dataTable;
                    searchCategoryComboBox.DisplayMember = "CatName";
                    searchCategoryComboBox.ValueMember = "CatName";
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void populateProductGrid()
        {
            try
            {
                var query = "select * from ProductTable";
                //open connection
                connection.Open();
                //create a sql data adapter using the query and connection
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                //create a dataset
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                productGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void populateCustomerGrid()
        {
            try
            {
                //open connection
                connection.Open();
                var query = "select * from CustomerTable";
                //create a sql data adapter using the query and connection
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                //create a dataset
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                customerGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            FillCategory();
            populateCustomerGrid();
            populateProductGrid();
        }

        private void searchCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = searchCategoryComboBox.SelectedValue.ToString();
            var query = "select * from ProductTable where ProductCategory='" + selectedCategory + "'";
            ProductLoadBySelectedCategory(query);
  
        }

        private void ProductLoadBySelectedCategory(string query)
        {
            //create a sql data adapter using the query and connection
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            //create a dataset
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            productGridView.DataSource = dataSet.Tables[0];
     
        }

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var gridView = (DataGridView)sender;
                customerIDTextBox.Text = gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerNameTextBox.Text = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (customerIDTextBox.Text != string.Empty)
                {
                    customerIDTextBox.Enabled = false;
                }
            }
        }

        private void refreshProductBtn_Click(object sender, EventArgs e)
        {
            orderIDTextBox.Text = string.Empty;
            customerIDTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            orderDateTime.Value = DateTime.Today;
            populateCustomerGrid();
        }
    }
}
