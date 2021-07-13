using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSchRepTabList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cdsubjreport { get; set; }
        public string GlavaBk { get; set; }
        public string Cdalt { get; set; }
        public string Nmsubjreport { get; set; }
        public string Okud { get; set; }
        public string Name { get; set; }
        public string Cdaccbu { get; set; }
        public string Cdansection { get; set; }
        public DateTime? Dateorder { get; set; }
        public decimal? Daysorder { get; set; }
        public string Tpsubreport { get; set; }
        public string NumPp { get; set; }
        public string ReportSub { get; set; }

        public virtual DcArpScheduleReports Doc { get; set; }
    }
}
