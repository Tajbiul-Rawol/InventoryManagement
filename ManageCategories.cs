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
    public partial class ManageCategories : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (categoryIDTextBox.Text == string.Empty || categoryNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }

            try
            {
                var query = "insert into CategoryTable values('"+categoryIDTextBox.Text+"','"+categoryNameTextBox.Text+"')";
                SqlCommand cmd = new SqlCommand(query,connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category created Successfully");
                connection.Close();
                categoryIDTextBox.Text = string.Empty;
                categoryNameTextBox.Text = string.Empty;
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
                connection.Open();
                var query = "select * from CategoryTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                categoryGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            var confirmMessage = MessageBox.Show("Are you sure you want to remove this category?","Cofirm delete",MessageBoxButtons.YesNo);

            if (confirmMessage == DialogResult.Yes)
            {
                try
                {
                    var query = "delete from CategoryTable where CatId='" + categoryIDTextBox.Text + "' ";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category removed successfully");
                    connection.Close();

                    categoryIDTextBox.Text = string.Empty;
                    categoryNameTextBox.Text = string.Empty;
                    populateGrid();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void catgegoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = categoryGridView.Rows[e.RowIndex];
                categoryIDTextBox.Text = dataGridViewRow.Cells[0].Value.ToString();
                if (categoryIDTextBox.Text != string.Empty)
                {
                    categoryIDTextBox.Enabled = false;
                }
                categoryNameTextBox.Text = dataGridViewRow.Cells[1].Value.ToString();
                
            }
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            var query = "update CategoryTable set CatName='" + categoryNameTextBox.Text + "' where CatId='" + categoryIDTextBox.Text + "' ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully");
                connection.Close();
                categoryIDTextBox.Text = string.Empty;
                categoryNameTextBox.Text = string.Empty;
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
