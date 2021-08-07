
namespace InventoryManagement
{
    partial class ManageCategories
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshCategoryBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.updateCategoryBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.deleteCategoryBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.addCategoryBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.searchCategoryBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.searchCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 79);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Back";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Categories";
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
            this.panel2.Controls.Add(this.refreshCategoryBtn);
            this.panel2.Controls.Add(this.updateCategoryBtn);
            this.panel2.Controls.Add(this.deleteCategoryBtn);
            this.panel2.Controls.Add(this.addCategoryBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.categoryNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.categoryIDTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 216);
            this.panel2.TabIndex = 3;
            // 
            // refreshCategoryBtn
            // 
            this.refreshCategoryBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCategoryBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCategoryBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.refreshCategoryBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshCategoryBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshCategoryBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.refreshCategoryBtn.HoverTextColor = System.Drawing.Color.White;
            this.refreshCategoryBtn.IsDerivedStyle = true;
            this.refreshCategoryBtn.Location = new System.Drawing.Point(120, 160);
            this.refreshCategoryBtn.Name = "refreshCategoryBtn";
            this.refreshCategoryBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCategoryBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.refreshCategoryBtn.NormalTextColor = System.Drawing.Color.White;
            this.refreshCategoryBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshCategoryBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.refreshCategoryBtn.PressTextColor = System.Drawing.Color.White;
            this.refreshCategoryBtn.Size = new System.Drawing.Size(98, 21);
            this.refreshCategoryBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.refreshCategoryBtn.StyleManager = null;
            this.refreshCategoryBtn.TabIndex = 13;
            this.refreshCategoryBtn.Text = "Refresh";
            this.refreshCategoryBtn.ThemeAuthor = "Narwin";
            this.refreshCategoryBtn.ThemeName = "MetroLite";
            this.refreshCategoryBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCategoryBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCategoryBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.updateCategoryBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCategoryBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateCategoryBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.updateCategoryBtn.HoverTextColor = System.Drawing.Color.White;
            this.updateCategoryBtn.IsDerivedStyle = true;
            this.updateCategoryBtn.Location = new System.Drawing.Point(224, 133);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCategoryBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.updateCategoryBtn.NormalTextColor = System.Drawing.Color.White;
            this.updateCategoryBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateCategoryBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.updateCategoryBtn.PressTextColor = System.Drawing.Color.White;
            this.updateCategoryBtn.Size = new System.Drawing.Size(98, 21);
            this.updateCategoryBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.updateCategoryBtn.StyleManager = null;
            this.updateCategoryBtn.TabIndex = 12;
            this.updateCategoryBtn.Text = "Update";
            this.updateCategoryBtn.ThemeAuthor = "Narwin";
            this.updateCategoryBtn.ThemeName = "MetroLite";
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCategoryBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCategoryBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteCategoryBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deleteCategoryBtn.HoverTextColor = System.Drawing.Color.White;
            this.deleteCategoryBtn.IsDerivedStyle = true;
            this.deleteCategoryBtn.Location = new System.Drawing.Point(120, 133);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCategoryBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deleteCategoryBtn.NormalTextColor = System.Drawing.Color.White;
            this.deleteCategoryBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteCategoryBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deleteCategoryBtn.PressTextColor = System.Drawing.Color.White;
            this.deleteCategoryBtn.Size = new System.Drawing.Size(98, 21);
            this.deleteCategoryBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.deleteCategoryBtn.StyleManager = null;
            this.deleteCategoryBtn.TabIndex = 11;
            this.deleteCategoryBtn.Text = "Delete";
            this.deleteCategoryBtn.ThemeAuthor = "Narwin";
            this.deleteCategoryBtn.ThemeName = "MetroLite";
            this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCategoryBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCategoryBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.addCategoryBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addCategoryBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addCategoryBtn.HoverTextColor = System.Drawing.Color.White;
            this.addCategoryBtn.IsDerivedStyle = true;
            this.addCategoryBtn.Location = new System.Drawing.Point(15, 133);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCategoryBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addCategoryBtn.NormalTextColor = System.Drawing.Color.White;
            this.addCategoryBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addCategoryBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addCategoryBtn.PressTextColor = System.Drawing.Color.White;
            this.addCategoryBtn.Size = new System.Drawing.Size(98, 21);
            this.addCategoryBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.addCategoryBtn.StyleManager = null;
            this.addCategoryBtn.TabIndex = 10;
            this.addCategoryBtn.Text = "Add";
            this.addCategoryBtn.ThemeAuthor = "Narwin";
            this.addCategoryBtn.ThemeName = "MetroLite";
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(104, 80);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(210, 23);
            this.categoryNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category ID";
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.Location = new System.Drawing.Point(104, 24);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(210, 23);
            this.categoryIDTextBox.TabIndex = 2;
            // 
            // searchCategoryBtn
            // 
            this.searchCategoryBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchCategoryBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchCategoryBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.searchCategoryBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCategoryBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchCategoryBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchCategoryBtn.HoverTextColor = System.Drawing.Color.White;
            this.searchCategoryBtn.IsDerivedStyle = true;
            this.searchCategoryBtn.Location = new System.Drawing.Point(775, 90);
            this.searchCategoryBtn.Name = "searchCategoryBtn";
            this.searchCategoryBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchCategoryBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchCategoryBtn.NormalTextColor = System.Drawing.Color.White;
            this.searchCategoryBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchCategoryBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchCategoryBtn.PressTextColor = System.Drawing.Color.White;
            this.searchCategoryBtn.Size = new System.Drawing.Size(98, 21);
            this.searchCategoryBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.searchCategoryBtn.StyleManager = null;
            this.searchCategoryBtn.TabIndex = 13;
            this.searchCategoryBtn.Text = "Search";
            this.searchCategoryBtn.ThemeAuthor = "Narwin";
            this.searchCategoryBtn.ThemeName = "MetroLite";
            this.searchCategoryBtn.Click += new System.EventHandler(this.searchCategoryBtn_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToOrderColumns = true;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(371, 119);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowTemplate.Height = 25;
            this.categoryGridView.Size = new System.Drawing.Size(543, 303);
            this.categoryGridView.TabIndex = 4;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catgegoryGridView_CellClick);
            // 
            // searchCategoryTextBox
            // 
            this.searchCategoryTextBox.Location = new System.Drawing.Point(540, 90);
            this.searchCategoryTextBox.Name = "searchCategoryTextBox";
            this.searchCategoryTextBox.Size = new System.Drawing.Size(210, 23);
            this.searchCategoryTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search Category";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 479);
            this.Controls.Add(this.searchCategoryBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchCategoryTextBox);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetButton searchCategoryBtn;
        private MetroSet_UI.Controls.MetroSetButton updateCategoryBtn;
        private MetroSet_UI.Controls.MetroSetButton deleteCategoryBtn;
        private MetroSet_UI.Controls.MetroSetButton addCategoryBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.TextBox searchCategoryTextBox;
        private System.Windows.Forms.Label label5;
        private MetroSet_UI.Controls.MetroSetButton refreshCategoryBtn;
        private System.Windows.Forms.Label label6;
    }
}