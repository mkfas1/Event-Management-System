using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurentManagement.DBController;

namespace RestaurentManagement
{
    public partial class MenuPanel : UserControl
    {
        public static MenuPanel menuPanel;
        public static MenuPanel menu
        {
            get
            {
                if (menuPanel == null)
                    menuPanel = new MenuPanel();
                return menuPanel;
            }
        }

        public MenuPanel()
        {
            InitializeComponent();
        }

        MenuController menuController = new MenuController();
        private void MenuPanel_Load(object sender, EventArgs e)
        {
            menuTableGridView.DataSource = menuController.getAllMenu();
        }
        
        private void menuPanelSearchBox_Enter(object sender, EventArgs e)
        {
            if (menuPanelSearchBox.Text == "Search...")
            {
                menuPanelSearchBox.Text = "";
            }
        }
        
        private void menuPanelSearchBox_Leave(object sender, EventArgs e)
        {
            if (menuPanelSearchBox.Text == "")
            {
                menuPanelSearchBox.Text = "Search...";
                menuTableGridView.DataSource = menuController.getAllMenu();
            }
        }

        private void menuPanelSearchBox_TextChanged(object sender, EventArgs e)
        {
            menuTableGridView.DataSource = menuController.getMenu(menuPanelSearchBox.Text);
        }

        private void menuAddButton_Click_1(object sender, EventArgs e)
        {
            MenuModal menuModal = new MenuModal(1);
            menuModal.Visible = true;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            menuTableGridView.DataSource = menuController.getAllMenu();
        }

        private void menuTableGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MenuModal menuModal = new MenuModal(0);
            menuModal.Identifire = this.menuTableGridView.CurrentRow.Cells[0].Value.ToString();
            menuModal.nameTextBox.Text = this.menuTableGridView.CurrentRow.Cells[1].Value.ToString();
            menuModal.priceTextBox.Text = this.menuTableGridView.CurrentRow.Cells[2].Value.ToString();
            menuModal.ShowDialog();
        }
        public string holdId;

        private void menuDeleteButton_Click(object sender, EventArgs e)
        {
            holdId = menuTableGridView.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(holdId.ToString());
            menuController.deleteMenu(holdId);
            ReloadButton_Click(sender, e);
        }
    }
}
