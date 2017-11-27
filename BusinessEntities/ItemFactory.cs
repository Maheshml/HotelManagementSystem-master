using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ItemFactory 
    {
        private static IItem item = null;

        public static IItem GetItem(int itemID, string name, int quantity, double unitPrice, int supplierID, string category)
        {
            if (item != null)
                return item;

            else
                return new Item(itemID, name, quantity, unitPrice, supplierID, category);

        }

        public static void SetItem(IItem aItem)
        {
            item = aItem;
        }
    }
}

