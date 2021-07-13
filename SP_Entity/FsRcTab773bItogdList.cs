using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRcTab773bItogdList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R3a1 { get; set; }
        public string C1R3b1 { get; set; }
        public string C1R3c1 { get; set; }
        public decimal? C2R3d1 { get; set; }

        public virtual DcArpReport0503773D Doc { get; set; }
    }
}
