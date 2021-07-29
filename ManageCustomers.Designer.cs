﻿
namespace InventoryManagement
{
    partial class ManageCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshCustomerBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.updateCustomerBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.deleteCustomerBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.addCustomerBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.label6 = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 79);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.refreshCustomerBtn);
            this.panel2.Controls.Add(this.updateCustomerBtn);
            this.panel2.Controls.Add(this.deleteCustomerBtn);
            this.panel2.Controls.Add(this.addCustomerBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.customerEmailTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customerPhoneTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.customerNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.customerIDTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 337);
            this.panel2.TabIndex = 2;
            // 
            // refreshCustomerBtn
            // 
            this.refreshCustomerBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCustomerBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCustomerBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.refreshCustomerBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshCustomerBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshCustomerBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshCustomerBtn.HoverTextColor = System.Drawing.Color.White;
            this.refreshCustomerBtn.IsDerivedStyle = true;
            this.refreshCustomerBtn.Location = new System.Drawing.Point(120, 302);
            this.refreshCustomerBtn.Name = "refreshCustomerBtn";
            this.refreshCustomerBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCustomerBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCustomerBtn.NormalTextColor = System.Drawing.Color.White;
            this.refreshCustomerBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshCustomerBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshCustomerBtn.PressTextColor = System.Drawing.Color.White;
            this.refreshCustomerBtn.Size = new System.Drawing.Size(98, 21);
            this.refreshCustomerBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.refreshCustomerBtn.StyleManager = null;
            this.refreshCustomerBtn.TabIndex = 13;
            this.refreshCustomerBtn.Text = "Refresh";
            this.refreshCustomerBtn.ThemeAuthor = "Narwin";
            this.refreshCustomerBtn.ThemeName = "MetroLite";
            this.refreshCustomerBtn.Click += new System.EventHandler(this.refreshCustomerBtn_Click);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCustomerBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCustomerBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.updateCustomerBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCustomerBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateCustomerBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateCustomerBtn.HoverTextColor = System.Drawing.Color.White;
            this.updateCustomerBtn.IsDerivedStyle = true;
            this.updateCustomerBtn.Location = new System.Drawing.Point(224, 263);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCustomerBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCustomerBtn.NormalTextColor = System.Drawing.Color.White;
            this.updateCustomerBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateCustomerBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateCustomerBtn.PressTextColor = System.Drawing.Color.White;
            this.updateCustomerBtn.Size = new System.Drawing.Size(98, 21);
            this.updateCustomerBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.updateCustomerBtn.StyleManager = null;
            this.updateCustomerBtn.TabIndex = 12;
            this.updateCustomerBtn.Text = "Update";
            this.updateCustomerBtn.ThemeAuthor = "Narwin";
            this.updateCustomerBtn.ThemeName = "MetroLite";
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCustomerBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCustomerBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.deleteCustomerBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCustomerBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteCustomerBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteCustomerBtn.HoverTextColor = System.Drawing.Color.White;
            this.deleteCustomerBtn.IsDerivedStyle = true;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(120, 263);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCustomerBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCustomerBtn.NormalTextColor = System.Drawing.Color.White;
            this.deleteCustomerBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteCustomerBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteCustomerBtn.PressTextColor = System.Drawing.Color.White;
            this.deleteCustomerBtn.Size = new System.Drawing.Size(98, 21);
            this.deleteCustomerBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.deleteCustomerBtn.StyleManager = null;
            this.deleteCustomerBtn.TabIndex = 11;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.ThemeAuthor = "Narwin";
            this.deleteCustomerBtn.ThemeName = "MetroLite";
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCustomerBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCustomerBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.addCustomerBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCustomerBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addCustomerBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addCustomerBtn.HoverTextColor = System.Drawing.Color.White;
            this.addCustomerBtn.IsDerivedStyle = true;
            this.addCustomerBtn.Location = new System.Drawing.Point(16, 263);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCustomerBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCustomerBtn.NormalTextColor = System.Drawing.Color.White;
            this.addCustomerBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addCustomerBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addCustomerBtn.PressTextColor = System.Drawing.Color.White;
            this.addCustomerBtn.Size = new System.Drawing.Size(98, 21);
            this.addCustomerBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.addCustomerBtn.StyleManager = null;
            this.addCustomerBtn.TabIndex = 10;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.ThemeAuthor = "Narwin";
            this.addCustomerBtn.ThemeName = "MetroLite";
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Email";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(106, 195);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(208, 23);
            this.customerEmailTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer Phone";
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(106, 138);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(208, 23);
            this.customerPhoneTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(104, 80);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(210, 23);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer ID";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(104, 24);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(210, 23);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToOrderColumns = true;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(386, 85);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.Size = new System.Drawing.Size(543, 336);
            this.customerGridView.TabIndex = 3;
            this.customerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellClick);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 479);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetButton refreshCustomerBtn;
        private MetroSet_UI.Controls.MetroSetButton updateCustomerBtn;
        private MetroSet_UI.Controls.MetroSetButton deleteCustomerBtn;
        private MetroSet_UI.Controls.MetroSetButton addCustomerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DataGridView customerGridView;
    }
}