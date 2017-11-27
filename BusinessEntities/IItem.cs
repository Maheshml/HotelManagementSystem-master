using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IItem
    {
        int ItemID { get; set; }
        string name { get; set; }
        int quantity { get; set; }
        double unitPrice { get; set; }
        int supplierID { get; set; }
        string category { get; set; }
        
    }
}
