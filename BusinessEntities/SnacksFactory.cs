using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SnacksFactory
    {
        private static ISnack snack = null;

        public static ISnack getSnacks(int SnackId, string Name, double Price, int Quantity)
        {
            if (snack != null) // ie is Hotel is primed with an object. 
                return snack;
            else
                return new Snacks( SnackId,  Name,  Price,  Quantity); // Factory coughs up a regular user (for production code) 
        }

        public static void setHousekeeping(ISnack aSnack)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            snack = aSnack;
        }
    }
}
