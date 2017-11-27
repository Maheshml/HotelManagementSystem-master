using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Item : BusinessEntities.IItem
    {
        private int itemID;
        private string Name;
        private int Quantity;
        private double UnitPrice;
        private int SupplierID;
        private string Category;


        public Item(int itemID, string name, int quantity, double unitPrice, int supplierID, string category)
        {
            this.itemID = itemID;
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.SupplierID = supplierID;
            this.Category = category;

          
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                this.itemID = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                this.Name = value;
            }
        }

        public int quantity
        {
            get
            {
                return Quantity;
            }

            set
            {
                this.Quantity = value;
            }
        }

        public double unitPrice
        {
            get
            {
                return UnitPrice;
            }

            set
            {
                this.UnitPrice = value;
            }
        }

        public int supplierID
        {
            get
            {
                return SupplierID;
            }

            set
            {
                this.SupplierID = value;
            }
        }

        public string category
        {
            get
            {
                return Category;
            }

            set
            {
                this.Category = value;
            }
        }

    }
}
