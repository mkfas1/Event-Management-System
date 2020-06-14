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
    public partial class BreakfastPanel : UserControl
    {
        public static BreakfastPanel breakfastPanel;
        public static BreakfastPanel breakfast
        {
            get
            {
                if (breakfastPanel == null)
                    breakfastPanel = new BreakfastPanel();
                return breakfastPanel;
            }
        }
        public BreakfastPanel()
        {
            InitializeComponent();
        }
        MenuController menuController = new MenuController();
        private void BreakfastPanel_Load(object sender, EventArgs e)
        {
            foreach (DataRow items in menuController.getBreakFast().Rows)
            {
                int n = breakfastGridView.Rows.Add();
                breakfastGridView.Rows[n].Cells[1].Value = items[0];
                breakfastGridView.Rows[n].Cells[2].Value = items[1].ToString();
                breakfastGridView.Rows[n].Cells[3].Value = items[2].ToString();
                breakfastGridView.Rows[n].Cells[4].Value = items[3].ToString();
                breakfastGridView.Rows[n].Cells[5].Value = items[4].ToString();
                breakfastGridView.Rows[n].Cells[6].Value = items[5].ToString();
                breakfastGridView.Rows[n].Cells[7].Value = items[6].ToString();
            }
        }
        

        private void BreakfastOrderButton_Click(object sender, EventArgs e)
        {
            List<OrderMenu> orderMenus = new List<OrderMenu>();
            foreach (DataGridViewRow items in breakfastGridView.Rows)
            {
                if (Convert.ToBoolean(items.Cells[0].Value))
                {
                    orderMenus.Add(new OrderMenu
                    {
                        Id = Int32.Parse(items.Cells[1].Value.ToString()),
                        Name = items.Cells[2].Value.ToString(),
                        Price = Double.Parse(items.Cells[3].Value.ToString()),
                        Rm1 = items.Cells[4].Value.ToString(),
                        Rm2 = items.Cells[5].Value.ToString(),
                        Rm3 = items.Cells[6].Value.ToString(),
                        Rm4 = items.Cells[7].Value.ToString(),
                    });
                }
            }
            OrderModal orderModal = new OrderModal();
            orderModal.values = orderMenus;
            orderModal.Visible = true;
        }
    }
}
