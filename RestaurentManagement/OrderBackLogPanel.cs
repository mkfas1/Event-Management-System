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
    public partial class OrderBackLogPanel : UserControl
    {
        public static OrderBackLogPanel orderBackLogPanel;
        public static OrderBackLogPanel orderBackLog
        {
            get
            {
                if (orderBackLogPanel == null)
                    orderBackLogPanel = new OrderBackLogPanel();
                return orderBackLogPanel;
            }
        }

        public OrderBackLogPanel()
        {
            
            InitializeComponent();
        }

        OrderBackLogController orderBackLogController = new OrderBackLogController();
        private void OrderBackLogPanel_Load(object sender, EventArgs e)
        {
            OrderBackLogTableGridView.DataSource = orderBackLogController.getAllOrderBackLog();
        }

        
    }
}
