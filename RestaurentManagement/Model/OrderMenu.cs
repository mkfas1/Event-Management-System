using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Model
{
    public class OrderMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Rm1 { get; set; }
        public string Rm2 { get; set; }
        public string Rm3 { get; set; }
        public string Rm4 { get; set; }
        public int Status { get; set; }
    }
}
