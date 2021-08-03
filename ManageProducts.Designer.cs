
namespace InventoryManagement
{
    partial class ManageProducts
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
            this.label9 = new System.Windows.Forms.Label();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.refreshProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.updateProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.deleteProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.addProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.label6 = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchProductBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Products";
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
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.productCategoryComboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.refreshProductBtn);
            this.panel2.Controls.Add(this.updateProductBtn);
            this.panel2.Controls.Add(this.deleteProductBtn);
            this.panel2.Controls.Add(this.addProductBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.productPriceTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.productQuantityTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.productNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.productIDTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 337);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Product Category";
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(104, 228);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(208, 23);
            this.productCategoryComboBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 185);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(208, 23);
            this.descriptionTextBox.TabIndex = 14;
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
            this.refreshProductBtn.Location = new System.Drawing.Point(120, 302);
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
            this.updateProductBtn.Location = new System.Drawing.Point(224, 263);
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
            this.deleteProductBtn.Location = new System.Drawing.Point(120, 263);
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
            this.addProductBtn.Location = new System.Drawing.Point(16, 263);
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
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Product Price";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(104, 144);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(208, 23);
            this.productPriceTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Quantity";
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(104, 104);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(208, 23);
            this.productQuantityTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(104, 64);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(210, 23);
            this.productNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product ID";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(104, 24);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(210, 23);
            this.productIDTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search Product";
            // 
            // searchProductBtn
            // 
            this.searchProductBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchProductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchProductBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.searchProductBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchProductBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchProductBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchProductBtn.HoverTextColor = System.Drawing.Color.White;
            this.searchProductBtn.IsDerivedStyle = true;
            this.searchProductBtn.Location = new System.Drawing.Point(758, 102);
            this.searchProductBtn.Name = "searchProductBtn";
            this.searchProductBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchProductBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchProductBtn.NormalTextColor = System.Drawing.Color.White;
            this.searchProductBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchProductBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchProductBtn.PressTextColor = System.Drawing.Color.White;
            this.searchProductBtn.Size = new System.Drawing.Size(98, 21);
            this.searchProductBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.searchProductBtn.StyleManager = null;
            this.searchProductBtn.TabIndex = 16;
            this.searchProductBtn.Text = "Search";
            this.searchProductBtn.ThemeAuthor = "Narwin";
            this.searchProductBtn.ThemeName = "MetroLite";
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Location = new System.Drawing.Point(514, 102);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(210, 23);
            this.searchProductTextBox.TabIndex = 15;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToOrderColumns = true;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(362, 131);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 25;
            this.productGridView.Size = new System.Drawing.Size(543, 295);
            this.productGridView.TabIndex = 18;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 479);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchProductBtn);
            this.Controls.Add(this.searchProductTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetButton refreshProductBtn;
        private MetroSet_UI.Controls.MetroSetButton updateProductBtn;
        private MetroSet_UI.Controls.MetroSetButton deleteProductBtn;
        private MetroSet_UI.Controls.MetroSetButton addProductBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Label label7;
        private MetroSet_UI.Controls.MetroSetButton searchProductBtn;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.Label label8;
    }
}