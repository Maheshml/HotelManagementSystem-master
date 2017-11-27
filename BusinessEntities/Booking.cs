using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Booking : BusinessEntities.IBooking
    {
        private int BookingID;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private int NoOfGuests;
        private double TotalCost;
        private int GuestID;
        private string Status;
        private string Paid;
        private int RoomNumber;

        
        
        public Booking(int bookingID, DateTime checkIn, DateTime checkOut, int noOfGuests, double totalCost, int guestID, string status, string paid, int roomNumber)
        {
            this.BookingID = bookingID;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.NoOfGuests = noOfGuests;
            this.TotalCost = totalCost;
            this.GuestID = guestID;
            this.Status = status;
            this.Paid = paid;
            this.RoomNumber = roomNumber;
    }

        




        public int bookingID
        {
            get
            {
                return BookingID;
            }

            set
            {
                this.BookingID = value;
            }
        }

        public DateTime checkIn
        {
            get
            {
                return CheckIn;
            }

            set
            {
                this.CheckIn = checkIn;
            }
        }

        public DateTime checkOut
        {
            get
            {
                return CheckOut;
            }

            set
            {
                this.CheckOut = value;
            }
        }


        public int noOfGuests
        {
            get
            {
                return NoOfGuests;
            }

            set
            {
                this.NoOfGuests = value;
            }
        }

        public double totalCost
        {
            get
            {
                return TotalCost;
            }

            set
            {
                this.TotalCost = value;
            }
        }
        public int guestID
        {
            get
            {
                return GuestID;
            }

            set
            {
                GuestID = value;
            }
        }

        public string status
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }

        public string paid
        {
            get
            {
                return Paid;
            }

            set
            {
                Paid = value;
            }
        }

        public int roomNumber
        {
            get
            {
                return RoomNumber;
            }

            set
            {
                RoomNumber = value;
            }
        }

        





    }

}



