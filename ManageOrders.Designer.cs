﻿
namespace InventoryManagement
{
    partial class ManageOrders
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
            this.label3 = new System.Windows.Forms.Label();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.refreshProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.updateProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.deleteProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.addProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addToOrderTextBox = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(871, 79);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(352, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customers List";
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToOrderColumns = true;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(12, 115);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.Size = new System.Drawing.Size(380, 195);
            this.customerGridView.TabIndex = 19;
            this.customerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer ID";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(120, 57);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(191, 23);
            this.customerIDTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Order ID";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(120, 17);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(191, 23);
            this.orderIDTextBox.TabIndex = 20;
            // 
            // orderDateTime
            // 
            this.orderDateTime.Location = new System.Drawing.Point(119, 137);
            this.orderDateTime.Name = "orderDateTime";
            this.orderDateTime.Size = new System.Drawing.Size(191, 23);
            this.orderDateTime.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Order Date";
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToOrderColumns = true;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(417, 115);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 25;
            this.productGridView.Size = new System.Drawing.Size(436, 195);
            this.productGridView.TabIndex = 27;
            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Location = new System.Drawing.Point(578, 85);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(208, 23);
            this.searchCategoryComboBox.TabIndex = 26;
            this.searchCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCategoryComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Select Category";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.customerNameTextBox);
            this.panel2.Controls.Add(this.refreshProductBtn);
            this.panel2.Controls.Add(this.updateProductBtn);
            this.panel2.Controls.Add(this.deleteProductBtn);
            this.panel2.Controls.Add(this.addProductBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.orderIDTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.orderDateTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customerIDTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 241);
            this.panel2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(119, 102);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(191, 23);
            this.customerNameTextBox.TabIndex = 26;
            // 
            // refreshProductBtn
            // 
            this.refreshProductBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshProductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshProductBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.refreshProductBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshProductBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshProductBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshProductBtn.HoverTextColor = System.Drawing.Color.White;
            this.refreshProductBtn.IsDerivedStyle = true;
            this.refreshProductBtn.Location = new System.Drawing.Point(120, 206);
            this.refreshProductBtn.Name = "refreshProductBtn";
            this.refreshProductBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshProductBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshProductBtn.NormalTextColor = System.Drawing.Color.White;
            this.refreshProductBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshProductBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshProductBtn.PressTextColor = System.Drawing.Color.White;
            this.refreshProductBtn.Size = new System.Drawing.Size(98, 21);
            this.refreshProductBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.refreshProductBtn.StyleManager = null;
            this.refreshProductBtn.TabIndex = 13;
            this.refreshProductBtn.Text = "Refresh";
            this.refreshProductBtn.ThemeAuthor = "Narwin";
            this.refreshProductBtn.ThemeName = "MetroLite";
            this.refreshProductBtn.Click += new System.EventHandler(this.refreshProductBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateProductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateProductBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.updateProductBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateProductBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateProductBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateProductBtn.HoverTextColor = System.Drawing.Color.White;
            this.updateProductBtn.IsDerivedStyle = true;
            this.updateProductBtn.Location = new System.Drawing.Point(223, 173);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateProductBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateProductBtn.NormalTextColor = System.Drawing.Color.White;
            this.updateProductBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateProductBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateProductBtn.PressTextColor = System.Drawing.Color.White;
            this.updateProductBtn.Size = new System.Drawing.Size(98, 21);
            this.updateProductBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.updateProductBtn.StyleManager = null;
            this.updateProductBtn.TabIndex = 12;
            this.updateProductBtn.Text = "Update";
            this.updateProductBtn.ThemeAuthor = "Narwin";
            this.updateProductBtn.ThemeName = "MetroLite";
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteProductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteProductBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.deleteProductBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteProductBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteProductBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteProductBtn.HoverTextColor = System.Drawing.Color.White;
            this.deleteProductBtn.IsDerivedStyle = true;
            this.deleteProductBtn.Location = new System.Drawing.Point(119, 173);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteProductBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteProductBtn.NormalTextColor = System.Drawing.Color.White;
            this.deleteProductBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteProductBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteProductBtn.PressTextColor = System.Drawing.Color.White;
            this.deleteProductBtn.Size = new System.Drawing.Size(98, 21);
            this.deleteProductBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.deleteProductBtn.StyleManager = null;
            this.deleteProductBtn.TabIndex = 11;
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.ThemeAuthor = "Narwin";
            this.deleteProductBtn.ThemeName = "MetroLite";
            // 
            // addProductBtn
            // 
            this.addProductBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addProductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addProductBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addProductBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addProductBtn.HoverTextColor = System.Drawing.Color.White;
            this.addProductBtn.IsDerivedStyle = true;
            this.addProductBtn.Location = new System.Drawing.Point(15, 173);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addProductBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addProductBtn.NormalTextColor = System.Drawing.Color.White;
            this.addProductBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addProductBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addProductBtn.PressTextColor = System.Drawing.Color.White;
            this.addProductBtn.Size = new System.Drawing.Size(98, 21);
            this.addProductBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.addProductBtn.StyleManager = null;
            this.addProductBtn.TabIndex = 10;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.ThemeAuthor = "Narwin";
            this.addProductBtn.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Product,
            this.Quantity,
            this.UPrice,
            this.TotPrice});
            this.dataGridView1.Location = new System.Drawing.Point(417, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(436, 195);
            this.dataGridView1.TabIndex = 30;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UPrice
            // 
            this.UPrice.HeaderText = "UPrice";
            this.UPrice.Name = "UPrice";
            // 
            // TotPrice
            // 
            this.TotPrice.HeaderText = "TotalPrice";
            this.TotPrice.Name = "TotPrice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(521, 325);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(191, 23);
            this.quantityTextBox.TabIndex = 32;
            // 
            // addToOrderTextBox
            // 
            this.addToOrderTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderTextBox.DisabledForeColor = System.Drawing.Color.Gray;
            this.addToOrderTextBox.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToOrderTextBox.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addToOrderTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addToOrderTextBox.HoverTextColor = System.Drawing.Color.White;
            this.addToOrderTextBox.IsDerivedStyle = true;
            this.addToOrderTextBox.Location = new System.Drawing.Point(732, 325);
            this.addToOrderTextBox.Name = "addToOrderTextBox";
            this.addToOrderTextBox.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderTextBox.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderTextBox.NormalTextColor = System.Drawing.Color.White;
            this.addToOrderTextBox.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addToOrderTextBox.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addToOrderTextBox.PressTextColor = System.Drawing.Color.White;
            this.addToOrderTextBox.Size = new System.Drawing.Size(98, 21);
            this.addToOrderTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.addToOrderTextBox.StyleManager = null;
            this.addToOrderTextBox.TabIndex = 33;
            this.addToOrderTextBox.Text = "Refresh";
            this.addToOrderTextBox.ThemeAuthor = "Narwin";
            this.addToOrderTextBox.ThemeName = "MetroLite";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 578);
            this.Controls.Add(this.addToOrderTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.searchCategoryComboBox);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.ComboBox searchCategoryComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetButton refreshProductBtn;
        private MetroSet_UI.Controls.MetroSetButton updateProductBtn;
        private MetroSet_UI.Controls.MetroSetButton deleteProductBtn;
        private MetroSet_UI.Controls.MetroSetButton addProductBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityTextBox;
        private MetroSet_UI.Controls.MetroSetButton addToOrderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotPrice;
    }
}