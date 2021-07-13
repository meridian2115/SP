using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfmvTb450460List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? C4R450 { get; set; }
        public decimal? C5R450 { get; set; }
        public decimal? C6R450 { get; set; }
        public decimal? C7R450 { get; set; }
        public string C3R450460 { get; set; }
        public string C2R450460 { get; set; }
        public string C1R450460 { get; set; }

        public virtual DcArp0503768D Doc { get; set; }
    }
}
