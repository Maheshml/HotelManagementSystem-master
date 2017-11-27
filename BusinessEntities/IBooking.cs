using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IBooking
    {
        int bookingID { get; set; }
        DateTime checkIn { get; set; }
        DateTime checkOut { get; set; }
        int noOfGuests { get; set; }
        double totalCost { get; set; }
        int guestID { get; set; }
        string status { get; set; }
        string paid { get; set; }
        int roomNumber { get; set; }
            
    }
}
