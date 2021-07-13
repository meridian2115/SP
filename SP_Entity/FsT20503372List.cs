using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20503372List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R021 { get; set; }
        public string C1aR021 { get; set; }
        public string C1bR021 { get; set; }
        public string C1cR021 { get; set; }
        public string C1dR021 { get; set; }
        public decimal? C2R021 { get; set; }
        public decimal? C3R021 { get; set; }
        public string LncdR021 { get; set; }

        public virtual DcArpReport0503372 Doc { get; set; }
    }
}
