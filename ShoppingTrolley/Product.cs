using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int StockLevel { get; set; }
    }
}
