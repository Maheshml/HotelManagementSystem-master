using System;

namespace BusinessEntities
{
    public class RestaurantReportFactory

    {





        private static readonly IRestaurantReport _dailyReport = null;
        private static readonly IRestaurantReport _monthlyReport = null;
        private static readonly IRestaurantReport _weeklyReport = null;
        private static readonly IRestaurantReport _bespokeReport = null;



        //daily report
        public static IRestaurantReport GetDailyReport(DateTime dateOfReport, double revenueGenerated,
          DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
        {
            return _dailyReport ?? new RestaurantReport(dateOfReport, revenueGenerated, reportDate, numClient, busiestDay,
                       leastBusiestDay);
        }


        //monthly report
        public static IRestaurantReport GetMonthlyReport(DateTime fromDate, DateTime toDate, string reportType, double revenueGenerated,
          DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
        {
            return _monthlyReport ?? new RestaurantReport(fromDate, toDate, revenueGenerated, reportDate, numClient, busiestDay,
                       leastBusiestDay);
        }
        

        //weekly report
        public static IRestaurantReport GerWeelyReport(DateTime fromDate, DateTime toDate, string reportType, double revenueGenerated,
          DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
        {
            return _weeklyReport ?? new RestaurantReport(fromDate, toDate, revenueGenerated, reportDate, numClient, busiestDay,
                       leastBusiestDay);
        }



        //bespoke report- this will be generated based on the criteria selected by the user
        public static IRestaurantReport GetBespokeReport(DateTime fromDate, DateTime toDate, string reportType, double revenueGenerated,
          DateTime reportDate, int numClient, DateTime busiestDay, DateTime leastBusiestDay)
        {
            return _bespokeReport ?? new RestaurantReport(fromDate, toDate, reportType, revenueGenerated, reportDate, numClient, busiestDay,
                       leastBusiestDay);
        }



    }
}