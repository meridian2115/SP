using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsReFkrList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R051 { get; set; }
        public string C2R051 { get; set; }
        public string C2aR051 { get; set; }
        public decimal? C3R051 { get; set; }
        public decimal? C4R051 { get; set; }

        public virtual DcArpO0504072 Doc { get; set; }
    }
}
