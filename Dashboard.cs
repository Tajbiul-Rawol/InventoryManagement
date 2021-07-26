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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            InventoryPanelSubMenu.Visible = false;
            manageUsersPanelSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (manageUsersPanelSubMenu.Visible == true)
                manageUsersPanelSubMenu.Visible = false;
            if (InventoryPanelSubMenu.Visible == true)
                InventoryPanelSubMenu.Visible = false;
        }

        private void toggle_Button_Click(object sender, EventArgs e)
        {
            Button pan = (Button)sender;
            if (pan.Text == manageUsersBtn.Text)
                showSubMenu(manageUsersPanelSubMenu);
            if (pan.Text == inventoryBtn.Text)
                showSubMenu(InventoryPanelSubMenu);
   
        }
    }
}
