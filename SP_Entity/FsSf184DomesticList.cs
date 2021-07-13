using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSf184DomesticList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R5202 { get; set; }
        public string C2R5202 { get; set; }
        public string C3R5202a { get; set; }
        public string C3R520All { get; set; }
        public string C3R5202b { get; set; }
        public decimal? C4R5202 { get; set; }

        public virtual DcReport0503184 Doc { get; set; }
    }
}
