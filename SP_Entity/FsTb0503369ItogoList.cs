using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTb0503369ItogoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR2 { get; set; }
        public string C1bR2 { get; set; }
        public string C1cR2 { get; set; }
        public string C1dR2 { get; set; }
        public string C1R2All { get; set; }
        public decimal? C2R2 { get; set; }
        public decimal? C3R2 { get; set; }
        public decimal? C4R2 { get; set; }
        public decimal? C5R2 { get; set; }

        public virtual DcArpReport0503369 Doc { get; set; }
    }
}
