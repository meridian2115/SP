using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT2190503710List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R02100 { get; set; }
        public string C1aR02100 { get; set; }
        public string C1bR02100 { get; set; }
        public string C1cR02100 { get; set; }
        public string C2R02100 { get; set; }
        public string C3R02100 { get; set; }
        public decimal? C4R02100 { get; set; }
        public decimal? C5R02100 { get; set; }

        public virtual DcArpReport0503710 Doc { get; set; }
    }
}
