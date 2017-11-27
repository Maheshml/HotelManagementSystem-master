using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class StockOrderFactory
    {
        private static IStockOrder order = null;

        public static IStockOrder GetStockOrder(int orderID, DateTime orderCreated,  int supplierID, string deliverTo, double orderTotal, string status)
        {
            if (order != null)
                return order;

            else
                return new StockOrder(orderID, orderCreated, supplierID, deliverTo, orderTotal, status);

        }

        public static void SetStockOrder(IStockOrder aStockOrder)
        {
            order = aStockOrder;
        }
    }
}
