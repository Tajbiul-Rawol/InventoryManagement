
namespace InventoryManagement
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewOrdersGridView = new System.Windows.Forms.DataGridView();
            this.searchOrderBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.searchOrderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Refresh = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "Back";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(335, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // viewOrdersGridView
            // 
            this.viewOrdersGridView.AllowUserToOrderColumns = true;
            this.viewOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrdersGridView.Location = new System.Drawing.Point(168, 126);
            this.viewOrdersGridView.Name = "viewOrdersGridView";
            this.viewOrdersGridView.RowTemplate.Height = 25;
            this.viewOrdersGridView.Size = new System.Drawing.Size(560, 365);
            this.viewOrdersGridView.TabIndex = 28;
            this.viewOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOrdersGridView_CellClick);
            // 
            // searchOrderBtn
            // 
            this.searchOrderBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchOrderBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchOrderBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.searchOrderBtn.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOrderBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchOrderBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.searchOrderBtn.HoverTextColor = System.Drawing.Color.White;
            this.searchOrderBtn.IsDerivedStyle = true;
            this.searchOrderBtn.Location = new System.Drawing.Point(506, 97);
            this.searchOrderBtn.Name = "searchOrderBtn";
            this.searchOrderBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchOrderBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.searchOrderBtn.NormalTextColor = System.Drawing.Color.White;
            this.searchOrderBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchOrderBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.searchOrderBtn.PressTextColor = System.Drawing.Color.White;
            this.searchOrderBtn.Size = new System.Drawing.Size(98, 21);
            this.searchOrderBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.searchOrderBtn.StyleManager = null;
            this.searchOrderBtn.TabIndex = 29;
            this.searchOrderBtn.Text = "Search";
            this.searchOrderBtn.ThemeAuthor = "Narwin";
            this.searchOrderBtn.ThemeName = "MetroLite";
            this.searchOrderBtn.Click += new System.EventHandler(this.searchOrderBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // searchOrderTextBox
            // 
            this.searchOrderTextBox.Location = new System.Drawing.Point(282, 97);
            this.searchOrderTextBox.Name = "searchOrderTextBox";
            this.searchOrderTextBox.Size = new System.Drawing.Size(206, 23);
            this.searchOrderTextBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Search Order";
            // 
            // Refresh
            // 
            this.Refresh.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Refresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Refresh.DisabledForeColor = System.Drawing.Color.Gray;
            this.Refresh.Font = new System.Drawing.Font("Segoe WP Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Refresh.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Refresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Refresh.HoverTextColor = System.Drawing.Color.White;
            this.Refresh.IsDerivedStyle = true;
            this.Refresh.Location = new System.Drawing.Point(610, 97);
            this.Refresh.Name = "Refresh";
            this.Refresh.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Refresh.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Refresh.NormalTextColor = System.Drawing.Color.White;
            this.Refresh.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Refresh.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Refresh.PressTextColor = System.Drawing.Color.White;
            this.Refresh.Size = new System.Drawing.Size(98, 21);
            this.Refresh.Style = MetroSet_UI.Enums.Style.Light;
            this.Refresh.StyleManager = null;
            this.Refresh.TabIndex = 32;
            this.Refresh.Text = "Refresh";
            this.Refresh.ThemeAuthor = "Narwin";
            this.Refresh.ThemeName = "MetroLite";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchOrderTextBox);
            this.Controls.Add(this.searchOrderBtn);
            this.Controls.Add(this.viewOrdersGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewOrdersGridView;
        private MetroSet_UI.Controls.MetroSetButton searchOrderBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchOrderTextBox;
        private System.Windows.Forms.Label label3;
        private MetroSet_UI.Controls.MetroSetButton Refresh;
    }
}