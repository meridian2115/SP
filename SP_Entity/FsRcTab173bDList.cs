using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRcTab173bDList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR31 { get; set; }
        public string C1bR31 { get; set; }
        public decimal? C2R31 { get; set; }
        public string C3R31 { get; set; }
        public string C4R31 { get; set; }
        public string C5R31 { get; set; }
        public string C1cR31 { get; set; }
        public string C1bR3S { get; set; }
        public string C1bR3V { get; set; }

        public virtual DcArpReport0503173D Doc { get; set; }
    }
}
