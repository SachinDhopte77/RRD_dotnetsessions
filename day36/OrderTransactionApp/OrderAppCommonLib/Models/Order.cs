using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppCommonLib.Models
{
    public class Order
    {
        private readonly string _customerName;
        private readonly string _orderName;
        private readonly DateTime _date;
        private int OrderID;
        private static int _orderId;
        private List<OrderItem> _orderItems = new List<OrderItem>();

        static Order()
        {
            _orderId = 1000;
        }

        public Order(string customerName, string orderName, DateTime date)
        {
            _customerName = customerName;
            _orderName = orderName;
            _date = date;
            _orderId++;
        }

        public void AddOrderItem(string orderItemname, double unitPrice, int quantity)
        {
            _orderItems.Add(new OrderItem { OrderItemName = orderItemname, UnitPrice = unitPrice, Quantity = quantity, ItemCost = quantity * unitPrice });
        }

        public string CustomerName { get { return _customerName; } }

        public string OrderName { get { return _orderName; } }

        public DateTime Date { get { return _date; } }

        public int OrderId { get { return _orderId; } }

        public List<OrderItem> OrderItems { get { return _orderItems; } }
    }
}
