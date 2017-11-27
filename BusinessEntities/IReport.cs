using System;

namespace BusinessEntities
{
    public interface IReport
    {
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string ReportType { get; set; }
        double RevenueGenerated { get; set; }
        DateTime ReportDate { get; set; }
        DateTime DateOfReport { get; set; }



    }
}