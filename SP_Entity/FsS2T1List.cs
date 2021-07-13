using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS2T1List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR1 { get; set; }
        public string C1bR1 { get; set; }
        public string C1cR3 { get; set; }
        public string C1dR1 { get; set; }
        public string C1eR1 { get; set; }
        public decimal? C2R1 { get; set; }
        public DateTime? C3R1 { get; set; }
        public DateTime? C4R1 { get; set; }
        public string C5R1 { get; set; }
        public string C6R1 { get; set; }
        public string C7R1 { get; set; }
        public string C8R1 { get; set; }
        public string PlanAccExp { get; set; }
        public string PlanT2Exp { get; set; }
        public string Groupattribute { get; set; }

        public virtual DcArpReport0503175 Doc { get; set; }
    }
}
