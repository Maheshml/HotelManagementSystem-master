using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class StockOrderItemFactory
    {
        private static IStockOrderItem orderItem = null;

        public static IStockOrderItem GetOrderItem(int orderItemID, int itemID, int quantity, double total, int orderID)
        {
            if (orderItem != null)
                return orderItem;

            else
                return new StockOrderItem(orderItemID, itemID, quantity, total, orderID);

        }

        public static void SetItem(IStockOrderItem aStockOrderItem)
        {
            orderItem = aStockOrderItem;
        }
    }
}
