using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReportingPeriods
    {
        public decimal Id { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodName { get; set; }
        public string PeriodType { get; set; }
        public DateTime? ReportingDate { get; set; }
        public string Note { get; set; }
    }
}
