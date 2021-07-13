using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAcR3826List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R8261 { get; set; }
        public string C2R8261 { get; set; }
        public string C3R8261 { get; set; }
        public string C3nR8261 { get; set; }
        public string C4R8261 { get; set; }
        public string C4vR8261 { get; set; }
        public string C4nR8261 { get; set; }
        public string C5R8261 { get; set; }
        public string C5aR8261 { get; set; }
        public decimal? C6R8261 { get; set; }
        public decimal? C7R8261 { get; set; }
        public decimal? C8R8261 { get; set; }
        public decimal? C9R8261 { get; set; }
        public decimal? Num826 { get; set; }
        public DateTime? RepDate826 { get; set; }

        public virtual DcArpReport0531342 Doc { get; set; }
    }
}
