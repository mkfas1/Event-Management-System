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
    public partial class EmployeeModal : Form
    {
        int status;
        public string Identifire;
        public EmployeeModal(int n)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            status = n;
            if(status == 0)
            {
                DoneButton.Text = "Update";
            }
            if(status == 1)
            {
                DoneButton.Text = "Save";
            }
        }

        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public  void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == 1)
                {
                    Person person = new Person();
                    person.Name = nameTextBox.Text;
                    person.Address = addressTextBox.Text;
                    person.Password = passwordTextBox.Text;
                    person.Status = int.Parse(statusTextBox.Text);

                    PersonController personController = new PersonController();
                    if (person.Name.Length == 0 || person.Address.Length == 0 || person.Password.Length == 0)
                    {
                        MessageBox.Show("Please Insert Data");
                    }
                    else
                    {
                        if (personController.insertPerson(person) == true)
                        {
                            MessageBox.Show("Saved");

                        }
                        else
                        {
                            MessageBox.Show("not saved");
                        }
                    }
                }
                else if(status == 0)
                {
                    Person person = new Person();
                    person.Id = Int32.Parse( Identifire);
                    person.Name = nameTextBox.Text;
                    person.Address = addressTextBox.Text;
                    person.Password = passwordTextBox.Text;
                    person.Status = int.Parse(statusTextBox.Text);

                    PersonController personController = new PersonController();
                    if (person.Name.Length == 0 || person.Address.Length == 0 || person.Password.Length == 0)
                    {
                        MessageBox.Show("Please Insert Data");
                    }
                    else
                    {
                        if (personController.updatePerson(person) == true)
                        {
                            MessageBox.Show("Saved");

                        }
                        else
                        {
                            MessageBox.Show("not saved");
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
