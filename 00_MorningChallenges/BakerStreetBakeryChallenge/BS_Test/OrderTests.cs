using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BS_Test
{
    [TestClass]
    public class OrderTests
    {
        private OrderRepository _orderRepo;
        private OrderTests _orderA;
        private Cake _cake;
        private Bread _bread;
        private Pastry _pastry;
        private Pie _pie;
            
        [TestInitialize]
        public void Init()
        {
            _orderRepo = new OrderRepository();
            _orderA = new Order();
            _cake = new Cake();
            _bread = new Bread();
            _pastry = new Pastry();
            _pie = new Pie();

        }
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void OrderA_Cake_ShouldREturnTotal()
        {
            _orderA.Product = _cake;
            _orderA.NumberOfBatches = 100;

            var grandTotal = _orderA.OrderA_Cake_ShouldREturnTotal();

            Console.WriteLine(grandTotal);

            var expected =(2000.00m * 100) + 100m;
            var actual = grandTotal;

            Assert.AreEqual(expected, actual)
        }
        public void OrderA_Bread_ShouldREturnTotal()
        {
            _orderA.Product = _bread;
            _orderA.NumberOfBatches = 100;

            var grandTotal = _orderA.OrderA_Bread_ShouldREturnTotal();

            Console.WriteLine(grandTotal);

            var expected = (851.50m * 100) + 100m;
            var actual = grandTotal;

            Assert.AreEqual(expected, actual)
        }
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ShowDetails()
        {
            _orderA.Product = _pies;
            _orderA.NumberOfBatches = 100;
            _orderRepo.AddOrder(_orderA);
            OrderA_Cake_ShouldREturnTotal value = _orderRepo.GetOrder(OrderA.OrderNumber);
            string expected = "Pie";
            Assert.AReEqual(expected, value.Product.GetType().Name);
        }
    }
}
