using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ExtraCharge : BusinessEntities.IExtraCharge
    {
       
        

        private int ChargeID;
        private string ChargeType;
        private double ChargeAmount;
        private string ChargeStatus;
        private int BookingChargeID;

        

        public ExtraCharge(int chargeID, string chargeType, double chargeAmount, string chargeStatus, int bookingChargeID)
        {
            this.ChargeID = chargeID;
            this.ChargeType = chargeType;
            this.ChargeAmount = chargeAmount;
            this.ChargeStatus = chargeStatus;
            this.BookingChargeID = bookingChargeID;
    }

        public int chargeID
        {
            get
            {
                return ChargeID;
            }

            set
            {
                ChargeID = value;
            }
        }

        public string chargeType
        {
            get
            {
                return ChargeType;
            }

            set
            {
                ChargeType = value;
            }
        }

        public double chargeAmount
        {
            get
            {
                return ChargeAmount;
            }

            set
            {
                ChargeAmount = value;
            }
        }

        public string chargeStatus
        {
            get
            {
                return ChargeStatus;
            }

            set
            {
                ChargeStatus = value;
            }
        }

        public int bookingChargeID
        {
            get
            {
                return BookingChargeID;
            }

            set
            {
                BookingChargeID = value;
            }
        }





    }

}



