using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR758GS31DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public decimal? GS31DC1 { get; set; }
        public string GS31DC2 { get; set; }
        public DateTime? GS31DC3 { get; set; }
        public string GS31DC4 { get; set; }
        public decimal? GS31DC5 { get; set; }
        public decimal? GS31DC6 { get; set; }
        public decimal? GS31DC7 { get; set; }
        public decimal? GS31DC8 { get; set; }
        public decimal? GS31DC9 { get; set; }
        public decimal? GS31DC10 { get; set; }
        public decimal? GS31DC11 { get; set; }
        public string GS31DDocHGuid { get; set; }
        public string GS31DDocGuid { get; set; }

        public virtual DcVlsReport0531758 Doc { get; set; }
    }
}
