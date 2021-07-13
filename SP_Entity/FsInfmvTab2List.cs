using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfmvTab2List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R4701 { get; set; }
        public decimal? C4R4701 { get; set; }
        public decimal? C5R4701 { get; set; }
        public decimal? C6R4701 { get; set; }
        public decimal? C7R4701 { get; set; }
        public string C2470 { get; set; }
        public string C3470 { get; set; }

        public virtual DcArp0503768D Doc { get; set; }
    }
}
