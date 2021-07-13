using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS27DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS27DC1 { get; set; }
        public DateTime? GS27DC2 { get; set; }
        public string GS27DC3 { get; set; }
        public string GS27DC4 { get; set; }
        public string GS27DC5 { get; set; }
        public decimal? GS27DC6 { get; set; }
        public decimal? GS27DC7 { get; set; }
        public decimal? GS27DC8 { get; set; }
        public decimal? GS27DC9 { get; set; }
        public decimal? GS27DC10 { get; set; }
        public string GS27DDocHGuid { get; set; }
        public string GS27DDocLGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
