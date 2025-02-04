using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppCommonLib.Models
{
    public class OrderItem
    {

        public string OrderItemName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double ItemCost { get; set; }


    }
}
