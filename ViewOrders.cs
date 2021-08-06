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
                //open connection
                connection.Open();
                //create a sql data adapter using the query and connection
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                //create a dataset
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
    }
}
