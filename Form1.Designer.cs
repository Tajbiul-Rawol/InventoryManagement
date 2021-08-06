
namespace InventoryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.userNameLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.passwordLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.userNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.passwordTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.showPasswordCheckbox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.clearLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.loginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.loginBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.loginBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.loginBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.loginBtn.HoverTextColor = System.Drawing.Color.White;
            this.loginBtn.IsDerivedStyle = true;
            this.loginBtn.Location = new System.Drawing.Point(161, 264);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.loginBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.loginBtn.NormalTextColor = System.Drawing.Color.White;
            this.loginBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.loginBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.loginBtn.PressTextColor = System.Drawing.Color.White;
            this.loginBtn.Size = new System.Drawing.Size(176, 41);
            this.loginBtn.Style = MetroSet_UI.Enums.Style.Light;
            this.loginBtn.StyleManager = null;
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.ThemeAuthor = "Narwin";
            this.loginBtn.ThemeName = "MetroLite";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.IsDerivedStyle = true;
            this.userNameLabel.Location = new System.Drawing.Point(71, 116);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(82, 25);
            this.userNameLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.userNameLabel.StyleManager = null;
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.ThemeAuthor = "Narwin";
            this.userNameLabel.ThemeName = "MetroLite";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.IsDerivedStyle = true;
            this.passwordLabel.Location = new System.Drawing.Point(71, 187);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 25);
            this.passwordLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.passwordLabel.StyleManager = null;
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.ThemeAuthor = "Narwin";
            this.passwordLabel.ThemeName = "MetroLite";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.AutoCompleteCustomSource = null;
            this.userNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.userNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.userNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe WP", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.userNameTextBox.Image = null;
            this.userNameTextBox.IsDerivedStyle = true;
            this.userNameTextBox.Lines = null;
            this.userNameTextBox.Location = new System.Drawing.Point(170, 111);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Multiline = false;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.Size = new System.Drawing.Size(232, 30);
            this.userNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.userNameTextBox.StyleManager = null;
            this.userNameTextBox.TabIndex = 8;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userNameTextBox.ThemeAuthor = "Narwin";
            this.userNameTextBox.ThemeName = "MetroLite";
            this.userNameTextBox.UseSystemPasswordChar = false;
            this.userNameTextBox.WatermarkText = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoCompleteCustomSource = null;
            this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe WP", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.passwordTextBox.Image = null;
            this.passwordTextBox.IsDerivedStyle = true;
            this.passwordTextBox.Lines = null;
            this.passwordTextBox.Location = new System.Drawing.Point(170, 187);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(232, 30);
            this.passwordTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.passwordTextBox.StyleManager = null;
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordTextBox.ThemeAuthor = "Narwin";
            this.passwordTextBox.ThemeName = "MetroLite";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.WatermarkText = "";
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheckbox.BackgroundColor = System.Drawing.Color.White;
            this.showPasswordCheckbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.showPasswordCheckbox.Checked = false;
            this.showPasswordCheckbox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.showPasswordCheckbox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.showPasswordCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckbox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPasswordCheckbox.IsDerivedStyle = true;
            this.showPasswordCheckbox.Location = new System.Drawing.Point(270, 328);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.showPasswordCheckbox.Size = new System.Drawing.Size(150, 16);
            this.showPasswordCheckbox.Style = MetroSet_UI.Enums.Style.Light;
            this.showPasswordCheckbox.StyleManager = null;
            this.showPasswordCheckbox.TabIndex = 10;
            this.showPasswordCheckbox.Text = "Show Password";
            this.showPasswordCheckbox.ThemeAuthor = "Narwin";
            this.showPasswordCheckbox.ThemeName = "MetroLite";
            this.showPasswordCheckbox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // clearLabel
            // 
            this.clearLabel.Font = new System.Drawing.Font("Segoe WP", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.IsDerivedStyle = true;
            this.clearLabel.Location = new System.Drawing.Point(138, 328);
            this.clearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(62, 25);
            this.clearLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.clearLabel.StyleManager = null;
            this.clearLabel.TabIndex = 11;
            this.clearLabel.Text = "Clear";
            this.clearLabel.ThemeAuthor = "Narwin";
            this.clearLabel.ThemeName = "MetroLite";
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 434);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginBtn);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(16, 76, 16, 13);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.TextAlign = MetroSet_UI.Enums.TextAlign.Center;
            this.TextColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton loginBtn;
        private MetroSet_UI.Controls.MetroSetLabel userNameLabel;
        private MetroSet_UI.Controls.MetroSetLabel passwordLabel;
        private MetroSet_UI.Controls.MetroSetTextBox userNameTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox passwordTextBox;
        private MetroSet_UI.Controls.MetroSetCheckBox showPasswordCheckbox;
        private MetroSet_UI.Controls.MetroSetLabel clearLabel;
    }
}

