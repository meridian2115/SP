using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpScheduleReports
    {
        public HArpScheduleReports()
        {
            HfsSchRepTabList = new HashSet<HfsSchRepTabList>();
        }

        public decimal Id { get; set; }
        public string PeriodType { get; set; }
        public DateTime? ReportingDate { get; set; }
        public string Cdsubjreport { get; set; }
        public string Cdalt { get; set; }
        public string Nmsubjreport { get; set; }
        public string Prcdsubjreport { get; set; }
        public string Prnmsubjreport { get; set; }
        public string Code { get; set; }

        public virtual ICollection<HfsSchRepTabList> HfsSchRepTabList { get; set; }
    }
}
