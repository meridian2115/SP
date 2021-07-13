using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrRevenueTestList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0101 { get; set; }
        public string C2R0101 { get; set; }
        public string C3R0101 { get; set; }
        public string C3aR0101 { get; set; }
        public string C3bR0101 { get; set; }
        public decimal? C4R0101 { get; set; }
        public decimal? C5R0101 { get; set; }
        public decimal? C6R0101 { get; set; }
        public decimal? C7R0101 { get; set; }
        public decimal? C8R0101 { get; set; }
        public decimal? C9R0101 { get; set; }
        public string Num010 { get; set; }

        public virtual DcReportTest Doc { get; set; }
    }
}
