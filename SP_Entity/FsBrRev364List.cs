using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrRev364List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0101 { get; set; }
        public string C2R0101 { get; set; }
        public string C1aR0101 { get; set; }
        public string C1bR0101 { get; set; }
        public string C1cR0101 { get; set; }
        public string C1dR0101 { get; set; }
        public string C1eR0101 { get; set; }
        public decimal? C3R0101 { get; set; }
        public decimal? C4R0101 { get; set; }
        public decimal? C5R0101 { get; set; }
        public decimal? C6R0101 { get; set; }
        public decimal? C7R0101 { get; set; }
        public string C8R0101 { get; set; }
        public string C9R0101 { get; set; }
        public string Nmsubjreport010 { get; set; }
        public string NumString1 { get; set; }

        public virtual DcArpReport0503364 Doc { get; set; }
    }
}
