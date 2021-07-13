using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRcSourseList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R031 { get; set; }
        public string C2R031 { get; set; }
        public string C2aR031 { get; set; }
        public string C2bR031 { get; set; }
        public string C2cR031 { get; set; }
        public string C2dR031 { get; set; }
        public string C2eR031 { get; set; }
        public decimal? C3R031 { get; set; }
        public decimal? C4R031 { get; set; }
        public decimal? C5R031 { get; set; }
        public decimal? C6R031 { get; set; }

        public virtual DcArpO0504072 Doc { get; set; }
    }
}
