using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSfDomesticAaiList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string BudgClassCode { get; set; }
        public string AdmCode { get; set; }
        public string CodeRvnSf { get; set; }
        public string IndicatorName { get; set; }
        public decimal? Sum { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? Sum3 { get; set; }
        public decimal? Sum4 { get; set; }

        public virtual DcArpAuthadmincome Doc { get; set; }
    }
}
