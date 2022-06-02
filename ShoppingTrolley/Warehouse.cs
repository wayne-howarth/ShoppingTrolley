using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{ 
    public class Warehouse : IWarehouse
    {
        private static Warehouse _Instance = new Warehouse();
        private List<Product> _Products = new List<Product>();

        private Warehouse()
        {
            // Initialise with default stock

            _Products.AddRange(new Product[] {
                new Product
                {
                    ProductId = new Guid("{A662C663-695C-4EEA-8D40-0684D948128A}"),
                    Description = "Product #1",
                    Cost = 10.00,
                    StockLevel = 100
                },
                new Product
                {
                    ProductId = new Guid("{A1863103-63C2-4184-B7E5-D3B4EFC411A4}"),
                    Description = "Product #2",
                    Cost = 15.00,
                    StockLevel = 100
                },
                new Product
                {
                    ProductId = new Guid("{891DAACE-9FBF-41D7-872F-B1DC7DD25D1D}"),
                    Description = "Product #3",
                    Cost = 40.00,
                    StockLevel = 100
                },
                new Product
                {
                    ProductId = new Guid("{50B506A7-A219-4156-9D4A-5F17FD969007}"),
                    Description = "Product #4",
                    Cost = 55.00,
                    StockLevel = 100
                }
            });
        }

        public static Warehouse Instance => _Instance;

        public List<Product> Products { get { return _Products; } }

        public Product Find(Guid productId)
        {
            return _Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public void Remove(Guid productId, int Qty)
        {
            // TODO
        }
    }
}
