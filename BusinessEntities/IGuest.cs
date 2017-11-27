using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IGuest
    {
        int guestID { get; set; }
        string firstName { get; set; }
        string middleName { get; set; }
        string surname{ get; set; }
        string phoneNumber { get; set; }
        string street { get; set; }
        string city { get; set; }
        string country { get; set; }
        

    }
}
