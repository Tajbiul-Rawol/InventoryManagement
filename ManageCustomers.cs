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

namespace InventoryManagement
{
    public partial class ManageCustomers : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
           
            if (customerIDTextBox.Text == string.Empty)
            {
                MessageBox.Show("User ID cannot be Empty!");
                return;
            }
            if (customerNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("User name cannot be Empty!");
                return;
            }
            if (customerPhoneTextBox.Text == string.Empty)
            {
                MessageBox.Show("Full Name cannot be Empty!");
                return;
            }
            if (customerEmailTextBox.Text == string.Empty)
            {
                MessageBox.Show("password cannot be Empty!");
                return;
            }
            

            try
            {
                var query = "insert into CustomerTable values('" + customerIDTextBox.Text + "','" + customerNameTextBox.Text + "','" + customerPhoneTextBox.Text + "','" + customerEmailTextBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully!");
                connection.Close();
                customerIDTextBox.Text = string.Empty;
                customerNameTextBox.Text = string.Empty;
                customerPhoneTextBox.Text = string.Empty;
                customerEmailTextBox.Text = string.Empty;
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void populateGrid()
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

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerIDTextBox.Text == string.Empty ||
                customerNameTextBox.Text == string.Empty ||
                customerPhoneTextBox.Text == string.Empty ||
                customerEmailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            var query = "update CustomerTable set CustName='" + customerNameTextBox.Text + "', CustPhone='" + customerPhoneTextBox.Text + "', CustEmail='" + customerEmailTextBox.Text + "' where CustId='" + customerIDTextBox.Text + "' ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully");
                connection.Close();
                customerIDTextBox.Enabled = true;
                customerIDTextBox.Text = string.Empty;
                customerNameTextBox.Text = string.Empty;
                customerPhoneTextBox.Text = string.Empty;
                customerEmailTextBox.Text = string.Empty;
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //check the index of the row of the selected cell
            //if it is != 1 then bind the data
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = customerGridView.Rows[e.RowIndex];
                customerIDTextBox.Text = dataGridViewRow.Cells[0].Value.ToString();
                if (customerIDTextBox.Text != string.Empty)
                {
                    customerIDTextBox.Enabled = false;
                }
                customerNameTextBox.Text = dataGridViewRow.Cells[1].Value.ToString();
                customerPhoneTextBox.Text = dataGridViewRow.Cells[2].Value.ToString();
                customerEmailTextBox.Text = dataGridViewRow.Cells[3].Value.ToString();
                var countquery = "select Count(*) from OrderTable where CustId='" + customerIDTextBox.Text + "' ";
                var totalAmountquery = "select Sum(TotalAmount) from OrderTable where CustId='" + customerIDTextBox.Text + "' ";
                var orderDatequery = "select Max(OrderDate) from OrderTable where CustId='" + customerIDTextBox.Text + "' ";
                showOrderData(countquery);
                showTotalAmount(totalAmountquery);
                showOrderDate(orderDatequery);
            }

        }

        private void showOrderData(string query)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            orderLbl.Text = dataTable.Rows[0][0].ToString();
            connection.Close();
        }
        private void showTotalAmount(string query)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            amountsLbl.Text = dataTable.Rows[0][0].ToString();
            connection.Close();
        }
        private void showOrderDate(string query)
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dateLbl.Text = dataTable.Rows[0][0].ToString();
            connection.Close();
        }




        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure You want to delete this customer?","Confirm Delete",MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var query = "delete from CustomerTable where CustId='" + customerIDTextBox.Text + "' ";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully");
                    connection.Close();

                    customerIDTextBox.Text = string.Empty;
                    customerNameTextBox.Text = string.Empty;
                    customerPhoneTextBox.Text = string.Empty;
                    customerEmailTextBox.Text = string.Empty;
                    populateGrid();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return;
            
        }

        private void refreshCustomerBtn_Click(object sender, EventArgs e)
        {
            customerIDTextBox.Enabled = true;
            customerIDTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            customerPhoneTextBox.Text = string.Empty;
            customerEmailTextBox.Text = string.Empty;
            searchCustomerTextBox.Text = string.Empty;
            populateGrid();
        }

        

        private void searchCustomerBtn_Click(object sender, EventArgs e)
        {
            if (searchCustomerTextBox.Text == string.Empty)
            {
                MessageBox.Show("Search by Name or ID must be in the search field");
                return;
            }

            try
            {
                var query = "select * from CustomerTable where CustId like   '%" + searchCustomerTextBox.Text + "%' or CustName like '%" + searchCustomerTextBox.Text + "%' or CustPhone like '%" + searchCustomerTextBox.Text + "%' or CustEmail like '%" + searchCustomerTextBox.Text + "%' ";
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
                customerGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
