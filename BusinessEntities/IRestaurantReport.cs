using System;

namespace BusinessEntities
{
    public interface IRestaurantReport
    {


        int NumClients { get; set; }
        DateTime BusiestDay { get; set; }
        DateTime LeastBusiestDay { get; set; }



    }
}