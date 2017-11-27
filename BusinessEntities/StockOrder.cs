using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockOrder : BusinessEntities.IStockOrder
    {
        private int OrderID;
        private DateTime OrderCreated;
        private DateTime OrderSent;
        private string OrderReceived;
        private int SupplierID;
        private string DeliverTo;
        private double OrderTotal;
        private string Status;

        


        public StockOrder(int orderID, DateTime orderCreated,  int supplierID,string deliverTo, double orderTotal, string status)
        {
            this.OrderID = orderID;
            this.OrderCreated = orderCreated;
            
            this.SupplierID = supplierID;
            this.DeliverTo = deliverTo;
            this.OrderTotal = orderTotal;
            this.Status = status;
        }
        

        public int orderID
        {
            get
            {
                return OrderID;
            }

            set
            {
                this.OrderID = value;
            }
        }

        public DateTime orderCreated
        {
            get
            {
                return OrderCreated;
            }

            set
            {
                this.OrderCreated = orderCreated;
            }
        }

        public DateTime orderSent
        {
            get
            {
                return OrderSent;
            }

            set
            {
                this.OrderSent = value;
            }
        }

       
        public string orderReceived
        {
            get
            {
                return OrderReceived;
            }

            set
            {
                this.OrderReceived = value;
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
            public string deliverTo
        {
            get
            {
                return DeliverTo;
            }

            set
            {
                DeliverTo = value;
            }
        }

        
        public double orderTotal
        {
            get
            {
                return OrderTotal;
            }

            set
            {
                OrderTotal = value;
            }
        }

        public string status
        {
            get
            {
                return Status;
            }

            set
            {
                this.Status = value;
            }
        }
        }

    }


