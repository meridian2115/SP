using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBudgetReportList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsGbrsInfListid { get; set; }
        public string Fullname { get; set; }
        public string Cdsr { get; set; }
        public decimal? Budgetyearbeg { get; set; }
        public decimal? Budgetperiodend { get; set; }

        public virtual FsGbrsInfList FsGbrsInfList { get; set; }
    }
}
