using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class barOrder:iBarOrder
    {
        
        public barOrder(int Orderid, DateTime OrderTime, string OrderItems, double OrderPrice, int OrderQuantity, double OrderChange)
        {
            this.orderid = Orderid;
            this.orderTime = OrderTime;
            this.orderItems = OrderItems;
            this.orderPrice = OrderPrice;
            this.orderQuantity = OrderQuantity;
            this.orderChange = OrderChange;
        }
        public int orderid { get; set; }
        public DateTime orderTime { get; set; }
        public string orderItems { get; set; }
        public double orderPrice { get; set; }
        public int orderQuantity { get; set; }
        public double orderChange { get; set; }
    }
}
