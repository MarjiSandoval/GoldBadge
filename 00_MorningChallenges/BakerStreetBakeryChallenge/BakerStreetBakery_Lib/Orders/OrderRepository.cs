using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery_Lib.Orders
{
    public class OrderRepository
    {
        private readonly List<Order> _orderDB = new List<Order>();
        private int _count = 0;

        public bool AddOrder(Order order)
        {
            if (order is null)
            {
                return false;
            }
            else
            {
                _count++;
                order.OrderNumber = _count;
                _orderDB.Add(order);
                return true;

            }
        }
        public List<Order> GetOrders()
        {
            return _orderDB;
        }
        public Order GetOrder(int orderNumber)
        {
            foreach (Order order in _orderDB)
            {
                if (order.OrderNumber == orderNumber)
                {
                    return order;
                }
            }
            return null;
        }
        public bool RemoveOrder(int orderNumber)
        {
            foreach (Order order in _orderDB)
            {
                if (order.OrderNumber == orderNumber)
                {
                    _orderDB.Remove(order);
                    return true;
                }
            }
            return false;
        }

    }
}
