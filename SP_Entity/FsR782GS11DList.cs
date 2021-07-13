using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR782GS11DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS11DC1 { get; set; }
        public DateTime? GS11DC2 { get; set; }
        public decimal? GS11DC3 { get; set; }
        public decimal? GS11DC4 { get; set; }
        public decimal? GS11DC5 { get; set; }
        public string GS11DC6 { get; set; }

        public virtual DcVlsReport0531782 Doc { get; set; }
    }
}
