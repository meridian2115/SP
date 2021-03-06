using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAaR1010List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0101 { get; set; }
        public string C2R0101 { get; set; }
        public string C3R0101 { get; set; }
        public string C3nR0101 { get; set; }
        public string C4R0101 { get; set; }
        public string C4nR0101 { get; set; }
        public string C4vR0101 { get; set; }
        public string C45R0101 { get; set; }
        public string C5R0101 { get; set; }
        public string C5aR0101 { get; set; }
        public decimal? C6R0101 { get; set; }
        public decimal? C7R0101 { get; set; }
        public decimal? C8R0101 { get; set; }
        public decimal? C9R0101 { get; set; }
        public decimal? Num010 { get; set; }
        public DateTime? RepDate010 { get; set; }
        public string PaCode { get; set; }

        public virtual DcArpReport0531342 Doc { get; set; }
    }
}
