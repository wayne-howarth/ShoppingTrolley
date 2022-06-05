using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class DiscountCalculator: IDiscountCalculator
    {        
        public double TotalDiscount(ShoppingCart cart)
        {
            Product _Product2 = Warehouse.Instance.Find(new Guid("{A1863103-63C2-4184-B7E5-D3B4EFC411A4}"));
            Product _Product4 = Warehouse.Instance.Find(new Guid("{50B506A7-A219-4156-9D4A-5F17FD969007}"));

            int product2Qty = cart.Contents.FirstOrDefault(item => item.ProductId == _Product2.ProductId)?.Qty ?? 0;
            double product2Discount = (int) Math.Floor(product2Qty / 3.0) * 5;

            int product4Qty = cart.Contents.FirstOrDefault(item => item.ProductId == _Product4.ProductId)?.Qty ?? 0;
            double product4Discount = (int) Math.Floor(product4Qty / 2.0) * 27.5;

            return product2Discount + product4Discount;
        }
    }
}
