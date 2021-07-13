using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAhR8100List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1001 { get; set; }
        public string C2R1001 { get; set; }
        public decimal? C3R1001 { get; set; }
        public decimal? C4R1001 { get; set; }

        public virtual DcReport0503117Fb Doc { get; set; }
    }
}
