using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT0100503130List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R0101 { get; set; }
        public decimal? C4R0101 { get; set; }
        public decimal? C5R0101 { get; set; }
        public string S { get; set; }

        public virtual DcArpReport0503130D Doc { get; set; }
    }
}
