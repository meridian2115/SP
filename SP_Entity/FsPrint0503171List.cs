using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPrint0503171List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1bR2001 { get; set; }
        public string C1cR2001 { get; set; }
        public string C1dR2001 { get; set; }
        public string C1eR2001 { get; set; }
        public decimal? C2R2001 { get; set; }
        public string C3R2001 { get; set; }
        public string C4R2001 { get; set; }
        public string C5aR2001 { get; set; }
        public string C5bR2001 { get; set; }
        public string C5dR2001 { get; set; }
        public string C6dR2001 { get; set; }
        public string PlanAccExp { get; set; }
        public string PlanT1aExp { get; set; }
        public string NumString { get; set; }
        public string TypeString { get; set; }
        public string Cd7 { get; set; }

        public virtual DcArpfinlinv0503171 Doc { get; set; }
    }
}
