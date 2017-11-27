using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStockOrderItem
    {
        int OrderItemID { get; set; }
        int ItemID { get; set; }
        int Quantity { get; set; }
        double Total { get; set;}
        int OrderID { get; set;}
        int QtyReceived { get; set; }

    }
}
