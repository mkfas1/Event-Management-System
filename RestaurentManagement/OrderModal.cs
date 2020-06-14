using RestaurentManagement.DBController;
using RestaurentManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentManagement
{
    public partial class OrderModal : Form
    {
        
        public OrderModal()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        
        }
        
        private void OrderModal_Load(object sender, EventArgs e)
        {
            AddInOrderGridView(values);
        }

        public List<OrderMenu> values { get; set; }
        int n;
        public void AddInOrderGridView(List<OrderMenu> orders)
        {
            if (orders != null)
            {
                foreach (OrderMenu items in orders)
                {
                    n = orderChartGridView.Rows.Add();
                    orderChartGridView.Rows[n].Cells[0].Value = items.Id;
                    orderChartGridView.Rows[n].Cells[1].Value = items.Name;
                    orderChartGridView.Rows[n].Cells[2].Value = items.Price;
                    orderChartGridView.Rows[n].Cells[3].Value = items.Rm1;
                    orderChartGridView.Rows[n].Cells[4].Value = items.Rm2;
                    orderChartGridView.Rows[n].Cells[5].Value = items.Rm3;
                    orderChartGridView.Rows[n].Cells[6].Value = items.Rm4;
                }
            }
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        InventoryController inventoryController = new InventoryController();

        int[] quantityArray = new int[100];
        string[][] nameArray = new string[100][];
        List<string> lstName = new List<string>();
        List<int> lstQuantity = new List<int>();
        int p = 0, counter = 0;
        double totalPrice = 0;


        private void ProceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow items in orderChartGridView.Rows)
                {
                    quantityArray[p] = Int32.Parse(items.Cells[7].Value.ToString());
                    p++;

                }
                for (int i = 0; i <= n; i++)
                {
                    nameArray[i] = new string[4]
                    {
                        orderChartGridView.Rows[i].Cells[3].Value.ToString(),
                        orderChartGridView.Rows[i].Cells[4].Value.ToString(),
                        orderChartGridView.Rows[i].Cells[5].Value.ToString(),
                        orderChartGridView.Rows[i].Cells[6].Value.ToString()
                    };
                }
                lstName = inventoryController.getRawOfName();
                lstQuantity = inventoryController.getRawOfQuantity();

                for (var i = 0; i <= n; i++)
                {
                    int exp = 0, a1 = 0, a2 = 0, a3 = 0, s = 0, t = 0, r = 0;
                    double x = 0, y = 0, z = 0;

                    for (var j = 0; j < lstName.Count; j++)
                    {
                        if (nameArray[i][0].ToString() != null)
                        {
                            if (nameArray[i][0] == lstName[j])
                            {
                                if (quantityArray[i] <= lstQuantity[j] && (lstQuantity[j] - quantityArray[i]) >= 0)
                                {
                                    lstQuantity[j] = lstQuantity[j] - quantityArray[i];
                                    Inventory inventory = new Inventory();
                                    inventory.Name = lstName[j].ToString();
                                    inventory.Quantity = Double.Parse(lstQuantity[j].ToString());
                                    inventoryController.updateRaw(inventory);
                                    exp++;
                                    a1 = 1;
                                }
                                else
                                {
                                    MessageBox.Show("Not enough " + nameArray[i][0].ToString() + "\nQuentity = " + lstQuantity[j] + "\nCode: " +
                                        orderChartGridView.Rows[i].Cells[0].Value.ToString());
                                    a1 = 2;
                                    exp = 0;
                                    break;
                                }
                            }
                        }
                    }

                    for (var j = 0; j < lstName.Count; j++)
                    {
                        if (nameArray[i][1].ToString() != null)
                        {
                            if (nameArray[i][1] == lstName[j])
                            {
                                if (quantityArray[i] <= lstQuantity[j] && (lstQuantity[j] - quantityArray[i]) >= 0)
                                {
                                    lstQuantity[j] = lstQuantity[j] - quantityArray[i];
                                    Inventory inventory = new Inventory();
                                    inventory.Name = lstName[j].ToString();
                                    inventory.Quantity = Double.Parse(lstQuantity[j].ToString());
                                    inventoryController.updateRaw(inventory);
                                    a2 = 1;
                                    if (exp != 0)
                                    {
                                        exp++;
                                    }
                                    else
                                    {
                                        exp = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Not enough " + nameArray[i][1].ToString() + "\nQuentity = " + lstQuantity[j] + "\nCode: " +
                                        orderChartGridView.Rows[i].Cells[0].Value.ToString());
                                    if (a1 == 1)
                                    {
                                        x = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 0;
                                        s = 1;
                                    }
                                    else if (a1 == 2)
                                    {
                                        x = Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 0;
                                        s = 1;
                                    }

                                    a2 = 2;
                                    exp = 0;
                                    break;
                                }
                            }
                        }
                    }


                    for (var j = 0; j < lstName.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(nameArray[i][2].ToString()))
                        {
                            if (nameArray[i][2] == lstName[j])
                            {
                                if (quantityArray[i] <= lstQuantity[j] && (lstQuantity[j] - quantityArray[i]) >= 0)
                                {
                                    lstQuantity[j] = lstQuantity[j] - quantityArray[i];
                                    Inventory inventory = new Inventory();
                                    inventory.Name = lstName[j].ToString();
                                    inventory.Quantity = Double.Parse(lstQuantity[j].ToString());
                                    inventoryController.updateRaw(inventory);
                                    a3 = 1;
                                    if (exp != 0)
                                    {
                                        exp++;
                                    }
                                    else
                                    {
                                        exp = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Not enough " + nameArray[i][2].ToString() + "\nQuentity = " + lstQuantity[j] + "\nCode: " +
                                        orderChartGridView.Rows[i].Cells[0].Value.ToString());
                                    if (a1 == 1 && s == 0)
                                    {
                                        x = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 0;
                                        s = 1;
                                    }
                                    else if (a1 == 2 && s == 0)
                                    {
                                        x = Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 1;
                                    }
                                    if (a2 == 1)
                                    {
                                        y = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][1].ToString()).ToString());
                                        Inventory inventory1 = new Inventory();
                                        inventory1.Name = nameArray[i][1].ToString();
                                        inventory1.Quantity = y;
                                        inventoryController.updateRaw(inventory1);
                                        a2 = 0;
                                        t = 1;
                                    }
                                    else if (a2 == 2)
                                    {
                                        y = Double.Parse(inventoryController.getQuentity(nameArray[i][1].ToString()).ToString());
                                        Inventory inventory1 = new Inventory();
                                        inventory1.Name = nameArray[i][1].ToString();
                                        inventory1.Quantity = y;
                                        inventoryController.updateRaw(inventory1);
                                        a2 = 0;
                                        t = 1;
                                    }
                                    a3 = 2;
                                    exp = 0;
                                    break;
                                }
                            }
                        }
                    }

                    for (var j = 0; j < lstName.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(nameArray[i][3].ToString()))
                        {
                            if (nameArray[i][3] == lstName[j])
                            {
                                if (quantityArray[i] <= lstQuantity[j] && (lstQuantity[j] - quantityArray[i]) >= 0)
                                {
                                    lstQuantity[j] = lstQuantity[j] - quantityArray[i];
                                    Inventory inventory = new Inventory();
                                    inventory.Name = lstName[j].ToString();
                                    inventory.Quantity = Double.Parse(lstQuantity[j].ToString());
                                    inventoryController.updateRaw(inventory);
                                    if (exp != 0)
                                    {
                                        exp++;
                                    }
                                    else
                                    {
                                        exp = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Not enough " + nameArray[i][3].ToString() + "\nQuentity = " + lstQuantity[j] + "\nCode: " +
                                        orderChartGridView.Rows[i].Cells[0].Value.ToString());
                                    if (a1 == 1 && s == 0)
                                    {
                                        x = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 0;
                                        s = 1;
                                    }
                                    else if (a1 == 2 && s == 0)
                                    {
                                        x = Double.Parse(inventoryController.getQuentity(nameArray[i][0].ToString()).ToString());
                                        Inventory inventory = new Inventory();
                                        inventory.Name = nameArray[i][0].ToString();
                                        inventory.Quantity = x;
                                        inventoryController.updateRaw(inventory);
                                        a1 = 0;
                                        s = 1;
                                    }
                                    if (a2 == 1 && t == 0)
                                    {
                                        y = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][1].ToString()).ToString());
                                        Inventory inventory1 = new Inventory();
                                        inventory1.Name = nameArray[i][1].ToString();
                                        inventory1.Quantity = y;
                                        inventoryController.updateRaw(inventory1);
                                        a2 = 0;
                                        t = 1;
                                    }
                                    else if (a2 == 2 && t == 0)
                                    {
                                        y = Double.Parse(inventoryController.getQuentity(nameArray[i][1].ToString()).ToString());
                                        Inventory inventory1 = new Inventory();
                                        inventory1.Name = nameArray[i][1].ToString();
                                        inventory1.Quantity = y;
                                        inventoryController.updateRaw(inventory1);
                                        a2 = 0;
                                        t = 1;
                                    }
                                    if (a3 == 1)
                                    {
                                        z = quantityArray[i] + Double.Parse(inventoryController.getQuentity(nameArray[i][2].ToString()).ToString());
                                        Inventory inventory2 = new Inventory();
                                        inventory2.Name = nameArray[i][2].ToString();
                                        inventory2.Quantity = z;
                                        inventoryController.updateRaw(inventory2);
                                        a3 = 0;
                                        r = 1;
                                    }
                                    if (a3 == 2)
                                    {
                                        z = Double.Parse(inventoryController.getQuentity(nameArray[i][2].ToString()).ToString());
                                        Inventory inventory2 = new Inventory();
                                        inventory2.Name = nameArray[i][2].ToString();
                                        inventory2.Quantity = z;
                                        inventoryController.updateRaw(inventory2);
                                        a3 = 0;
                                        r = 1;
                                    }

                                    exp = 0;
                                    break;
                                }
                            }
                        }
                    }


                    if (exp != 0)
                    {
                        totalPrice = totalPrice + (quantityArray[i] * Int32.Parse(orderChartGridView.Rows[i].Cells[2].Value.ToString()));

                    }

                }
                try
                {
                    ConfirmModal confirmModal = new ConfirmModal(totalPrice);
                    confirmModal.Show();
                    this.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sorry Something Went Wrong ....");
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Sorry Please Fill Quantity ....");
            }
            
            

            
        }

    }
}
