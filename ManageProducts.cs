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
                productQuantityTextBox.Text = string.Empty;
                descriptionTextBox.Text = string.Empty;
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
    }
}
