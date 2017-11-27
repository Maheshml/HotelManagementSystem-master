using System.Collections.Generic;
namespace BusinessEntities.Send_Order_to_Kitchen

{
    interface IOrder
    {

        string TableNumber { get; set; }
        string EmployeeNumber { get; set; }
        int ItemQuantuty { get; set; }
        string ItemName { get; set; }
        Dictionary<string, int> OrderList {get; set;}


    }
}
