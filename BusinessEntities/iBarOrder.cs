using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface iBarOrder
    {
         int orderid { get; set; }
         DateTime orderTime { get; set; }
         string orderItems { get; set; }
         double orderPrice { get; set; }
         int orderQuantity { get; set; }
         double orderChange { get; set; }
    }
}
