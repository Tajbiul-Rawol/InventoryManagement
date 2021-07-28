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
                //populate data on grid
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
                var query = "select * from UserTbl";
                //create a sql data adapter using the query and connection
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

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (telephoneTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The user telephone number to delete");
            }
            else
            {
                connection.Open();
                var query = "delete from UserTbl where Utelephone = '" + telephoneTextBox.Text + "'";
                SqlCommand command = new SqlCommand(query,connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                connection.Close();
                populateGrid();
            }
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check the index of the row of the selected cell
            //if it is != 1 then bind the data
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridRow = userGridView.Rows[e.RowIndex];
                userNameTextBox.Text = dataGridRow.Cells[0].Value.ToString();
                fullNameTextBox.Text = dataGridRow.Cells[1].Value.ToString();
                passwordTextBox.Text = dataGridRow.Cells[2].Value.ToString();
                telephoneTextBox.Text = dataGridRow.Cells[3].Value.ToString();
                emailTextBox.Text = dataGridRow.Cells[4].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("update UserTbl set Uname= '"+userNameTextBox.Text+"', Ufullname='"+fullNameTextBox.Text+"', Upassword='"+passwordTextBox.Text+"', Uemail='"+emailTextBox.Text+"' where Utelephone='"+telephoneTextBox.Text+"' ", connection);
            try
            {
                //open the connection using the connection string
                connection.Open();
                //execute the query
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                //close the connection
                connection.Close();
                //populate data on grid
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
