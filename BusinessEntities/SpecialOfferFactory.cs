using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public static class SpecialOfferFactory
    {
        private static ISpecialOffer offer = null;

        public static ISpecialOffer GetOffer(int id, decimal percent, DateTime startDate, DateTime endDate, string name, string description, string state)
        {
            if (offer != null) // ie is Hotel is primed with an object. 
                return offer;
            else
                return new SpecialOffer(id, percent, startDate, endDate, name, description, state); // Factory coughs up a regular user (for production code) 
        }

        public static void SetOffer(ISpecialOffer aOffer)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            offer = aOffer;
        }
    }
}
