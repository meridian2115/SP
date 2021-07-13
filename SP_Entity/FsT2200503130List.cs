using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT2200503130List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2101 { get; set; }
        public decimal? C4R2101 { get; set; }
        public decimal? C5R2101 { get; set; }
        public string S9 { get; set; }

        public virtual DcArpReport0503130D Doc { get; set; }
    }
}
