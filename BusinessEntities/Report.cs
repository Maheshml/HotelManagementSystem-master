using System;

namespace BusinessEntities
{
    public class Report : IReport
    {

        public Report() { }


        //constructor for the bespoke report
        public Report(DateTime fromDate, DateTime toDate, string reportType,  double revenueGenerated, DateTime reportDate)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.ReportType = reportType;
            this.RevenueGenerated = revenueGenerated;
            this.ReportDate = reportDate;

        }

        //constructor for both weekly and monthly report
        public Report(DateTime fromDate, DateTime toDate, double revenueGenerated, DateTime reportDate)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.RevenueGenerated = revenueGenerated;
            this.ReportDate = reportDate;

        }


        //daily report
        public Report(DateTime dayOfReport, double revenueGenerated, DateTime reportDate)
        {
            this.DateOfReport = dayOfReport;
            this.RevenueGenerated = revenueGenerated;
            this.ReportDate = reportDate;

        }


        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ReportType { get; set; }
        public double RevenueGenerated { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime DateOfReport { get; set; }
    }
}