using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS121DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS121DC1 { get; set; }
        public DateTime? GS121DC2 { get; set; }
        public string GS121DC3 { get; set; }
        public decimal? GS121DC4 { get; set; }
        public decimal? GS121DC5 { get; set; }
        public decimal? GS121DC6 { get; set; }
        public decimal? GS121DC7 { get; set; }
        public decimal? GS121DC8 { get; set; }
        public decimal? GS121DC9 { get; set; }
        public decimal? GS121DC10 { get; set; }
        public decimal? GS121DC11 { get; set; }
        public string GS121DDocHGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
