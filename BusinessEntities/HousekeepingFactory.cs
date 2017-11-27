using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class HousekeepingFactory
    {
        private static IHousekeeping housekeeping = null;

        public static IHousekeeping getHousekeeping(int keepingId, int Roomid, string Cleaner, string Description,DateTime DateOfCleaning,string CleaningType)
        {
            if (housekeeping != null) // ie is Hotel is primed with an object. 
                return housekeeping;
            else
                return new Housekeeping(keepingId,Roomid,Cleaner,Description, DateOfCleaning, CleaningType); // Factory coughs up a regular user (for production code) 
        }

        public static void setHousekeeping(IHousekeeping aHouse)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            housekeeping = aHouse;
        }
    }
}
