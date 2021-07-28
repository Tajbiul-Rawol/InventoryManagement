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
            SqlCommand cmd = new SqlCommand("insert into CustomerTable values('" + customerIDTextBox.Text + "','" + customerNameTextBox.Text + "','" + customerPhoneTextBox.Text + "','" + customerEmailTextBox.Text + "')",connection);
            try
            {
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
    }
}
