using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ShoppingCart
{
    public class ShoppingCartItem
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public double UnitCost { get; set; }
    }
}
