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
    public partial class Voucher : Form
    {
        public Voucher(double price,double discount, double vat, double totalPrice)
        {
            InitializeComponent();
            this.PriceLabel.Text = price.ToString();
            this.VatLabel.Text = vat.ToString();
            this.DiscountLabel.Text = discount.ToString();
            this.TotalPricelabel.Text = totalPrice.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics graphics2 = Graphics.FromImage(bitmap);
            graphics2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            this.Visible = false;
        }
    }
}
