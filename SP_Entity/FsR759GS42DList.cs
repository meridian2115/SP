using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS42DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS42DC1 { get; set; }
        public DateTime? GS42DC2 { get; set; }
        public string GS42DC3 { get; set; }
        public DateTime? GS42DC4 { get; set; }
        public decimal? GS42DC5 { get; set; }
        public decimal? GS42DC6 { get; set; }
        public decimal? GS42DC7 { get; set; }
        public string GS42DC8 { get; set; }
        public string GS42DDocHGuid { get; set; }
        public string GS42DDocLGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
