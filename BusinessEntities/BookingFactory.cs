using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class BookingFactory
    {
        private static IBooking booking = null;

        public static IBooking GetBooking(int bookingID, DateTime checkIn, DateTime checkOut, int noOfGuests, double totalCost, int guestID, string status, string paid, int roomNumber)
        {
            if (booking != null)
                return booking;

            else
                return new Booking(bookingID, checkIn, checkOut, noOfGuests, totalCost, guestID, status, paid, roomNumber);

        }

        

        public static void SetBooking(IBooking aBooking)
        {
            booking = aBooking;
        }
    }
}