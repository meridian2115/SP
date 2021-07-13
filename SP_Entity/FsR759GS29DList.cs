using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS29DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS29DC1 { get; set; }
        public DateTime? GS29DC2 { get; set; }
        public string GS29DC3 { get; set; }
        public string GS29DC4 { get; set; }
        public string GS29DC5 { get; set; }
        public decimal? GS29DC6 { get; set; }
        public decimal? GS29DC7 { get; set; }
        public decimal? GS29DC8 { get; set; }
        public string GS29DDocHGuid { get; set; }
        public string GS29DDocLGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
