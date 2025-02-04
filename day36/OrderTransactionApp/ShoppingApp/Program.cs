using OrderAppCommonLib.Models;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order("Sachin", "Dairy", DateTime.Now);
            order1.AddOrderItem("Milk", 30, 5);
            order1.AddOrderItem("Cheese", 100, 3);
            order1.AddOrderItem("Butter", 80, 2);
            order1.AddOrderItem("Butter Milk", 24, 2);
            order1.AddOrderItem("Ice Cream", 100, 2);


            PrintDetail(order1);
        }

        private static void PrintDetail(Order order1)
        {
            Console.WriteLine($"Order ID : {order1.OrderId} || Name is: {order1.CustomerName} || Order Name: {order1.OrderName} || Order Date : {order1.Date}");

            List<OrderItem> allOrderItems = order1.OrderItems;

            double billTotal = 0;
            foreach (OrderItem item in allOrderItems)
            {
                Console.WriteLine($"Order Item Name : {item.OrderItemName} || Price is : {item.UnitPrice} || Quantity: {item.Quantity} || Total Item Cost: {item.ItemCost}");
                billTotal += item.ItemCost;
            }
            Console.WriteLine("Total Bill Cost : " + billTotal);
        }
    }
}
