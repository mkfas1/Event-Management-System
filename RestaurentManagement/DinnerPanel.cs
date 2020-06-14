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
    public partial class DinnerPanel : UserControl
    {
        public static DinnerPanel dinnerPanel;
        public static DinnerPanel dinner
        {
            get
            {
                if (dinnerPanel == null)
                    dinnerPanel = new DinnerPanel();
                return dinnerPanel;
            }
        }
        public DinnerPanel()
        {
            InitializeComponent();
        }
        MenuController menuController = new MenuController();
        private void DinnerPanel_Load(object sender, EventArgs e)
        {
            foreach(DataRow items in menuController.getDinner().Rows)
            {
                int n = dinnerGridView.Rows.Add();
                dinnerGridView.Rows[n].Cells[1].Value = items[0];
                dinnerGridView.Rows[n].Cells[2].Value = items[1].ToString();
                dinnerGridView.Rows[n].Cells[3].Value = items[2].ToString();
                dinnerGridView.Rows[n].Cells[4].Value = items[3].ToString();
                dinnerGridView.Rows[n].Cells[5].Value = items[4].ToString();
                dinnerGridView.Rows[n].Cells[6].Value = items[5].ToString();
                dinnerGridView.Rows[n].Cells[7].Value = items[6].ToString();
            }
        }

        private void DinnerOrderButton_Click(object sender, EventArgs e)
        {
            List<OrderMenu> orderMenus = new List<OrderMenu>();
            foreach (DataGridViewRow items in dinnerGridView.Rows)
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
