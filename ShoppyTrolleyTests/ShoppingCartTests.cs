using System;
using NUnit.Framework;
using Store;
using Store.ShoppingCart;

namespace ShoppingCartTests
{
    public class Tests
    {
        private ShoppingCart? _Cart;
        private Product? _Product1;
        private Product? _Product2;
        private Product? _Product3;
        private Product? _Product4;

        [SetUp]
        public void Setup()
        {
            _Cart = new ShoppingCart();
            _Product1 = Warehouse.Instance.Find(new Guid("{A662C663-695C-4EEA-8D40-0684D948128A}"));
            _Product2 = Warehouse.Instance.Find(new Guid("{A1863103-63C2-4184-B7E5-D3B4EFC411A4}"));
            _Product3 = Warehouse.Instance.Find(new Guid("{891DAACE-9FBF-41D7-872F-B1DC7DD25D1D}"));
            _Product4 = Warehouse.Instance.Find(new Guid("{50B506A7-A219-4156-9D4A-5F17FD969007}"));
        }

        [Test]
        public void TestCartIsEmpty()
        {
            Assert.True(_Cart.IsEmpty);
            Assert.IsTrue(_Cart.TotalItems() == 0);
        }

        [Test]
        public void TestCartIsNotEmpty()
        {
            _Cart.Add(_Product1, 1);
            Assert.True(!_Cart.IsEmpty);
        }
        [Test]
        public void TestShoppingCartItemsAccumulate()
        {   
            _Cart.Add(_Product1, 1);
            Assert.IsTrue(_Cart.TotalItems() == 1);
            _Cart.Add(_Product1, 2);
            Assert.IsTrue(_Cart.TotalItems() == 3);
            _Cart.Add(_Product2, 1);
            Assert.IsTrue(_Cart.TotalItems() == 4);
        }
        [Test]
        public void TestShoppingCartItemRemoval()
        {
            _Cart.Add(_Product1, 1);
            _Cart.Remove(_Product1);
            Assert.True(_Cart.IsEmpty);
            Assert.IsTrue(_Cart.TotalItems() == 0);
        }

        [Test]
        public void TestCanEmptyShoppingCart()
        {
            _Cart.Add(_Product1, 1);
            _Cart.Empty();
            Assert.True(_Cart.IsEmpty);
            Assert.IsTrue(_Cart.TotalItems() == 0);
        }
    }
}