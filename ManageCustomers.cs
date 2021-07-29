﻿using System;
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
            var query = "insert into CustomerTable values('" + customerIDTextBox.Text + "','" + customerNameTextBox.Text + "','" + customerPhoneTextBox.Text + "','" + customerEmailTextBox.Text + "')";
            
            try
            {
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
            var query = "update CustomerTable set CustName='" + customerNameTextBox.Text + "', CustPhone='" + customerPhoneTextBox.Text + "', CustEmail='" + customerEmailTextBox.Text + "' where CustId='" + customerIDTextBox.Text + "' ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully");
                connection.Close();
                populateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
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
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                var query = "delete from CustomerTable where CustId='" + customerIDTextBox.Text + "' ";
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

        private void refreshCustomerBtn_Click(object sender, EventArgs e)
        {
            customerIDTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            customerPhoneTextBox.Text = string.Empty;
            customerEmailTextBox.Text = string.Empty;
        }
    }
}