using RestaurentManagement.DBController;
using RestaurentManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentManagement
{
    public partial class InventoryModal : Form
    {

        int status;
        public InventoryModal(int n)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            status = n;
            if (status == 0)
            {
                DoneButton.Text = "Update";
            }
            if (status == 1)
            {
                DoneButton.Text = "Save";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(status == 1)
                {
                    Inventory inventory = new Inventory();
                    inventory.Name = nameTextBox.Text;
                    inventory.Quantity = Double.Parse(quantityTextBox.Text);
                    InventoryController inventoryController = new InventoryController();


                    if (inventory.Name.Length == 0)
                    {
                        MessageBox.Show("Please Insert Data");
                    }
                    else
                    {
                        if (inventoryController.insertInventory(inventory) == true)
                        {
                            MessageBox.Show("Saved");
                        }
                        else
                        {
                            MessageBox.Show("Not Saved");
                        }
                    }
                }
                else if(status == 0)
                {
                    Inventory inventory = new Inventory();
                    inventory.Name = nameTextBox.Text;
                    inventory.Quantity = Double.Parse(quantityTextBox.Text);
                    InventoryController inventoryController = new InventoryController();


                    if (inventory.Name.Length == 0)
                    {
                        MessageBox.Show("Please Insert Data");
                    }
                    else
                    {
                        if (inventoryController.updateRaw(inventory) == true)
                        {
                            MessageBox.Show("Saved");
                        }
                        else
                        {
                            MessageBox.Show("Not Saved");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOps Sorry Try Again !!");
            }
            
        }
    }
}
