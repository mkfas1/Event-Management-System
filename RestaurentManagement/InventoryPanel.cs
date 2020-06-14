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
    public partial class InventoryPanel : UserControl
    {
        public static InventoryPanel inventoryPanel;
        public static InventoryPanel inventory
        {
            get
            {
                if (inventoryPanel == null)
                    inventoryPanel = new InventoryPanel();
                return inventoryPanel;
            }
        }
        public InventoryPanel()
        {
            InitializeComponent();
        }

        InventoryController inventoryController = new InventoryController();
        private void InventoryPanel_Load(object sender, EventArgs e)
        {
            rawTableGridView.DataSource = inventoryController.getAllInventory();
        }

        private void inventorySearchBox_Enter(object sender, EventArgs e)
        {
            if (inventorySearchBox.Text == "Search...")
            {
                inventorySearchBox.Text = "";
            }
        }

        private void inventorySearchBox_Leave(object sender, EventArgs e)
        {
            if (inventorySearchBox.Text == "")
            {
                inventorySearchBox.Text = "Search...";
                rawTableGridView.DataSource = inventoryController.getAllInventory();
            }
        }
        
        private void inventorySearchBox_TextChanged(object sender, EventArgs e)
        {
            rawTableGridView.DataSource = inventoryController.getInventory(inventorySearchBox.Text);
        }

        private void inventoryAddButton_Click_1(object sender, EventArgs e)
        {
            InventoryModal inventoryModal = new InventoryModal(1);
            inventoryModal.Visible = true;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            rawTableGridView.DataSource = inventoryController.getAllInventory();
        }


        private void rawTableGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InventoryModal inventoryModal = new InventoryModal(0);
            inventoryModal.nameTextBox.Text = this.rawTableGridView.CurrentRow.Cells[0].Value.ToString();
            inventoryModal.quantityTextBox.Text = this.rawTableGridView.CurrentRow.Cells[1].Value.ToString();
            inventoryModal.ShowDialog();
        }

        public string holdId;
        private void inventoryDeleteButton_Click(object sender, EventArgs e)
        {
            holdId = rawTableGridView.CurrentRow.Cells[0].Value.ToString();
           // MessageBox.Show(holdId.ToString());
            inventoryController.deleteRaw(holdId);
            ReloadButton_Click(sender, e);
        }

        private void rawTableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
