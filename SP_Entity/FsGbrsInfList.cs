using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsGbrsInfList
    {
        public FsGbrsInfList()
        {
            FsBudgetReportList = new HashSet<FsBudgetReportList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Code { get; set; }
        public string GrbsName { get; set; }
        public decimal? ItogogrbsYearbeg { get; set; }
        public decimal? ItogogrbsPeriodend { get; set; }

        public virtual DcArpReport0531341 Doc { get; set; }
        public virtual ICollection<FsBudgetReportList> FsBudgetReportList { get; set; }
    }
}
