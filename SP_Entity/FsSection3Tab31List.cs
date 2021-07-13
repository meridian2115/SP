using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSection3Tab31List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C2 { get; set; }
        public decimal? C3 { get; set; }
        public decimal? C4 { get; set; }
        public decimal? C5 { get; set; }
        public decimal? C6 { get; set; }
        public decimal? C7 { get; set; }
        public decimal? C8 { get; set; }
        public decimal? C9 { get; set; }

        public virtual DcArpReport0608031 Doc { get; set; }
    }
}
