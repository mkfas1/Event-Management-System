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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            MaximizeBox = false;
            if (!HomePanel.Controls.Contains(HomepagePanel.homepage))
            {
                HomePanel.Controls.Add(HomepagePanel.homepage);
                HomepagePanel.homepage.Dock = DockStyle.Fill;
                HomepagePanel.homepage.BringToFront();
            }
            else
            {
                HomepagePanel.homepage.BringToFront();
            }
        }
        

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void BreakFastButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(BreakfastPanel.breakfast))
            {
                HomePanel.Controls.Add(BreakfastPanel.breakfast);
                BreakfastPanel.breakfast.Dock = DockStyle.Fill;
                BreakfastPanel.breakfast.BringToFront();
            }
            else
            {
                BreakfastPanel.breakfast.BringToFront();
            }
        }

        private void LunchButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(LunchPanel.lunch))
            {
                HomePanel.Controls.Add(LunchPanel.lunch);
                LunchPanel.lunch.Dock = DockStyle.Fill;
                LunchPanel.lunch.BringToFront();
            }
            else
            {
                LunchPanel.lunch.BringToFront();
            }
        }

        private void DinnerButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(DinnerPanel.dinner))
            {
                HomePanel.Controls.Add(DinnerPanel.dinner);
                DinnerPanel.dinner.Dock = DockStyle.Fill;
                DinnerPanel.dinner.BringToFront();
            }
            else
            {
                DinnerPanel.dinner.BringToFront();
            }
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(InventoryPanel.inventory))
            {
                HomePanel.Controls.Add(InventoryPanel.inventory);
                InventoryPanel.inventory.Dock = DockStyle.Fill;
                InventoryPanel.inventory.BringToFront();
            }
            else
            {
                InventoryPanel.inventory.BringToFront();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(HomepagePanel.homepage))
            {
                HomePanel.Controls.Add(HomepagePanel.homepage);
                HomepagePanel.homepage.Dock = DockStyle.Fill;
                HomepagePanel.homepage.BringToFront();
            }
            else
            {
                HomepagePanel.homepage.BringToFront();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(MenuPanel.menu))
            {
                HomePanel.Controls.Add(MenuPanel.menu);
                MenuPanel.menu.Dock = DockStyle.Fill;
                MenuPanel.menu.BringToFront();
            }
            else
            {
                MenuPanel.menu.BringToFront();
            }
        }

        private void OrderBackLog_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(OrderBackLogPanel.orderBackLog))
            {
                HomePanel.Controls.Add(OrderBackLogPanel.orderBackLog);
                OrderBackLogPanel.orderBackLog.Dock = DockStyle.Fill;
                OrderBackLogPanel.orderBackLog.BringToFront();
            }
            else
            {
                OrderBackLogPanel.orderBackLog.BringToFront();
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            if (!HomePanel.Controls.Contains(EmployeePanel.employee))
            {
                HomePanel.Controls.Add(EmployeePanel.employee);
                EmployeePanel.employee.Dock = DockStyle.Fill;
                EmployeePanel.employee.BringToFront();
            }
            else
            {
                EmployeePanel.employee.BringToFront();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (!HomePanel.Controls.Contains(MenuPanel.menu))
            {
                HomePanel.Controls.Add(MenuPanel.menu);
                MenuPanel.menu.Dock = DockStyle.Fill;
                MenuPanel.menu.BringToFront();
            }
            else
            {
                MenuPanel.menu.BringToFront();
            }
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
