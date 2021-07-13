using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRd2TR2itog127uList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2 { get; set; }
        public decimal? C2R2 { get; set; }
        public decimal? C3R2 { get; set; }
        public decimal? C4R2 { get; set; }

        public virtual DcArpReport0503127u Doc { get; set; }
    }
}
