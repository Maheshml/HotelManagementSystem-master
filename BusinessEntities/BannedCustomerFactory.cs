using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessEntities
{
    public static class BannedCustomerFactory // Only concern of factory is to create objects. 
    {
        private static IBannedCustomer customer = null;

        public static IBannedCustomer GetBannedCustomer(int id,string firstName, string lastName, string email, string reasonForBan, string photo)
        {
            if (customer != null)  // ie is Factory is primed with an object. 
                return customer;
            else
                //MessageBox.Show("in factory");
            return new BannedCustomer(id,firstName,lastName,email,reasonForBan,photo); // Factory coughs up a regular user (for production code) 
        }
        public static void SetUser(IUser aUser)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            //user = aUser;
        }
    }

}


