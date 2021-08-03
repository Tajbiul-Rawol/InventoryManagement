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
    public partial class ManageProducts : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageProducts()
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
                    productCategoryComboBox.DataSource = dataTable;
                    productCategoryComboBox.DisplayMember = "CatName";
                    productCategoryComboBox.ValueMember = "CatName";
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


        private void ManageProducts_Load(object sender, EventArgs e)
        {
            populateGrid();
            FillCategory();
        }


        private void populateGrid()
        {
            try
            {
                //open connection
                connection.Open();
                var query = "select * from ProductTable";
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

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "insert into ProductTable values('" + productIDTextBox.Text + "','" + productNameTextBox.Text + "','" + productQuantityTextBox.Text + "','" + productPriceTextBox.Text + "','" +descriptionTextBox.Text + "','" + productCategoryComboBox.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully!");
                connection.Close();
                productIDTextBox.Text = string.Empty;
                productNameTextBox.Text = string.Empty;
                productPriceTextBox.Text = string.Empty;
                productQuantityTextBox.Text = string.Empty;
                descriptionTextBox.Text = string.Empty;
                searchProductTextBox.Text = string.Empty;
                productCategoryComboBox.SelectedIndex = -1;
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = productGridView.Rows[e.RowIndex];
                productIDTextBox.Text = dataGridViewRow.Cells[0].Value.ToString();
                if (productIDTextBox.Text != string.Empty)
                {
                    productIDTextBox.Enabled = false;
                }
                productNameTextBox.Text = dataGridViewRow.Cells[1].Value.ToString();
                productPriceTextBox.Text = dataGridViewRow.Cells[2].Value.ToString();
                productQuantityTextBox.Text = dataGridViewRow.Cells[3].Value.ToString();
                descriptionTextBox.Text = dataGridViewRow.Cells[4].Value.ToString();
                productCategoryComboBox.SelectedValue = dataGridViewRow.Cells[5].Value.ToString();
            }
        }

        private void refreshProductBtn_Click(object sender, EventArgs e)
        {
            productIDTextBox.Text = string.Empty;
            productNameTextBox.Text = string.Empty;
            productPriceTextBox.Text = string.Empty;
            productQuantityTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            searchProductTextBox.Text = string.Empty;
            productCategoryComboBox.SelectedIndex = -1;
            populateGrid();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            var query = "update ProductTable set ProductName='" + productNameTextBox.Text + "', ProductQuantity='" + productQuantityTextBox.Text + "', ProductPrice='" + productPriceTextBox.Text + "', Description='" + descriptionTextBox.Text + "', ProductCategory='" + productCategoryComboBox.SelectedValue.ToString() + "' where ProductId='" + productIDTextBox.Text + "' ";
            try
            {
                SqlCommand cmd = new SqlCommand(query,connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Update Successful");
                connection.Close();
                productIDTextBox.Text = string.Empty;
                productNameTextBox.Text = string.Empty;
                productPriceTextBox.Text = string.Empty;
                productQuantityTextBox.Text = string.Empty;
                descriptionTextBox.Text = string.Empty;
                searchProductTextBox.Text = string.Empty;
                productCategoryComboBox.SelectedIndex = -1;
                populateGrid();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            var query = "delete from ProductTable where ProductId='" + productIDTextBox.Text + "' ";

            var confirmResult = MessageBox.Show("Are you sure You want to delete this Product ?","Confirm to Delete",MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    connection.Close();
                    productIDTextBox.Text = string.Empty;
                    productNameTextBox.Text = string.Empty;
                    productPriceTextBox.Text = string.Empty;
                    productQuantityTextBox.Text = string.Empty;
                    descriptionTextBox.Text = string.Empty;
                    searchProductTextBox.Text = string.Empty;
                    productCategoryComboBox.SelectedIndex = -1;
                    populateGrid();
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {
            if (searchProductTextBox.Text == string.Empty)
            {
                MessageBox.Show("Search by Product Name or any other details must be in the search field");
                return;
            }

            try
            {
                var query = "select * from ProductTable where ProductId like   '%" + searchProductTextBox.Text + "%' or ProductName like '%" + searchProductTextBox.Text + "%' or ProductPrice like '%" + searchProductTextBox.Text + "%' or Description like '%" + searchProductTextBox.Text + "%' or ProductCategory like '%" + searchProductTextBox.Text + "%' ";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Customer not Found");
                    return;
                }
                productGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
