using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRd1TR1127uList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public string C3R1 { get; set; }
        public string C4R1 { get; set; }
        public string C5R1 { get; set; }
        public string C6R1 { get; set; }
        public string C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public decimal? C9R1 { get; set; }
        public decimal? C10R1 { get; set; }

        public virtual DcArpReport0503127u Doc { get; set; }
    }
}
