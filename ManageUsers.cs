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
    public partial class ManageUsers : Form
    {
        //create the connection string
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
       
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("insert into UserTbl values('" + userNameTextBox.Text+"','"+fullNameTextBox.Text+"','"+passwordTextBox.Text+"','"+telephoneTextBox.Text+"','"+emailTextBox.Text+"')", connection);
            try
            {
                //open the connection using the connection string
                connection.Open();
                //execute the query
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                //close the connection
                connection.Close();
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
                var query = "select * from UserTbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                //create a dataset
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                userGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void showPasswordCheckBox_CheckedChanged(object sender)
        {
            if (passwordTextBox.UseSystemPasswordChar == true) passwordTextBox.UseSystemPasswordChar = false;
            else passwordTextBox.UseSystemPasswordChar = true;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populateGrid();
        }
    }
}
