﻿using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : MetroSetForm
    {
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
    }
}