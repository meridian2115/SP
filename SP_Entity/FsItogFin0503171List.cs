using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsItogFin0503171List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1cR5001 { get; set; }
        public decimal? C2R5001 { get; set; }
        public string PlanT1aFin { get; set; }
        public string Cd7 { get; set; }
        public string C1eR2001 { get; set; }

        public virtual DcArpfinlinv0503171 Doc { get; set; }
    }
}
