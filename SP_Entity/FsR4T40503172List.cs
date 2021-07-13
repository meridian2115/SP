using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR4T40503172List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R41 { get; set; }
        public string C2aR41 { get; set; }
        public string C2bR41 { get; set; }
        public string C2cR41 { get; set; }
        public decimal? C3R41 { get; set; }
        public decimal? C4R41 { get; set; }
        public string C5R41 { get; set; }

        public virtual DcReport0503172 Doc { get; set; }
    }
}
