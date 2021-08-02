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
            FillCategory();
        }
    }
}
