using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IWarehouse
    {
        List<Product> Products { get; }
        Product Find(Guid productId);
        void Remove(Guid productId, int Qty);
    }
}
