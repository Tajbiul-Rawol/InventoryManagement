
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
            this.viewOrdersBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.insertOrdersBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addToOrderButton = new MetroSet_UI.Controls.MetroSetButton();
            this.deleteToOrderButton = new MetroSet_UI.Controls.MetroSetButton();
            this.label10 = new System.Windows.Forms.Label();
            this.totAmountlbl = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 79);
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
            this.customerIDTextBox.Size = new System.Drawing.Size(201, 23);
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
            this.orderIDTextBox.Size = new System.Drawing.Size(201, 23);
            this.orderIDTextBox.TabIndex = 20;
            // 
            // orderDateTime
            // 
            this.orderDateTime.Location = new System.Drawing.Point(120, 137);
            this.orderDateTime.Name = "orderDateTime";
            this.orderDateTime.Size = new System.Drawing.Size(201, 23);
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
            this.productGridView.Size = new System.Drawing.Size(454, 195);
            this.productGridView.TabIndex = 27;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
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
            this.panel2.Controls.Add(this.viewOrdersBtn);
            this.panel2.Controls.Add(this.insertOrdersBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.orderIDTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.orderDateTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customerIDTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 222);
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
            this.customerNameTextBox.Size = new System.Drawing.Size(202, 23);
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
            this.refreshProductBtn.Location = new System.Drawing.Point(223, 173);
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
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.viewOrdersBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.viewOrdersBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.viewOrdersBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewOrdersBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.viewOrdersBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.viewOrdersBtn.HoverTextColor = System.Drawing.Color.White;
            this.viewOrdersBtn.IsDerivedStyle = true;
            this.viewOrdersBtn.Location = new System.Drawing.Point(119, 173);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.viewOrdersBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.viewOrdersBtn.NormalTextColor = System.Drawing.Color.White;
            this.viewOrdersBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.viewOrdersBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.viewOrdersBtn.PressTextColor = System.Drawing.Color.White;
            this.viewOrdersBtn.Size = new System.Drawing.Size(98, 21);
            this.viewOrdersBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.viewOrdersBtn.StyleManager = null;
            this.viewOrdersBtn.TabIndex = 12;
            this.viewOrdersBtn.Text = "View Orders";
            this.viewOrdersBtn.ThemeAuthor = "Narwin";
            this.viewOrdersBtn.ThemeName = "MetroLite";
            this.viewOrdersBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
            // 
            // insertOrdersBtn
            // 
            this.insertOrdersBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.insertOrdersBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.insertOrdersBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.insertOrdersBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertOrdersBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.insertOrdersBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.insertOrdersBtn.HoverTextColor = System.Drawing.Color.White;
            this.insertOrdersBtn.IsDerivedStyle = true;
            this.insertOrdersBtn.Location = new System.Drawing.Point(15, 173);
            this.insertOrdersBtn.Name = "insertOrdersBtn";
            this.insertOrdersBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.insertOrdersBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.insertOrdersBtn.NormalTextColor = System.Drawing.Color.White;
            this.insertOrdersBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.insertOrdersBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.insertOrdersBtn.PressTextColor = System.Drawing.Color.White;
            this.insertOrdersBtn.Size = new System.Drawing.Size(98, 21);
            this.insertOrdersBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.insertOrdersBtn.StyleManager = null;
            this.insertOrdersBtn.TabIndex = 11;
            this.insertOrdersBtn.Text = "Insert Order";
            this.insertOrdersBtn.ThemeAuthor = "Narwin";
            this.insertOrdersBtn.ThemeName = "MetroLite";
            this.insertOrdersBtn.Click += new System.EventHandler(this.insertOrdersBtn_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToOrderColumns = true;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.ProductID,
            this.Product,
            this.Quantity,
            this.UPrice,
            this.TotalAmount});
            this.ordersGridView.Location = new System.Drawing.Point(417, 352);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowTemplate.Height = 25;
            this.ordersGridView.Size = new System.Drawing.Size(454, 195);
            this.ordersGridView.TabIndex = 30;
            this.ordersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
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
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(476, 325);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(191, 23);
            this.quantityTextBox.TabIndex = 32;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.addToOrderButton.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToOrderButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addToOrderButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addToOrderButton.HoverTextColor = System.Drawing.Color.White;
            this.addToOrderButton.IsDerivedStyle = true;
            this.addToOrderButton.Location = new System.Drawing.Point(673, 325);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addToOrderButton.NormalTextColor = System.Drawing.Color.White;
            this.addToOrderButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addToOrderButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addToOrderButton.PressTextColor = System.Drawing.Color.White;
            this.addToOrderButton.Size = new System.Drawing.Size(98, 21);
            this.addToOrderButton.Style = MetroSet_UI.Enums.Style.Light;
            this.addToOrderButton.StyleManager = null;
            this.addToOrderButton.TabIndex = 33;
            this.addToOrderButton.Text = "Add Order";
            this.addToOrderButton.ThemeAuthor = "Narwin";
            this.addToOrderButton.ThemeName = "MetroLite";
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // deleteToOrderButton
            // 
            this.deleteToOrderButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteToOrderButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteToOrderButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.deleteToOrderButton.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteToOrderButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteToOrderButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteToOrderButton.HoverTextColor = System.Drawing.Color.White;
            this.deleteToOrderButton.IsDerivedStyle = true;
            this.deleteToOrderButton.Location = new System.Drawing.Point(773, 325);
            this.deleteToOrderButton.Name = "deleteToOrderButton";
            this.deleteToOrderButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteToOrderButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteToOrderButton.NormalTextColor = System.Drawing.Color.White;
            this.deleteToOrderButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteToOrderButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteToOrderButton.PressTextColor = System.Drawing.Color.White;
            this.deleteToOrderButton.Size = new System.Drawing.Size(98, 21);
            this.deleteToOrderButton.Style = MetroSet_UI.Enums.Style.Light;
            this.deleteToOrderButton.StyleManager = null;
            this.deleteToOrderButton.TabIndex = 34;
            this.deleteToOrderButton.Text = "Delete Order";
            this.deleteToOrderButton.ThemeAuthor = "Narwin";
            this.deleteToOrderButton.ThemeName = "MetroLite";
            this.deleteToOrderButton.Click += new System.EventHandler(this.deleteToOrderButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(505, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Amount";
            // 
            // totAmountlbl
            // 
            this.totAmountlbl.AutoSize = true;
            this.totAmountlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totAmountlbl.Location = new System.Drawing.Point(635, 550);
            this.totAmountlbl.Name = "totAmountlbl";
            this.totAmountlbl.Size = new System.Drawing.Size(48, 25);
            this.totAmountlbl.TabIndex = 36;
            this.totAmountlbl.Text = "BDT";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "Back";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 582);
            this.Controls.Add(this.totAmountlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deleteToOrderButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ordersGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
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
        private MetroSet_UI.Controls.MetroSetButton viewOrdersBtn;
        private MetroSet_UI.Controls.MetroSetButton insertOrdersBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityTextBox;
        private MetroSet_UI.Controls.MetroSetButton addToOrderButton;
        private MetroSet_UI.Controls.MetroSetButton deleteToOrderButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totAmountlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label11;
    }
}