using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Model
{
    public class OrderBackLog
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public string Vat { get; set; }
        public string TotalPrice { get; set; }
    }
}
