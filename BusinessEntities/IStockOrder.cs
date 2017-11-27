using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStockOrder
    {
        int orderID { get; set; }
        DateTime orderCreated { get; set; }
        DateTime orderSent { get; set; }
        
        string orderReceived { get; set; }
        int supplierID { get; set; }
        string deliverTo { get; set; }
        
        double orderTotal { get; set;}
        string status { get; set; }

    }
}
