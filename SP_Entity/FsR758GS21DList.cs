using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR758GS21DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public decimal? GS21DC1 { get; set; }
        public string GS21DC2 { get; set; }
        public DateTime? GS21DC3 { get; set; }
        public string GS21DC4 { get; set; }
        public decimal? GS21DC5 { get; set; }
        public decimal? GS21DC6 { get; set; }
        public decimal? GS21DC7 { get; set; }
        public decimal? GS21DC8 { get; set; }
        public decimal? GS21DC9 { get; set; }
        public decimal? GS21DC10 { get; set; }
        public decimal? GS21DC11 { get; set; }
        public string GS21DDocHGuid { get; set; }
        public string GS21DDocGuid { get; set; }

        public virtual DcVlsReport0531758 Doc { get; set; }
    }
}
