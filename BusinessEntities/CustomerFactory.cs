using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessEntities
{
    public static class CustomerFactory // Only concern of factory is to create objects. 
    {
        private static ICustomer customer = null;

        public static ICustomer GetCustomer(int customerId, string firstName, string lastName, string email, string copyOfId )
        {
            if (customer != null)  // ie is Factory is primed with an object. 
                return customer;
            else
                //MessageBox.Show("in factory");
                return new Customer(customerId, firstName, lastName, email, copyOfId); // Factory coughs up a regular user (for production code) 
        }
        
    }

}


