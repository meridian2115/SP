using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS25DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS25DC1 { get; set; }
        public DateTime? GS25DC2 { get; set; }
        public string GS25DC3 { get; set; }
        public DateTime? GS25DC4 { get; set; }
        public string GS25DC5 { get; set; }
        public string GS25DC6 { get; set; }
        public decimal? GS25DC7 { get; set; }
        public decimal? GS25DC8 { get; set; }
        public decimal? GS25DC9 { get; set; }
        public string GS25DDocHGuid { get; set; }
        public string GS25DDocLGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
