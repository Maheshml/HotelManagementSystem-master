using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IHousekeeping
    {
        int housekeepingId { get; set; }
        int Roomid { get; set; }
        string Cleaner { get; set; }
        string Description { get; set; }

        DateTime DateOfCleaning { get; set; }

        string TypeOfCleaning { get; set; }
    }
}
