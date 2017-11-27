using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class GuestFactory
    {
        private static IGuest guest = null;

        public static IGuest GetGuest(int guestID, string firstName, string middleName, string surname, string phoneNumber, string street, string city, string country)
        {
            if (guest != null)
                return guest;

            else
                return new Guest(guestID, firstName, middleName, surname, phoneNumber, street, city, country);

        }

        public static void SetGuest(IGuest aGuest)
        {
            guest = aGuest;
        }
    }
}