using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS32DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS32DC1 { get; set; }
        public DateTime? GS32DC2 { get; set; }
        public decimal? GS32DC3 { get; set; }
        public decimal? GS32DC4 { get; set; }
        public decimal? GS32DC5 { get; set; }
        public decimal? GS32DC6 { get; set; }
        public decimal? GS32DC7 { get; set; }
        public decimal? GS32DC8 { get; set; }
        public string GS32DDocHGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
