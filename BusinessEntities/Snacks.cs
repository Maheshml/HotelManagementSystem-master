using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Snacks:ISnack
    {
        public Snacks(int SnackId,string Name,double Price,int Quantity)
        {
            this.snackId = SnackId;
            this.name = Name;
            this.price = Price;
            this.quantity = Quantity;
        }
        public int snackId { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        int ISnack.SnackId
        {
            get
            {
                return snackId;
            }

            set
            {
                snackId = value;
            }
        }

        string ISnack.Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

         double ISnack.Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        int ISnack.Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
