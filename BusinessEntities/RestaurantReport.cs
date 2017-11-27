using System;

namespace BusinessEntities
{
    public class RestaurantReport : Report, IRestaurantReport
    {

        //constructor for both monthly and weekly report
        public RestaurantReport(DateTime fromDate, DateTime toDate,  double revenueGenerated,
            DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
            :base(fromDate, toDate, revenueGenerated, reportDate){ }


        //constructor for the bespoke report
        public RestaurantReport(DateTime fromDate, DateTime toDate, string reportType, double revenueGenerated,
          DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
          : base(fromDate, toDate, reportType, revenueGenerated, reportDate) { }

        //daily report
        public RestaurantReport(DateTime dayOfReport, double revenueGenerated,
            DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
            : base(dayOfReport,  revenueGenerated, reportDate) { }



        public int NumClients { get; set; }
        public DateTime BusiestDay { get; set; }
        public DateTime LeastBusiestDay { get; set; }
    }
}