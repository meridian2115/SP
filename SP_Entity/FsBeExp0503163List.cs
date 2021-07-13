using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBeExp0503163List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C5bR0101 { get; set; }
        public string C5aR0101 { get; set; }
        public string C5R0101 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C3R2001 { get; set; }
        public decimal? C2R2001 { get; set; }
        public string C1bR2001 { get; set; }
        public string C1aR2001 { get; set; }
        public string C1R2001 { get; set; }
        public string C1cR2001 { get; set; }
        public string C1dR2001 { get; set; }
        public string C1eR2001 { get; set; }
        public string KbkR2001 { get; set; }
        public string C1cR20012 { get; set; }

        public virtual DcReport0503163 Doc { get; set; }
    }
}
