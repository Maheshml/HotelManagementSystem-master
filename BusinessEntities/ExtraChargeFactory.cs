using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ExtraChargeFactory
    {
        private static IExtraCharge extraCharge = null;

        public static IExtraCharge GetExtraCharge(int chargeID, string chargeType, double chargeAmount, string chargeStatus, int chargeBookingID)
        {
            if (extraCharge != null)
                return extraCharge;

            else
                return new ExtraCharge(chargeID, chargeType, chargeAmount, chargeStatus, chargeBookingID);

        }



        public static void SetExtraCharge(IExtraCharge aExtraCharge)
        {
            extraCharge= aExtraCharge;
        }
    }
}