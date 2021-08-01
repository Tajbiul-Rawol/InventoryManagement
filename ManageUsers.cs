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
            
            if (userIdTextBox.Text == string.Empty)
            {
                MessageBox.Show("User ID cannot be Empty!");
                return;
            }
            if (userNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("User name cannot be Empty!");
                return;
            }
            if (fullNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Full Name cannot be Empty!");
                return;
            }
            if (passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("password cannot be Empty!");
                return;
            }
            if (telephoneTextBox.Text == string.Empty)
            {
                MessageBox.Show("telephone cannot be Empty!");
                return;
            }
            if (emailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Email cannot be Empty!");
                return;
            }

            try
            {
                SqlCommand sqlCmd = new SqlCommand("insert into UserTable values('" + userIdTextBox.Text + "','" + userNameTextBox.Text + "','" + fullNameTextBox.Text + "','" + passwordTextBox.Text + "','" + telephoneTextBox.Text + "','" + emailTextBox.Text + "')", connection);
                //open the connection using the connection string
                connection.Open();
                //execute the query
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                //close the connection
                connection.Close();
                //populate data on grid

                //empty the texboxes after adding
                userIdTextBox.Text = string.Empty;
                userNameTextBox.Text = string.Empty;
                fullNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                telephoneTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
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
                var query = "select * from UserTable";
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
           
                var confirmResult = MessageBox.Show("Are you sure you want to delete this data?","Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    connection.Open();
                    var query = "delete from UserTable where Utelephone = '" + telephoneTextBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    connection.Close();

                    userIdTextBox.Text = string.Empty;
                    userNameTextBox.Text = string.Empty;
                    fullNameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    telephoneTextBox.Text = string.Empty;
                    emailTextBox.Text = string.Empty;
                    populateGrid();
                }

                return;
          
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check the index of the row of the selected cell
            //if it is != 1 then bind the data
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridRow = userGridView.Rows[e.RowIndex];
                userIdTextBox.Text = dataGridRow.Cells[0].Value.ToString();
                if (userIdTextBox.Text != string.Empty)
                {
                    userIdTextBox.Enabled = false;
                }
                userNameTextBox.Text = dataGridRow.Cells[1].Value.ToString();
                fullNameTextBox.Text = dataGridRow.Cells[2].Value.ToString();
                passwordTextBox.Text = dataGridRow.Cells[3].Value.ToString();
                telephoneTextBox.Text = dataGridRow.Cells[4].Value.ToString();
                emailTextBox.Text = dataGridRow.Cells[5].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var query = "update UserTable set Uname='" + userNameTextBox.Text + "', Ufullname='" + fullNameTextBox.Text + "', Upassword='" + passwordTextBox.Text + "', Uemail='"+emailTextBox.Text+"' where Id='" + userIdTextBox.Text + "' ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
                connection.Close();
                userIdTextBox.Enabled = true;
                userIdTextBox.Text = string.Empty;
                userNameTextBox.Text = string.Empty;
                fullNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                telephoneTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            userIdTextBox.Enabled = true;
            userIdTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            telephoneTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            populateGrid();
        }
    }
}
