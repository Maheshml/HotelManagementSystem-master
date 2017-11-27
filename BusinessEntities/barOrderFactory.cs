using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class barOrderFactory
    {
        private static iBarOrder barOrder = null;

        public static iBarOrder getBarOrders(int Orderid, DateTime OrderTime, string OrderItems, double OrderPrice, int OrderQuantity, double OrderChange)
        {
            if (barOrder != null) // ie is Hotel is primed with an object. 
                return barOrder;
            else
                return new barOrder( Orderid,  OrderTime,  OrderItems,  OrderPrice, OrderQuantity, OrderChange); // Factory coughs up a regular user (for production code) 
        }

        public static void setHousekeeping(iBarOrder aBarOrder)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            barOrder = aBarOrder;
        }
    }
}
