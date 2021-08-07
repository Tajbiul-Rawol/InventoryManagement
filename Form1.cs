using MetroSet_UI.Forms;
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

    public partial class Form1 : MetroSetForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tajbiul\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void showPasswordCheckbox_CheckedChanged(object sender)
        {
            if (showPasswordCheckbox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Login fields cannot be empty");
                return;
            }
            
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Count(*) from UserTable where Uname='" + userNameTextBox.Text + "' and Upassword='" + passwordTextBox.Text + "' ", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Home dashboard = new Home();
                this.Hide();
                dashboard.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
            }
            connection.Close();
            
        }
    }
}
