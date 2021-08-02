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
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dataReader;

                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CatName", typeof(string));
                    dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                    productCategoryComboBox.ValueMember = "CatName";
                    productCategoryComboBox.DataSource = dataTable;
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
