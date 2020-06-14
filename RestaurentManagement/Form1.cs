using RestaurentManagement.DBController;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Aqua,ButtonBorderStyle.None);
        }

        HomePage homePage = new HomePage();
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //homePage.Show();
            //this.Visible = false;
            if (userNameBox.Text.Length == 0 || passwordBox.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Username & Password...");
            }
            else
            {
                PersonController personController = new PersonController();
                int type = personController.loginPerson(userNameBox.Text, passwordBox.Text);

                if (type == 1)
                {
                    homePage.EmployeeButton.Visible = true;
                    homePage.Show();
                    this.Visible = false;
                }
                else if (type == 0)
                {
                    homePage.EmployeeButton.Visible = false;
                    homePage.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Not A Valid Person...");
                }
            }

        }

        private void ClearButton_click(object sender, EventArgs e)
        {
            userNameBox.Text = "";
            passwordBox.Clear();
            userNameBox.Focus();
        }
    }
}
