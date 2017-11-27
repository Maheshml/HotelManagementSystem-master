using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class SupplierFactory
    {
        private static ISupplier supplier = null;

        public static ISupplier GetSupplier(int supplierID, string name, string phoneNum, string email, string street, string city,
            string county, string additionalInfo)
        {
            if (supplier != null)
                return supplier;

            else
                return new Supplier(supplierID, name, phoneNum, email, street, city, county, additionalInfo);

        }

        public static void SetSupplier(ISupplier aSupplier)
        {
            supplier = aSupplier;
        }
    }
}

