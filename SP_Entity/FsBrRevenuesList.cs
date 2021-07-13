using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrRevenuesList
    {
        public FsBrRevenuesList()
        {
            FsT2031List = new HashSet<FsT2031List>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string BudgClassCode { get; set; }
        public string AdmCode { get; set; }
        public string CodeRvnBd { get; set; }
        public string IndicatorName { get; set; }
        public decimal? Sum { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? Sum3 { get; set; }
        public decimal? Sum4 { get; set; }
        public decimal? Sum1sum2 { get; set; }
        public decimal? Sum1sum2sum3 { get; set; }
        public decimal? Sum01 { get; set; }
        public decimal? Sum02 { get; set; }
        public decimal? Sum03 { get; set; }
        public decimal? Sum04 { get; set; }
        public decimal? Sum05 { get; set; }
        public decimal? Sum06 { get; set; }
        public decimal? Sum07 { get; set; }
        public decimal? Sum08 { get; set; }
        public decimal? Sum09 { get; set; }
        public decimal? Sum10 { get; set; }
        public decimal? Sum11 { get; set; }
        public decimal? Sum12 { get; set; }
        public string NumR1T1 { get; set; }
        public string CountT2 { get; set; }
        public decimal? Docid1 { get; set; }

        public virtual DcArpAuthadmincome Doc { get; set; }
        public virtual ICollection<FsT2031List> FsT2031List { get; set; }
    }
}
