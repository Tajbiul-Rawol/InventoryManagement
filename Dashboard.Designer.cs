
namespace InventoryManagement
{
    partial class Dashboard
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
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.InventoryPanelSubMenu = new System.Windows.Forms.Panel();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.manageUsersPanelSubMenu = new System.Windows.Forms.Panel();
            this.usersPermissionBtn = new System.Windows.Forms.Button();
            this.allUsersBtn = new System.Windows.Forms.Button();
            this.manageUsersBtn = new System.Windows.Forms.Button();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroSetPanel1.SuspendLayout();
            this.InventoryPanelSubMenu.SuspendLayout();
            this.manageUsersPanelSubMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.AutoScroll = true;
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.InventoryPanelSubMenu);
            this.metroSetPanel1.Controls.Add(this.inventoryBtn);
            this.metroSetPanel1.Controls.Add(this.manageUsersPanelSubMenu);
            this.metroSetPanel1.Controls.Add(this.manageUsersBtn);
            this.metroSetPanel1.Controls.Add(this.metroSetPanel2);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(156, 370);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // InventoryPanelSubMenu
            // 
            this.InventoryPanelSubMenu.Controls.Add(this.ordersBtn);
            this.InventoryPanelSubMenu.Controls.Add(this.customersBtn);
            this.InventoryPanelSubMenu.Controls.Add(this.productsBtn);
            this.InventoryPanelSubMenu.Controls.Add(this.categoriesBtn);
            this.InventoryPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryPanelSubMenu.Location = new System.Drawing.Point(0, 192);
            this.InventoryPanelSubMenu.Name = "InventoryPanelSubMenu";
            this.InventoryPanelSubMenu.Size = new System.Drawing.Size(156, 99);
            this.InventoryPanelSubMenu.TabIndex = 5;
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.DimGray;
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersBtn.FlatAppearance.BorderSize = 0;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.ForeColor = System.Drawing.Color.Black;
            this.ordersBtn.Location = new System.Drawing.Point(0, 72);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ordersBtn.Size = new System.Drawing.Size(156, 24);
            this.ordersBtn.TabIndex = 7;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ordersBtn.UseVisualStyleBackColor = false;
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.DimGray;
            this.customersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersBtn.FlatAppearance.BorderSize = 0;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBtn.ForeColor = System.Drawing.Color.Black;
            this.customersBtn.Location = new System.Drawing.Point(0, 48);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.customersBtn.Size = new System.Drawing.Size(156, 24);
            this.customersBtn.TabIndex = 6;
            this.customersBtn.Text = "Customers";
            this.customersBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.customersBtn.UseVisualStyleBackColor = false;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.DimGray;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.ForeColor = System.Drawing.Color.Black;
            this.productsBtn.Location = new System.Drawing.Point(0, 24);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.productsBtn.Size = new System.Drawing.Size(156, 24);
            this.productsBtn.TabIndex = 5;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.productsBtn.UseVisualStyleBackColor = false;
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.Color.DimGray;
            this.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.ForeColor = System.Drawing.Color.Black;
            this.categoriesBtn.Location = new System.Drawing.Point(0, 0);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.categoriesBtn.Size = new System.Drawing.Size(156, 24);
            this.categoriesBtn.TabIndex = 4;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.categoriesBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryBtn.ForeColor = System.Drawing.Color.Black;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 168);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.inventoryBtn.Size = new System.Drawing.Size(156, 24);
            this.inventoryBtn.TabIndex = 4;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.toggle_Button_Click);
            // 
            // manageUsersPanelSubMenu
            // 
            this.manageUsersPanelSubMenu.Controls.Add(this.usersPermissionBtn);
            this.manageUsersPanelSubMenu.Controls.Add(this.allUsersBtn);
            this.manageUsersPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageUsersPanelSubMenu.Location = new System.Drawing.Point(0, 115);
            this.manageUsersPanelSubMenu.Name = "manageUsersPanelSubMenu";
            this.manageUsersPanelSubMenu.Size = new System.Drawing.Size(156, 53);
            this.manageUsersPanelSubMenu.TabIndex = 1;
            // 
            // usersPermissionBtn
            // 
            this.usersPermissionBtn.BackColor = System.Drawing.Color.DimGray;
            this.usersPermissionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersPermissionBtn.FlatAppearance.BorderSize = 0;
            this.usersPermissionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersPermissionBtn.ForeColor = System.Drawing.Color.Black;
            this.usersPermissionBtn.Location = new System.Drawing.Point(0, 24);
            this.usersPermissionBtn.Name = "usersPermissionBtn";
            this.usersPermissionBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.usersPermissionBtn.Size = new System.Drawing.Size(156, 26);
            this.usersPermissionBtn.TabIndex = 5;
            this.usersPermissionBtn.Text = "User\'s Permission";
            this.usersPermissionBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.usersPermissionBtn.UseVisualStyleBackColor = false;
            // 
            // allUsersBtn
            // 
            this.allUsersBtn.BackColor = System.Drawing.Color.DimGray;
            this.allUsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allUsersBtn.FlatAppearance.BorderSize = 0;
            this.allUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.allUsersBtn.Location = new System.Drawing.Point(0, 0);
            this.allUsersBtn.Name = "allUsersBtn";
            this.allUsersBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.allUsersBtn.Size = new System.Drawing.Size(156, 24);
            this.allUsersBtn.TabIndex = 4;
            this.allUsersBtn.Text = "All Users";
            this.allUsersBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.allUsersBtn.UseVisualStyleBackColor = false;
            // 
            // manageUsersBtn
            // 
            this.manageUsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.manageUsersBtn.Location = new System.Drawing.Point(0, 91);
            this.manageUsersBtn.Name = "manageUsersBtn";
            this.manageUsersBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.manageUsersBtn.Size = new System.Drawing.Size(156, 24);
            this.manageUsersBtn.TabIndex = 3;
            this.manageUsersBtn.Text = "Manage Users";
            this.manageUsersBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.manageUsersBtn.UseVisualStyleBackColor = true;
            this.manageUsersBtn.Click += new System.EventHandler(this.toggle_Button_Click);
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(156, 91);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 0;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroLite";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(174, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.metroSetPanel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.metroSetPanel1.ResumeLayout(false);
            this.InventoryPanelSubMenu.ResumeLayout(false);
            this.manageUsersPanelSubMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private System.Windows.Forms.Panel InventoryPanelSubMenu;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Panel manageUsersPanelSubMenu;
        private System.Windows.Forms.Button usersPermissionBtn;
        private System.Windows.Forms.Button allUsersBtn;
        private System.Windows.Forms.Button manageUsersBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}