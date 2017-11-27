using System;
using System.Collections.Generic;
namespace BusinessEntities.Send_Order_to_Kitchen
{
    class Order : IOrder
    {
       
        public Order(string employeeNumber, Dictionary<string, int> orderList, String tableNum)
        {

            this.EmployeeNumber = employeeNumber;
            this.OrderList = orderList;
            this.TableNumber = tableNum;

        }

        public string EmployeeNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantuty { get; set; }
        public Dictionary<string, int> OrderList { get; set; }
        public string TableNumber { get; set; }
    }
}
