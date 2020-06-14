using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentManagement
{
    public partial class HomepagePanel : UserControl
    {
        public static HomepagePanel homepagePanel;
        public static HomepagePanel homepage
        {
            get
            {
                if (homepagePanel == null)
                    homepagePanel = new HomepagePanel();
                return homepagePanel;
            }
        }
        public HomepagePanel()
        {
            InitializeComponent();
        }

        private void HomepagePanel_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
