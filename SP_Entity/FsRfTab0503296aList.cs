using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRfTab0503296aList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R21 { get; set; }
        public decimal? C2R21 { get; set; }
        public decimal? C3R21 { get; set; }

        public virtual DcArpf0503295 Doc { get; set; }
    }
}
