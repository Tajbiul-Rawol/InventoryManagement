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
            var query = "select * from ProductTable";
            try
            {
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
                    customerNameTextBox.Enabled = false;
                }
            }
        }

        private void refreshProductBtn_Click(object sender, EventArgs e)
        {
            orderIDTextBox.Text = string.Empty;
            customerIDTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            orderDateTime.Value = DateTime.Today;
            quantityTextBox.Text = string.Empty;
            populateCustomerGrid();
            populateProductGrid();
            emptyOrdersGridView();
        }



        int num, productID = 0;
        int totalPrice, quantity;
        string product, unitPrice, selectedProduct;
        int flag = 0;
        int totalQuantity = 0;
        int selectedRow = 0;
        private void ordersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedRow = e.RowIndex;
                var gridView = (DataGridView)sender;
                //selectedID = productID;
                productID = Convert.ToInt32(gridView.Rows[selectedRow].Cells[1].Value.ToString());
                product = gridView.Rows[selectedRow].Cells[2].Value.ToString();
                selectedProduct = product;
                quantityTextBox.Text = gridView.Rows[selectedRow].Cells[3].Value.ToString();
                unitPrice = gridView.Rows[selectedRow].Cells[4].Value.ToString();
                flag = 1;
            }
        }

        private void deleteToOrderButton_Click(object sender, EventArgs e)
        {

            if (product == null && flag == 0 || selectedRow == -1)
            {
                MessageBox.Show("Select an product to remove from the order list");
                return;
            }
            var confirmMessage = MessageBox.Show("Are you sure you want to remove this category?", "Cofirm delete", MessageBoxButtons.YesNo);

            if (confirmMessage == DialogResult.Yes)
            {

                if (product == selectedProduct)
                {
                    for (int row = 0; row < productGridView.Rows.Count; row++)
                    {
                        if (Convert.ToInt32(productGridView.Rows[row].Cells[0].Value.ToString()) == productID)
                        {
                            stock = Convert.ToInt32(productGridView.Rows[row].Cells[2].Value.ToString());
                            break;
                        }
                        continue;
                    }
                    int stockQuantity = stock + Convert.ToInt32(quantityTextBox.Text);                
                    var query = "update ProductTable set ProductQuantity='" + stockQuantity + "' where ProductId='" + productID + "' ";
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    ordersGridView.AllowUserToAddRows = false;
                    ordersGridView.Rows.RemoveAt(selectedRow);
                    row--;
                    sum -= totalPrice;
                    totalQuantity -= quantity;
                    totAmountlbl.Text = "BDT " + sum.ToString();
                    MessageBox.Show("deleted");
                    populateProductGrid();
                }
                

            }
                
        }

        int stock = 0;
        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var gridView = (DataGridView)sender;
                productID = Convert.ToInt32(gridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                product = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                stock = Convert.ToInt32(gridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                unitPrice = gridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                flag = 1;
                
            }

        }

        private void insertOrdersBtn_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            if (orderIDTextBox.Text == string.Empty ||
                customerIDTextBox.Text == string.Empty || 
                customerNameTextBox.Text == string.Empty ||
                orderDateTime.Text == string.Empty)
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            if (totAmountlbl.Text == "BDT")
            {
                MessageBox.Show("Please add products to the Orders list to place an order");
                return;
            }

            var query = "insert into OrderTable values('" + orderIDTextBox.Text + "','" + customerIDTextBox.Text + "','" + customerNameTextBox.Text + "','" + Convert.ToDateTime(orderDateTime.Text) + "', '" + totalPrice + "','" + totalQuantity + "')";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                for (int progress = 0; progress < 100; progress += 5)
                {
                    if (progressBar.Value <= 100)
                    {
                         progressBar.Value = progress;
                    }
                    else
                    {
                        break;
                    }
                }
                progressBar.Value = 100;
                MessageBox.Show("Order Created Successfully");
                progressBar.Value = 0;
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            populateCustomerGrid();
            populateProductGrid();
        }


        private void emptyOrdersGridView()
        {
            ordersGridView.AllowUserToAddRows = false;

            for (int row = 0; row < ordersGridView.Rows.Count; row++)
            {
                ordersGridView.Rows.Remove(ordersGridView.Rows[row]);
            }
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrder = new ViewOrders();
            viewOrder.Show();
        }

        int row = -1;

        private void label11_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        int sum = 0;
        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity of products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Please select a product first");
            }
            else if (Convert.ToInt32(quantityTextBox.Text) > stock)
            {
                MessageBox.Show("Order quantity cannot exceed Stock quantity!");
            }
            else
            {
                row++;
                num += 1;
                quantity = Convert.ToInt32(quantityTextBox.Text);
                var uPrice = Convert.ToInt32(unitPrice);
                totalPrice = quantity * uPrice;
                ordersGridView.Rows.Add(num, productID, product, quantity, uPrice, totalPrice);
                totalQuantity += quantity;
          
            }

            sum += totalPrice;
            totAmountlbl.Text = "BDT " + sum.ToString();
            updateQuantity();
            quantityTextBox.Text = string.Empty;
        }
        int newQuantity = 0;
        private void updateQuantity()
        {
            newQuantity = stock - Convert.ToInt32(quantityTextBox.Text);

            if (newQuantity < 0)
            {
                MessageBox.Show("Operation Failed");
                return;
            }
            var query = "update ProductTable set ProductQuantity='"+newQuantity+"' where ProductId='"+productID+"' ";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            populateProductGrid();
        }

    }
}
