using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ISupplier
    {
        int SupplierID { get; set; }
        string name { get; set; }
        string phoneNum { get; set; }
        string email { get; set; }
        string street { get; set; }
        string city { get; set; }
        string county { get; set; }
        string additionalInfo { get; set; }
        
    }
}
