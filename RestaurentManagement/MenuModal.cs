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
    public partial class MenuModal : Form
    {
        int status;
        public string Identifire;
        public MenuModal(int n)
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

        OrderMenu orderMenu = new OrderMenu();
        MenuPanel menuPanel = new MenuPanel();
        private void MenuModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurentDataSet3.Raw' table. You can move, or remove it, as needed.
            this.rawTableAdapter3.Fill(this.restaurentDataSet3.Raw);
            // TODO: This line of code loads data into the 'restaurentDataSet2.Raw' table. You can move, or remove it, as needed.
            this.rawTableAdapter2.Fill(this.restaurentDataSet2.Raw);
            // TODO: This line of code loads data into the 'restaurentDataSet1.Raw' table. You can move, or remove it, as needed.
            this.rawTableAdapter1.Fill(this.restaurentDataSet1.Raw);
            // TODO: This line of code loads data into the 'restaurentDataSet.Raw' table. You can move, or remove it, as needed.
            this.rawTableAdapter.Fill(this.restaurentDataSet.Raw);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DoneButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(status == 1)
                {
                    orderMenu.Name = nameTextBox.Text;
                    orderMenu.Price = Double.Parse(priceTextBox.Text);
                    orderMenu.Rm1 = menuModalComboBoxRaw1.Text;
                    orderMenu.Rm2 = menuModalComboBoxRaw2.Text;
                    orderMenu.Rm3 = menuModalComboBoxRaw3.Text;
                    orderMenu.Rm4 = menuModalComboBoxRaw4.Text;
                    orderMenu.Status = int.Parse(timeSelectComboBox.Text);
                    MenuController menuController = new MenuController();


                    if (orderMenu.Name.Length == 0)
                    {
                        MessageBox.Show("Please insert data");
                    }
                    else
                    {

                        if (menuController.insertMenu(orderMenu) == true)
                        {
                        }
                        else if (menuController.insertMenu(orderMenu) == false)
                        {
                            MessageBox.Show("Not Saved");
                        }
                    }
                }
                else if(status == 0)
                {
                    orderMenu.Id = Int32.Parse(Identifire);
                    orderMenu.Name = nameTextBox.Text;
                    orderMenu.Price = Double.Parse(priceTextBox.Text);
                    orderMenu.Rm1 = menuModalComboBoxRaw1.Text;
                    orderMenu.Rm2 = menuModalComboBoxRaw2.Text;
                    orderMenu.Rm3 = menuModalComboBoxRaw3.Text;
                    orderMenu.Rm4 = menuModalComboBoxRaw4.Text;
                    orderMenu.Status = int.Parse(timeSelectComboBox.Text);
                    MenuController menuController = new MenuController();


                    if (orderMenu.Name.Length == 0)
                    {
                        MessageBox.Show("Please insert data");
                    }
                    else
                    {

                        if (menuController.UpdatetMenu(orderMenu) == true)
                        {
                        }
                        else if (menuController.insertMenu(orderMenu) == false)
                        {
                            MessageBox.Show("Not Saved");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOps Sorry Try Again!!");
            }
        }
        
    }
}
