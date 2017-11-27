using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IExtraCharge
    {
        

        int chargeID { get; set; }
        string chargeType { get; set; }
        double chargeAmount { get; set; }
        string chargeStatus { get; set; }
        int bookingChargeID { get; set; }

    }
}