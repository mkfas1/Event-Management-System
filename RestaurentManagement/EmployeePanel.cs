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
using RestaurentManagement.Model;

namespace RestaurentManagement
{
    public partial class EmployeePanel : UserControl
    {
        public static EmployeePanel employeePanel;
        public static EmployeePanel employee
        {
            get
            {
                if (employeePanel == null)
                    employeePanel = new EmployeePanel();
                return employeePanel;
            }
        }
        public EmployeePanel()
        {
            InitializeComponent();
        }
        
        PersonController personController = new PersonController();
        public void EmployeePanel_Load(object sender, EventArgs e)
        {
            employeeTableGridView.DataSource = personController.getAllPerson();
        }

        private void employeeSearchBox_Enter(object sender, EventArgs e)
        {
            if(employeeSearchBox.Text == "Search...")
            {
                employeeSearchBox.Text = "";
            }
        }

        private void employeeSearchBox_Leave(object sender, EventArgs e)
        {
            if (employeeSearchBox.Text == "")
            {
                employeeSearchBox.Text = "Search...";
                employeeTableGridView.DataSource = personController.getAllPerson();
            }
        }

        public void employeeSearchBox_TextChanged(object sender, EventArgs e)
        {
            employeeTableGridView.DataSource = personController.getPerson(employeeSearchBox.Text);
        }
        
        private void employeeAddButton_Click(object sender, EventArgs e)
        {
            EmployeeModal employee = new EmployeeModal(1);
            employee.Visible = true;
        }

        public  void ReloadButton_Click(object sender, EventArgs e)
        {
            employeeTableGridView.DataSource = personController.getAllPerson();
        }
        
        private void employeeTableGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeModal employeeModal = new EmployeeModal(0);
            employeeModal.Identifire = this.employeeTableGridView.CurrentRow.Cells[0].Value.ToString();
            employeeModal.nameTextBox.Text = this.employeeTableGridView.CurrentRow.Cells[1].Value.ToString();
            employeeModal.addressTextBox.Text = this.employeeTableGridView.CurrentRow.Cells[2].Value.ToString();
            employeeModal.passwordTextBox.Text = this.employeeTableGridView.CurrentRow.Cells[3].Value.ToString();
            employeeModal.statusTextBox.Text = this.employeeTableGridView.CurrentRow.Cells[4].Value.ToString();
            employeeModal.ShowDialog();
        }

        public string holdId;
        private void employeeDeleteButton_Click_1(object sender, EventArgs e)
        {
            holdId = employeeTableGridView.CurrentRow.Cells[0].Value.ToString();
            personController.deletePerson(holdId);
            ReloadButton_Click(sender, e);
        }


        

    }
}
