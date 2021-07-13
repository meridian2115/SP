using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReportingPeriods
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodName { get; set; }
        public string PeriodType { get; set; }
        public string Regularity { get; set; }
        public DateTime? ReportingDate { get; set; }
        public string RpPrPeriodCode { get; set; }
        public string RpPrPeriodName { get; set; }
        public DateTime? RpPrReportingDate { get; set; }
        public string RpPrPeriodType { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
