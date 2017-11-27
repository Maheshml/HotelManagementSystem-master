using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockOrderItem: IStockOrderItem

    {
        private int orderItemID;
        private int itemID;
        private int quantity;
        private double total;
        private int orderID;
        private int qtyReceived;

        public StockOrderItem(int orderItemID, int itemID, int quantity, double total, int orderID)
        {
            this.orderItemID = orderItemID;
            this.itemID = itemID;
            this.quantity = quantity;
            this.total = total;
            this.orderID = orderID;
            

        }

        public int OrderItemID
        {
            get
            {
                return orderItemID;
            }

            set
            {
                this.orderItemID = value;
            }
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

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                this.quantity = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                this.total = value;
            }
        }

        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                this.orderID = value;
            }
        }

        public int QtyReceived
        {
            get
            {
                return qtyReceived;
            }

            set
            {
                this.qtyReceived = value;
            }
        }

    }
}
