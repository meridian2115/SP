using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTotalmoveinfoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R0302 { get; set; }
        public string C2R0302 { get; set; }
        public decimal? C3R0302 { get; set; }
        public decimal? C4R0302 { get; set; }
        public decimal? C5R0302 { get; set; }

        public virtual DcReport0503769 Doc { get; set; }
    }
}
