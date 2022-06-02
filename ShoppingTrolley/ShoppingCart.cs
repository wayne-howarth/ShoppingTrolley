using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Store
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _Contents = new List<ShoppingCartItem>();

        public IEnumerable<ShoppingCartItem> Contents
        {
            get { return _Contents; }
        }

        public bool IsEmpty
        {
            get
            {
                return _Contents.Count == 0;
            }
        }

        public void Add(Product product, int quantity)
        {
            ShoppingCartItem existing = _Contents.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existing == null)
            {
                var item = new ShoppingCartItem()
                {
                    ProductId = product.ProductId,
                    Description = product.Description,
                    Qty = quantity,
                    UnitCost = product.Cost
                };
                _Contents.Add(item);
            }
            else
            {
                existing.Qty = existing.Qty + quantity;
            }
        }

        public void Remove(Product product)
        {
            ShoppingCartItem item = _Contents.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (item != null)
            {
                _Contents.Remove(item);
            }
        }

        public void Empty()
        {
            _Contents.Clear();
        }

        public int TotalItems()
        {
            return _Contents.Select(item => item.Qty).Sum();
        }

        public double TotalCost(IDiscountCalculator dc)
        {
            var total = _Contents.Select(item => item.Qty * item.UnitCost).Sum();

            if (dc != null)
            {
                total = total - dc.TotalDiscount(this);
            }

            return total;
        }
    }
}
